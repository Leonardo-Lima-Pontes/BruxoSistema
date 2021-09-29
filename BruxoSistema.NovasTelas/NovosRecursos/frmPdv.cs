using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BruxoBiblioteca.NovasTelas.Models;
using BruxoBiblioteca.NovasTelas.PDV;
using DevExpress.XtraGrid.Views.Grid;

namespace BruxoSistema.NovasTelas.NovosRecursos
{
    public partial class frmPdv : DevExpress.XtraEditors.XtraForm
    {
        private List<Produto> produtosDaVenda = new List<Produto>();
        private GridView view;

        public frmPdv()
        {
            InitializeComponent();
              view = dgvProdutos.MainView as GridView;
        }

        private void TxtBuscaProdutos_KeyDown(object sender, KeyEventArgs e)
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
            var entradaUsuario = txtBuscaProdutos.Text;
            bool validado = PdvController.ValidarEntradaUsuario(entradaUsuario);

            if (!validado)
            {
                MessageBox.Show("Consagrado por favor entre com um produto valido !");
                txtBuscaProdutos.Text = "";
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
            int codigoProduto = int.Parse(txtBuscaProdutos.Text);
            List<Produto> produtosParaVenda = PdvController.SelecionarProdutosVenda(codigoProduto);

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
            using (FrmConsultaProdutoVenda consultaProdutoVenda = new FrmConsultaProdutoVenda(produtos))
            {
                consultaProdutoVenda.ShowDialog();

                Produto produtoParaVenda = consultaProdutoVenda.ProdutoSelecionado;

                RealizarProcessoLancarProduto(produtoParaVenda);
            }
        }

        private void InformarProdutoNaoEncontrado()
        {
            MessageBox.Show("produto não encontrado");
            txtBuscaProdutos.Text = "";
        }

        private void RealizarProcessoLancarProduto(Produto produto)
        {
            bool validaProduto = PdvController.ValidarProdutoParaVenda(produto);
            if (validaProduto == false)
                return;

            InserirProdutoNaVenda(produto);
            AtualizarTotalDaVenda();
            AtualizarTotalItensDaVenda();

            if (ConfiguracoesGlobais.NovosFluxos.ModificaQuantidade) dgvProdutos.Select();
        }

        private void InserirProdutoNaVenda(Produto produtoParaVenda)
        {
            produtosDaVenda.Add(produtoParaVenda);
            AtualizarDataGridComDataSource();
            txtBuscaProdutos.ResetText();
            view.MoveLast();
        }

        private void AtualizarDataGridComDataSource()
        {
            dgvProdutos.DataSource = produtosDaVenda;
            dgvProdutos.RefreshDataSource();
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (view == null) return;
            if (e.Column.FieldName == "QUANTIDADE" || e.Column.FieldName == "PRECOVENDA")
            {
                decimal novaQuantidade = decimal.Parse(view.GetRowCellValue(e.RowHandle, view.Columns["QUANTIDADE"]).ToString());
                decimal novoValorUnitario = decimal.Parse(view.GetRowCellValue(e.RowHandle, view.Columns["PRECOVENDA"]).ToString());

                decimal novoValorTotal = PdvController.RecalcularPrecoTotalVendaProduto(novoValorUnitario, novaQuantidade);

                view.SetRowCellValue(e.RowHandle, view.Columns["VALORTOTAL"], novoValorTotal);

                AtualizarTotalDaVenda();
                AtualizarTotalItensDaVenda();
                txtBuscaProdutos.Select();
                view.ClearSelection();

                produtosDaVenda = (dgvProdutos.DataSource as IEnumerable<Produto>).ToList();
            }
        }

        private void AtualizarTotalItensDaVenda()
        {
            lblTotalItens.Text = produtosDaVenda.Sum(x => x.QUANTIDADE).ToString();
        }

        private void AtualizarTotalDaVenda()
        {
            lblValorTotal.Text = produtosDaVenda.Sum(x => x.VALORTOTAL).ToString("N2");
        }

        private void frmPdv_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Escape) return;
            var resultado = MessageBox.Show("Deseja fechar a tela de vendas ?", "SAIR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultado == DialogResult.Yes)
            {
                Close();
            }
        }

        private void BtnAvançar_Click(object sender, EventArgs e)
        {
            FaturarVenda();
        }

        private void FaturarVenda()
        {
            if (view.RowCount < 1)
            {
                MessageBox.Show("Consagrado insira produtos para que possamos prosseguir com a venda");
                return;
            }

            FormaPagamento formaPagamentoSelecionada;
            using (FrmFaturamento telaDeFaturamento = new FrmFaturamento())
            {
                telaDeFaturamento.ShowDialog();
                formaPagamentoSelecionada = telaDeFaturamento.FormaPagamentoSelecionada;

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


                Pedido pedidoFinalizado = PegarInformacoesDoPedido();
                if (pedidoFinalizado == null)
                    return;

                pedidoFinalizado.FORMAPAMENTO_ID = formaPagamentoSelecionada;
                pedidoFinalizado.PRODUTOS = produtosDaVenda;
                pedidoFinalizado.USUARIO_ID = usuarioDaVenda;

                PdvController.InserirNovoPedido(pedidoFinalizado);

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

            pedidoFinalizado.VALORPEDIDO = decimal.Parse(lblValorTotal.Text);

            bool pedidoValidado = PdvController.ValidarPedido(pedidoFinalizado);
            if (!pedidoValidado)
            {
                MessageBox.Show("Consagrado por favor esses produtos não podem ser inseridos desta maneira na venda!");
                return null;
            }

            return pedidoFinalizado;
        }

        private Usuario PegarUsuario()
        {
            Usuario usuarioDaVenda = new Usuario();
            usuarioDaVenda.ID_USUARIO = UsuarioSessao.IdUsuario;
            usuarioDaVenda.NOME = UsuarioSessao.NomeUsuario;

            bool usuarioValidado = PdvController.ValidarUsuario(usuarioDaVenda);
            if (!usuarioValidado)
            {
                MessageBox.Show("Consagrado a venda não pode ser concluida pois não há usuario logado no sistema!");
                return null;
            }

            return usuarioDaVenda;
        }

        private void ResetarVenda()
        {
            produtosDaVenda.Clear();
            AtualizarDataGridComDataSource();
            lblTotalItens.Text = "0";
            lblValorTotal.Text = "0,00";
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            if (view.RowCount > 0)
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