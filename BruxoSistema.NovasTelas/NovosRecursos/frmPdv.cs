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
        decimal precoUnitarioAtualProdutoEditando;
        private List<Produto> produtosDaVenda = new List<Produto>();

        public frmPdv()
        {
            InitializeComponent();
        }

        private void BtnAvançar_Click(object sender, EventArgs e)
        {
            
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
                case "": SelecionarOpcaoDeLancamentoProduto(); break;
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
        }

        private void InserirProdutoNaVenda(Produto produtoParaVenda)
        {
            produtosDaVenda.Add(produtoParaVenda);
            AtualizarDataGridComDataSource();
            txtBuscaProdutos.ResetText();
        }

        private void AtualizarDataGridComDataSource()
        {
            dgvProdutos.DataSource = produtosDaVenda;
            dgvProdutos.RefreshDataSource();
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            produtosDaVenda = (dgvProdutos.DataSource as IEnumerable<Produto>).ToList();
        }

        private void AtualizarTotalItensDaVenda()
        {
            lblTotalItens.Text = produtosDaVenda.Sum(x => x.QUANTIDADE).ToString();
        }

        private void AtualizarTotalDaVenda()
        {
            lblValorTotal.Text = produtosDaVenda.Sum(x => x.PRECOVENDA).ToString();
        }
    }
}