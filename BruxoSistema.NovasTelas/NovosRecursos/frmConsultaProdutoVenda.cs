using BruxoBiblioteca.NovasTelas.Models;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BruxoSistema.NovasTelas.NovosRecursos
{
    public partial class FrmConsultaProdutoVenda : DevExpress.XtraEditors.XtraForm
    {
        public Produto ProdutoSelecionado = new Produto();
        public List<Produto> ProdutosParaEscolher;

        public FrmConsultaProdutoVenda(List<Produto> produtos)
        {
            InitializeComponent();
            ProdutosParaEscolher = produtos;
            dgvProdutos.DataSource = produtos;
        }

        private void FrmConsultaProdutoVenda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SelecionarProdutoParaVenda();

            if (e.KeyCode == Keys.Escape)
                Close();
        }

        private void SelecionarProdutoParaVenda()
        {
            if (dgvProdutos.MainView is GridView view)
            {
                int idProduto = int.Parse(view.GetFocusedRowCellValue("ID_PRODUTO").ToString());
                ProdutoSelecionado = ProdutosParaEscolher.Single(p => p.ID_PRODUTO == idProduto);
            }

            Close();
        }

        private void BtnReiniciar_Click(object sender, EventArgs e)
        {
            SelecionarProdutoParaVenda();
        }
    }
}