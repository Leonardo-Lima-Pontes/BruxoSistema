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
                case 1: LancarProdutoNaVenda(produtosParaVenda[0]); break;
                default: SelecionarProduto(produtosParaVenda); break;
            }
        }

        private void SelecionarProduto(List<Produto> produtos)
        {
            using (ConsultaProdutoVenda consultaProdutoVenda = new ConsultaProdutoVenda(produtos))
            {
                consultaProdutoVenda.ShowDialog();

                Produto produtoParaVenda = consultaProdutoVenda.produtoSelecionado;

                if (produtoParaVenda.NOME != null)
                {
                    InserirProdutoNaVenda(consultaProdutoVenda.produtoSelecionado);
                    AtualizarTotalDaVenda();
                    AtualizarTotalQuantidadeItemDaVenda();
                    FocarQuantidade();
                }
            }
        }

        private void LancarProdutoNaVenda(Produto produto)
        {
            InserirProdutoNaVenda(produto);
            AtualizarTotalDaVenda();
            AtualizarTotalQuantidadeItemDaVenda();
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

        // Atualiza o totalizador de items na venda
        private void AtualizarTotalQuantidadeItemDaVenda()
        {
            labelQuantidadeItens.Text = dataGridViewProdutos.Rows.Cast<DataGridViewRow>().Sum(i => Convert.ToDecimal(i.Cells[3].Value)).ToString();
        }

        // Atualiza o totalizador da venda
        private void AtualizarTotalDaVenda()
        {
            labelTotalVenda.Text = dataGridViewProdutos.Rows.Cast<DataGridViewRow>().Sum(i => Convert.ToDecimal(i.Cells[4].Value)).ToString("N2");
        }

        // Inseri produto no datagridview
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

        private bool ValidarInformacaoProduto()
        {
            bool validacao = true;

            if (string.IsNullOrWhiteSpace(textBoxPesquisaProduto.Text))
            {
                validacao = false;
            }

            bool validaCodigo = int.TryParse(textBoxPesquisaProduto.Text, out int codigoProduto);
            if (!validaCodigo)
            {
                validacao = false;
            }

            return validacao;
        }

        // Atualiza o valor total do produto com base na mudança de quantidade/valor
        private void dataGridViewProdutos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewProdutos.RowCount > 0)
            {
                decimal novoValorUnitario = decimal.Parse(dataGridViewProdutos.Rows[e.RowIndex].Cells[2].Value.ToString());
                decimal novaQuantidade = decimal.Parse(dataGridViewProdutos.Rows[e.RowIndex].Cells[3].Value.ToString());
                dataGridViewProdutos.Rows[e.RowIndex].Cells[4].Value = novoValorUnitario * novaQuantidade;
                AtualizarTotalDaVenda();
                AtualizarTotalQuantidadeItemDaVenda();
                textBoxPesquisaProduto.Select();
                dataGridViewProdutos.ClearSelection();
            }
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

            // criar novo formulario de consulta no formulario tem um objeto de produto que sera instalanciado
            // conforme selecao do usuario chama metodo para instaciar o produto que é acesso
            using (Faturamento telaDeFaturamento = new Faturamento())
            {
                telaDeFaturamento.ShowDialog();
                formaPagamentoSelecionada = telaDeFaturamento.formaPagamentoSelecionada;
                //TODO - retornar método de pagamento escolhido
                if (formaPagamentoSelecionada.NOME != null)
                {
                    FinalizaVenda(formaPagamentoSelecionada);
                }
            }
        }

        /// <summary>
        /// Instacia o objeto pedido para insercao no banco de dados, contendo todos os dados valor total do pedido
        /// id do usuario logado na sessao forma de pagamento e lista de pedidoproduto (produtos vendedidos e informações 
        /// sobre cada vende desse produto quantidade e valor
        /// </summary>
        /// <param name="formaPagamentoSelecionada">forma de pagamento selecionada pelo usuario</param>
        private void FinalizaVenda(FormaPagamento formaPagamentoSelecionada)
        {
            Usuario usuarioDaSessao = new Usuario();
            usuarioDaSessao.ID_USUARIO = UsuarioSessao.IdUsuario;
            usuarioDaSessao.NOME = UsuarioSessao.Nomeusuario;

            List<PedidoProduto> produtosDoPedido = new List<PedidoProduto>();

            foreach (DataGridViewRow row in dataGridViewProdutos.Rows)
            {
                PedidoProduto produtoDoPedido = new PedidoProduto();
                produtoDoPedido.QUANTIDADE = decimal.Parse(row.Cells[3].Value.ToString());
                produtoDoPedido.VALOR = decimal.Parse(row.Cells[4].Value.ToString());
                produtoDoPedido.PRODUTO_ID = int.Parse(row.Cells[5].Value.ToString());

                produtosDoPedido.Add(produtoDoPedido);
            }

            Pedido pedidoFinalizado = new Pedido();
            pedidoFinalizado.FORMAPAMENTO_ID = formaPagamentoSelecionada;
            pedidoFinalizado.USUARIO_ID = usuarioDaSessao;
            pedidoFinalizado.VALORPEDIDO = decimal.Parse(labelTotalVenda.Text);
            pedidoFinalizado.PRODUTOSVENDIDOS = produtosDoPedido;

            Pedido.InserirNovoPedido(pedidoFinalizado);

            MessageBox.Show("Venda Finalizada");
            ResetarVenda();
        }

        private void ResetarVenda()
        {
            dataGridViewProdutos.Rows.Clear();
            dataGridViewProdutos.Refresh();
            labelTotalVenda.ResetText();
            labelQuantidadeItens.ResetText();
        }

        //começar edição do valor assim que clicar na celular
        private void dataGridViewProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewProdutos.BeginEdit(true);
        }

        private void button2_Click(object sender, EventArgs e)
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
