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

            Close();
        }

        private void FrmCadastrarFormaPagamento_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    FecharFormulario();
                    break;
                case Keys.Enter:
                    SalvarFormaDePagamento();
                    break;
            }
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

        private void labelControl2_Click(object sender, EventArgs e)
        {
            FecharFormulario();
        }

        private void btnAvançar_Click(object sender, EventArgs e)
        {
            SalvarFormaDePagamento();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FecharFormulario();
        }
    }
}