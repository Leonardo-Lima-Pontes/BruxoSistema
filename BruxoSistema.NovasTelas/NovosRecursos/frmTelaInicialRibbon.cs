using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BruxoSistema.NovasTelas.NovosRecursos
{
    public partial class frmTelaInicialRibbon : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmTelaInicialRibbon()
        {
            InitializeComponent();
        }

        private void btnCadastroProdutos_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmCadastroProduto frm = new frmCadastroProduto();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnCadastroFormaPagamento_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmCadastroFormaPagamento frm = new frmCadastroFormaPagamento();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnVenda_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmPdv frm = new frmPdv();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnConfiguracoes_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmNovasTelasConfig frm = new frmNovasTelasConfig();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}