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
    public partial class CadastroFormaPagamento : Form
    {
        public CadastroFormaPagamento()
        {
            InitializeComponent();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if (ValidaFormulario())
            {
                FormaPagamento formaPagamento = new FormaPagamento();
                formaPagamento.NOME = textBoxNomeFormaPagamento.Text;
                formaPagamento.DESABILITADO = checkBoxDesabilitado.Checked == false ? 'N' : 'S';

                FormaPagamento.InserirNovaFormaPagamento(formaPagamento);

                MessageBox.Show("Forma de pagamento cadastrada com sucesso");

                this.Close();
            }
            else
            {
                MessageBox.Show("Preencha o formulário corretamente");
            }
        }

        private bool ValidaFormulario()
        {
            bool validacao = true;

            if (string.IsNullOrWhiteSpace(textBoxNomeFormaPagamento.Text))
            {
                validacao = false;
            }

            return validacao;
        }

        private void CadastroFormaPagamento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(13)) //ENTER
            {
                buttonSalvar_Click(sender, e);
            }

            if (e.KeyValue.Equals(27)) //ESC
            {
                this.Close();
            }
        }
    }
}
