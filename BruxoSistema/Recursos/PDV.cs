using BruxoBiblioteca.Controllers;
using BruxoBiblioteca.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BruxoSistema
{
    public partial class PDV : Form
    {
        decimal precoUnitarioAtualProdutoEditando;

        public PDV()
        {
            InitializeComponent();
            labelVendedor.Text = UsuarioSessao.Nomeusuario;
            dataGridViewProdutos.Columns[2].DefaultCellStyle.Format = "0.00##";
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

        private void txtPesquisarProdutoEnter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
                return;

            try
            {
                FaturarVendaOuSelecionarProduto();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro por favor entre em contato com o Bruxo! \n {ex.Message} \n\n {ex.StackTrace}");

                var resultado = MessageBox.Show("Deseja encerrar a aplicação e esperar o Bruxo resolver o problema ?", "Bug no Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                    Application.Exit();
            }
        }

        private void FaturarVendaOuSelecionarProduto()
        {
            var entradaUsuario = txtPesquisaProduto.Text;
            bool validado = PDVController.ValidarEntradaUsuario(entradaUsuario);

            if (!validado)
            {
                MessageBox.Show("Consagrado por favor entre com um produto valido !");
                txtPesquisaProduto.Text = "";
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
            int codigoProduto = int.Parse(txtPesquisaProduto.Text);
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
            txtPesquisaProduto.Text = "";
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
            txtPesquisaProduto.Text = "";   

            precoUnitarioAtualProdutoEditando = produtoParaVenda.PRECOVENDA;
        }

        //quando deixa vazio lança exeção
        //quando é 0 da problema
        //quando deixar vazio ou 0 dar replace para 1 (igual no sigecom)

        private void dgvRecalcularValorTotalProduto_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridViewProdutos.RowCount < 0)
                    return;

                decimal novaQuantidade = PegarNovaQuantidade(e);
                decimal novoValorUnitario = PegarNovoValorUnitario(e);

                decimal novoValorTotal = PDVController.RecalcularPrecoTotalVendaProduto(novoValorUnitario, novaQuantidade);

                dataGridViewProdutos.Rows[e.RowIndex].Cells[4].Value = novoValorTotal;

                AtualizarTotalDaVenda();
                AtualizarTotalItensDaVenda();
                txtPesquisaProduto.Select();
                dataGridViewProdutos.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro por favor entre em contato com o Bruxo! \n {ex.Message} \n {ex.StackTrace}");
            }

        }

        private decimal PegarNovoValorUnitario(DataGridViewCellEventArgs e)
        {
            if (dataGridViewProdutos.Rows[e.RowIndex].Cells[2].Value == null ||
                    dataGridViewProdutos.Rows[e.RowIndex].Cells[2].Value.ToString() == "0" ||
                    dataGridViewProdutos.Rows[e.RowIndex].Cells[2].Value.ToString() == "")
            {
                dataGridViewProdutos.Rows[e.RowIndex].Cells[2].Value = precoUnitarioAtualProdutoEditando;
                return precoUnitarioAtualProdutoEditando;
            }
            else
            {
                return decimal.Parse(dataGridViewProdutos.Rows[e.RowIndex].Cells[2].Value.ToString());
            }
        }

        private decimal PegarNovaQuantidade(DataGridViewCellEventArgs e)
        {
            if (dataGridViewProdutos.Rows[e.RowIndex].Cells[3].Value == null ||
                dataGridViewProdutos.Rows[e.RowIndex].Cells[3].Value.ToString() == "0" ||
                dataGridViewProdutos.Rows[e.RowIndex].Cells[3].Value.ToString() == "")
            {
                dataGridViewProdutos.Rows[e.RowIndex].Cells[3].Value = 1;
                return 1;
            }
            else
            {
                return decimal.Parse(dataGridViewProdutos.Rows[e.RowIndex].Cells[3].Value.ToString());
            }
        }

        private void btnFaturarVenda_Click(object sender, EventArgs e)
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
            try
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

                PDVController.InserirNovoPedido(pedidoFinalizado);

                MessageBox.Show("Venda Finalizada");
                ResetarVenda();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro por favor entre em contato com o Bruxo! \n {ex.Message} \n\n {ex.StackTrace}");
            }
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
            precoUnitarioAtualProdutoEditando = decimal.Parse(dataGridViewProdutos.Rows[e.RowIndex].Cells[2].Value.ToString());
        }

        private void btnResetarVenda_Click(object sender, EventArgs e)
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

        private void dgvValidaDigito_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar != (char)Keys.Back) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
            if (e.KeyChar == ',' && (sender as TextBox).Text.IndexOf(',') > -1)
            {
                e.Handled = true;
            }
        }

        private void dgVerificaDigito_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(dgvValidaDigito_KeyPress);
            if (dataGridViewProdutos.CurrentCell.ColumnIndex == 2)
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(dgvValidaDigito_KeyPress);
                }
            }
            if (dataGridViewProdutos.CurrentCell.ColumnIndex == 3)
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(dgvValidaDigito_KeyPress);
                }
            }
        }
    }
}
