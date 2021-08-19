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

        //fechar pdv
        private void PDV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27)) //ESC
            {
                var resultado = MessageBox.Show("Deseja fechar a tela de vendas ?", "SAIR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }

        //lança produto
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            //ARRUMAR
            //colocar tela de selecionar produto poder selecionar mais de um produto
            //pesquisa tela de venda por nome do produto também

            // FUNCIONAL - MVP
            //criar tela de pesquisa - ok
            //arrumar totalizador quando alterar quantidade/valor unitario
            //criar metodo para enviar da tela de pesquisa os dados do produto selecionado - ok
            //criar tela de forma de pagamento
            //finalizar venda gravar no banco


            if (e.KeyValue.Equals(13)) //Enter
            {
                if (string.IsNullOrEmpty(textBoxPesquisaProduto.Text))
                {
                    button1_Click(sender, e);
                    return;
                }

                if (ValidaInformacaoProduto())
                {
                    // encontra produto no banco com base no codigo
                    int codigoProduto = int.Parse(textBoxPesquisaProduto.Text);
                    List<Produto> produtosParaVenda = Produto.SelecionarProdutoVenda(codigoProduto);

                    if (produtosParaVenda.Count == 0)
                    {
                        MessageBox.Show("produto não encontrado");
                        textBoxPesquisaProduto.Text = "";
                        return;
                    }

                    // se a consulta tiver somente um produto já lança no datagridview
                    if (produtosParaVenda.Count == 1)
                    {
                        InserirProdutoNaVenda(produtosParaVenda[0]);
                        AtualizarTotalDaVenda();
                        AtualizarTotalQuantidadeItemDaVenda();
                        FocarQuantidade();
                    } 
                    else if (produtosParaVenda.Count > 1)
                    {
                        // criar novo formulario de consulta no formulario tem um objeto de produto que sera instalanciado
                        // conforme selecao do usuario chama metodo para instaciar o produto que é acesso
                        using (ConsultaProdutoVenda consultaProdutoVenda = new ConsultaProdutoVenda(produtosParaVenda))
                        {
                            consultaProdutoVenda.ShowDialog();
                            Produto produtoParaVenda = consultaProdutoVenda.produtoSelecionado;
                            if (produtoParaVenda.NOME != null)
                            {
                                InserirProdutoNaVenda(consultaProdutoVenda.produtoSelecionado); //pega o produto instaciado e insere na datagridview de venda
                                AtualizarTotalDaVenda();
                                AtualizarTotalQuantidadeItemDaVenda();
                                FocarQuantidade();
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Informe o codigo do produto de maneira correta");
                }

            }
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

        //valida pesquisa
        private bool ValidaInformacaoProduto()
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

        //encerra entrada de intens e chama a tela de faturamento
        private void button1_Click(object sender, EventArgs e)
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
                formaPagamentoSelecionada =  telaDeFaturamento.formaPagamentoSelecionada;
                //TODO - retornar método de pagamento escolhido
                if (formaPagamentoSelecionada.NOME != null)
                {
                    FinalizaVenda(formaPagamentoSelecionada);
                }
            }
        }

        //ENTENDER SE HÁ NECESSIDADE DE PEDIDOPRODUTO TENHA ALINHADO O OBJETO PRODUTO ?
        //ENTENDER SE HÁ NECESSIDADE DE PEDIDO CONTER ANINHADO OS OBJETOS USUARIO FORMA PAMENTO ?
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
