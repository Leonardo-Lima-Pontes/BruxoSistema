using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BruxoBiblioteca.NovasTelas.CadastroFormaPagamento;

namespace BruxoSistema
{
    public partial class CadastroFormaPagamento : Form
    {
        public CadastroFormaPagamento()
        {
            InitializeComponent();
        }

        private void btnSalvarFormaPagamento_Click(object sender, EventArgs e)
        {
            SalvarFormaDePagamento();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SalvarFormaDePagamento()
        {
                string nome = textBoxNomeFormaPagamento.Text;
                char desabilitado = checkBoxDesabilitado.Checked == false ? 'N' : 'S';

                bool formaPagamentoValida = CadastroFormaPagamentoController.ValidarFormaPagamento(nome, desabilitado);
                if (!formaPagamentoValida)
                {
                    MessageBox.Show("Por favor consagrado preencha os campos corretamente!");
                    return;
                }

                CadastroFormaPagamentoController.InserirNovaFormaPagamento(nome, desabilitado);

                MessageBox.Show("Forma de pagamento cadastrada com sucesso");

                this.Close();
        }

        private void CadastroFormaPagamento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SalvarFormaDePagamento();

            if (e.KeyCode == Keys.Escape)
                Close();
        }
    }
}
