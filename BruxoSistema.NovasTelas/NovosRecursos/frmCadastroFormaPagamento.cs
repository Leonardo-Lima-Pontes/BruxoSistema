using BruxoBiblioteca.NovasTelas.CadastroFormaPagamento;
using System;
using System.Windows.Forms;

namespace BruxoSistema.NovasTelas.NovosRecursos
{
    public partial class FrmCadastroFormaPagamento : DevExpress.XtraEditors.XtraForm
    {
        public FrmCadastroFormaPagamento()
        {
            InitializeComponent();
        }

        private void BtnGravar_Click(object sender, EventArgs e)
        {
            SalvarFormaDePagamento();
        }

        private void SalvarFormaDePagamento()
        {
            char desabilitado = !tgsDesabilitado.IsOn ? 'N' : 'S';

            bool formaPagamentoValida = CadastroFormaPagamentoController.ValidarFormaPagamento(txtForma.Text, desabilitado);
            if (!formaPagamentoValida)
            {
                MessageBox.Show(@"Por favor consagrado preencha os campos corretamente!");
                return;
            }

            CadastroFormaPagamentoController.InserirNovaFormaPagamento(txtForma.Text, desabilitado);

            MessageBox.Show(@"Forma de pagamento cadastrada com sucesso");

            ResetarCampos();
            DesabilitarCampos();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
        }

        private void ResetarCampos()
        {
            txtForma.ResetText();
            tgsDesabilitado.IsOn = false;
        }

        private void DesabilitarCampos()
        {
            lblForma.Enabled = false;
            txtForma.Enabled = false;
            lblDesabilitado.Enabled = false;
            tgsDesabilitado.Enabled = false;
            btnHabilitar.Enabled = true;
            btnGravar.Enabled = false;
        }

        private void HabilitarCampos()
        {
            lblForma.Enabled = true;
            txtForma.Enabled = true;
            lblDesabilitado.Enabled = true;
            tgsDesabilitado.Enabled = true;
            btnHabilitar.Enabled = false;
            btnGravar.Enabled = true;
            txtForma.Focus();
        }

        private void FrmCadastrarFormaPagamento_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    FecharFormulario();
                    break;
                case Keys.F2:
                    HabilitarCampos();
                    break;
                case Keys.F5:
                    SalvarFormaDePagamento();
                    break;
            }
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            FecharFormulario();
        }

        private void FecharFormulario()
        {
            if (!ValidarSeTemCampoPreenchido())
            {
                Close();
                return;
            }

            var resultado = MessageBox.Show(@"Os itens da venda serão perdidos",
                @"Limpar Venda", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes) Close();
        }

        private bool ValidarSeTemCampoPreenchido()
        {
            return !string.IsNullOrWhiteSpace(txtForma.Text);
        }
    }
}