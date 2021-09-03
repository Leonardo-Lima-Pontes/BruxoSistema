using BruxoBiblioteca.Controllers;
using BruxoBiblioteca.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BruxoSistema
{
    public partial class PDV : Form
    {

        public PDV()
        {
            InitializeComponent();
            labelVendedor.Text = UsuarioSessao.Nomeusuario;
        }

        private void FecharPDV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                var resultado = MessageBox.Show("Deseja fechar a tela de vendas ?", "SAIR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }

        private void textBoxPesquisarProdutoEnter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
                return;

            FaturarVendaOuSelecionarProduto();
        }

        private void FaturarVendaOuSelecionarProduto()
        {
            var entradaUsuario = textBoxPesquisaProduto.Text;
            bool validado = PDVController.ValidarEntradaUsuario(entradaUsuario);

            if (!validado)
            {
                MessageBox.Show("Consagrado por favor entre com um produto valido !");
                return;
            }

            switch (entradaUsuario)
            {
                case "": FaturarVenda(); break;
                default: SelecionarOpcaoDeLancamentoProduto(); break;
            }
        }

        private void SelecionarOpcaoDeLancamentoProduto()
        {
            int codigoProduto = int.Parse(textBoxPesquisaProduto.Text);
            List<Produto> produtosParaVenda = PDVController.SelecionarProdutosVenda(codigoProduto);

            int opcaoLancamento = produtosParaVenda.Count;

            switch (opcaoLancamento)
            {
                case 0: InformarProdutoNaoEncontrado(); break;
                case 1: RealizarProcessoLancarProduto(produtosParaVenda[0]); break;
                default: SelecionarProduto(produtosParaVenda); break;
            }
        }

        private void SelecionarProduto(List<Produto> produtos)
        {
            using (ConsultaProdutoVenda consultaProdutoVenda = new ConsultaProdutoVenda(produtos))
            {
                consultaProdutoVenda.ShowDialog();

                Produto produtoParaVenda = consultaProdutoVenda.produtoSelecionado;

                RealizarProcessoLancarProduto(produtoParaVenda);
            }
        }

        private void RealizarProcessoLancarProduto(Produto produto)
        {
            bool validaProduto = PDVController.ValidarProdutoParaVenda(produto);
            if (validaProduto == false)
                return;

            InserirProdutoNaVenda(produto);
            AtualizarTotalDaVenda();
            AtualizarTotalItensDaVenda();
            FocarQuantidade();
        }

        private void InformarProdutoNaoEncontrado()
        {
            MessageBox.Show("produto não encontrado");
            textBoxPesquisaProduto.Text = "";
        }

        public void FocarQuantidade()
        {
            int ultimaLinhaInserida = dataGridViewProdutos.Rows.Count - 1;
            dataGridViewProdutos.CurrentCell = dataGridViewProdutos.Rows[ultimaLinhaInserida].Cells[3];
            dataGridViewProdutos.BeginEdit(true);
        }

        private void AtualizarTotalItensDaVenda()
        {
            labelQuantidadeItens.Text = dataGridViewProdutos.Rows.Cast<DataGridViewRow>().Sum(i => Convert.ToDecimal(i.Cells[3].Value)).ToString();
        }

        private void AtualizarTotalDaVenda()
        {
            labelTotalVenda.Text = dataGridViewProdutos.Rows.Cast<DataGridViewRow>().Sum(i => Convert.ToDecimal(i.Cells[4].Value)).ToString("N2");
        }

        private void InserirProdutoNaVenda(Produto produtoParaVenda)
        {
            int index = this.dataGridViewProdutos.Rows.Add();
            dataGridViewProdutos.Rows[index].Cells[0].Value = produtoParaVenda.CODIGO;
            dataGridViewProdutos.Rows[index].Cells[1].Value = produtoParaVenda.NOME;
            dataGridViewProdutos.Rows[index].Cells[2].Value = produtoParaVenda.PRECOVENDA;
            dataGridViewProdutos.Rows[index].Cells[3].Value = 1;
            dataGridViewProdutos.Rows[index].Cells[4].Value = produtoParaVenda.PRECOVENDA;
            dataGridViewProdutos.Rows[index].Cells[5].Value = produtoParaVenda.ID_PRODUTO;
            textBoxPesquisaProduto.Text = "";
        }

        private void dgvRecalcularValorTotalProduto_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewProdutos.RowCount < 0)
                return;

            decimal novoValorUnitario = decimal.Parse(dataGridViewProdutos.Rows[e.RowIndex].Cells[2].Value.ToString());
            decimal novaQuantidade = decimal.Parse(dataGridViewProdutos.Rows[e.RowIndex].Cells[3].Value.ToString());

            decimal novoValorTotal = PDVController.RecalcularPrecoTotalVendaProduto(novoValorUnitario, novaQuantidade);

            dataGridViewProdutos.Rows[e.RowIndex].Cells[4].Value = novoValorTotal;

            AtualizarTotalDaVenda();
            AtualizarTotalItensDaVenda();
            textBoxPesquisaProduto.Select();
            dataGridViewProdutos.ClearSelection();

        }

        private void buttonFaturarVenda_Click(object sender, EventArgs e)
        {
            FaturarVenda();
        }

        private void FaturarVenda()
        {
            if (dataGridViewProdutos.Rows.Count < 1)
            {
                MessageBox.Show("Consagrado insira produtos para que possamos prosseguir com a venda");
                return;
            }

            FormaPagamento formaPagamentoSelecionada;
            using (Faturamento telaDeFaturamento = new Faturamento())
            {
                telaDeFaturamento.ShowDialog();
                formaPagamentoSelecionada = telaDeFaturamento.formaPagamentoSelecionada;

                if (formaPagamentoSelecionada != null)
                    FinalizarVenda(formaPagamentoSelecionada);
            }
        }

        private void FinalizarVenda(FormaPagamento formaPagamentoSelecionada)
        {
            Usuario usuarioDaVenda = PegarUsuario();
            if (usuarioDaVenda == null)
                return;

            List<PedidoProduto> produtosDoPedido = PegarProdutosDoPedido();
            if (produtosDoPedido == null)
                return;

            Pedido pedidoFinalizado = PegarInformacoesDoPedido();
            if (pedidoFinalizado == null)
                return;

            pedidoFinalizado.FORMAPAMENTO_ID = formaPagamentoSelecionada;
            pedidoFinalizado.PRODUTOSVENDIDOS = produtosDoPedido;
            pedidoFinalizado.USUARIO_ID = usuarioDaVenda;

            Pedido.InserirNovoPedido(pedidoFinalizado);

            MessageBox.Show("Venda Finalizada");
            ResetarVenda();
        }

        private Pedido PegarInformacoesDoPedido()
        {
            Pedido pedidoFinalizado = new Pedido();

            pedidoFinalizado.VALORPEDIDO = decimal.Parse(labelTotalVenda.Text);

            bool pedidoValidado = PDVController.ValidarPedido(pedidoFinalizado);
            if (!pedidoValidado)
            {
                MessageBox.Show("Consagrado por favor esses produtos não podem ser inseridos desta maneira na venda!");
                return null;
            }

            return pedidoFinalizado;
        }

        private List<PedidoProduto> PegarProdutosDoPedido()
        {
            List<PedidoProduto> produtosDoPedido = new List<PedidoProduto>();

            foreach (DataGridViewRow row in dataGridViewProdutos.Rows)
            {
                PedidoProduto produtoDoPedido = new PedidoProduto();
                produtoDoPedido.QUANTIDADE = decimal.Parse(row.Cells[3].Value.ToString());
                produtoDoPedido.VALOR = decimal.Parse(row.Cells[4].Value.ToString());
                produtoDoPedido.PRODUTO_ID = int.Parse(row.Cells[5].Value.ToString());

                bool pedidoProdutoValidado = PDVController.ValidarPedidoProduto(produtoDoPedido);
                if (!pedidoProdutoValidado)
                {
                    MessageBox.Show("Consagrado por favor esses produtos não podem ser inseridos desta maneira na venda!");
                    return null;
                }

                produtosDoPedido.Add(produtoDoPedido);
            }

            return produtosDoPedido;
        }

        private Usuario PegarUsuario()
        {
            Usuario usuarioDaVenda = new Usuario();
            usuarioDaVenda.ID_USUARIO = UsuarioSessao.IdUsuario;
            usuarioDaVenda.NOME = UsuarioSessao.Nomeusuario;

            bool usuarioValidado = PDVController.ValidarUsuario(usuarioDaVenda);
            if (!usuarioValidado)
            {
                MessageBox.Show("Consagrado a venda não pode ser concluida pois não há usuario logado no sistema!");
                return null;
            }

            return usuarioDaVenda;
        }

        private void ResetarVenda()
        {
            dataGridViewProdutos.Rows.Clear();
            dataGridViewProdutos.Refresh();
            labelTotalVenda.ResetText();
            labelQuantidadeItens.ResetText();
        }

        private void dgvSelecionarCelulaInteira_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewProdutos.BeginEdit(true);
        }

        private void buttonResetarVenda_Click(object sender, EventArgs e)
        {

            if (dataGridViewProdutos.Rows.Count > 0)
            {
                var resultado = MessageBox.Show("Os itens da venda serão perdidos", "Limpar Venda", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                {
                    ResetarVenda();
                }
            }
        }
    }
}
