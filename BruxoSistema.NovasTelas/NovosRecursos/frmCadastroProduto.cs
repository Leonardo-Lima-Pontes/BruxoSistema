using BruxoBiblioteca.NovasTelas.CadastroProduto;
using System;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace BruxoSistema.NovasTelas.NovosRecursos
{
    public partial class FrmCadastroProduto : XtraForm
    {
        public FrmCadastroProduto()
        {
            InitializeComponent();
        }

        private void BtnSair_Click(object sender, EventArgs e)
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

        private void BtnHabilitarCampos_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
        }

        private void HabilitarCampos()
        {
            this.Controls.OfType<TextEdit>().ToList().ForEach(labelConstrol => labelConstrol.Enabled = true);
            this.Controls.OfType<LabelControl>().ToList().ForEach(labelConstrol => labelConstrol.Enabled = true);

            txtNome.Focus();
        }

        private void BtnGravar_Click(object sender, EventArgs e)
        {
            RealizarCadastroProduto();
        }

        private void RealizarCadastroProduto()
        {
            try
            {
                bool loginInformacoesValidas = CadastroProdutoController.ValidarProduto(txtNome.Text, txtCodigo.Text, txtEstoque.Text, txtPreco.Text);
                if (!loginInformacoesValidas)
                {
                    MessageBox.Show(@"Por favor consagrado preencha os campos corretamente!");
                    return;
                }

                CadastroProdutoController.InserirNovoProduto(txtNome.Text, txtCodigo.Text, txtEstoque.Text, txtPreco.Text);

                MessageBox.Show(@"Produto cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($@"Ocorreu um erro por favor entre em contato com o Bruxo! {ex.Message} {ex.StackTrace}");
            }

            DesabilitarCampos();
        }

        private void DesabilitarCampos()
        {
            this.Controls.OfType<TextEdit>().ToList().ForEach(textBox =>
            {
                textBox.ResetText();
                textBox.Enabled = false;
            });

            this.Controls.OfType<LabelControl>().ToList().ForEach(labelConstrol => labelConstrol.Enabled = false);
        }

        private bool ValidarSeTemCampoPreenchido()
        {
            return !string.IsNullOrWhiteSpace(txtCodigo.Text)
                   || !string.IsNullOrWhiteSpace(txtEstoque.Text)
                   || !string.IsNullOrWhiteSpace(txtNome.Text)
                   || !string.IsNullOrWhiteSpace(txtPreco.Text);
        }

        private void FrmCadastrarProduto_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Close();
                    break;
                case Keys.F2:
                    HabilitarCampos();
                    break;
                case Keys.F5:
                    RealizarCadastroProduto();
                    break;
            }
        }
    }
}