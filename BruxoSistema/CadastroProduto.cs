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
    public partial class CadastroProduto : Form
    {
        public CadastroProduto()
        {
            InitializeComponent();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            // se caso os campos estiverem validados prossegue com o cadastro
            if (ValidarCampos())
            {
                // instacia os produtos com os dados informados pelo usuario
                Produto novoProduto = new Produto();
                novoProduto.NOME = textBoxNomeProduto.Text;
                novoProduto.CODIGO = int.Parse(textBoxCodigoProduto.Text);
                novoProduto.ESTOQUE = decimal.Parse(textBoxEstoqueProduto.Text);
                novoProduto.PRECOVENDA = decimal.Parse(textBoxPrecoVendaProduto.Text);

                Produto.InserirNovoProduto(novoProduto);

                MessageBox.Show("Produto cadastrado com sucesso!");

                this.Close();
            }
            else
            {
                MessageBox.Show("Preencha os campos corretamente");
            }
        }

        // valida campos do formulario
        private bool ValidarCampos()
        {
            bool validacao = true;

            if (string.IsNullOrWhiteSpace(textBoxCodigoProduto.Text) 
                || string.IsNullOrWhiteSpace(textBoxEstoqueProduto.Text)
                || string.IsNullOrWhiteSpace(textBoxNomeProduto.Text)
                || string.IsNullOrWhiteSpace(textBoxPrecoVendaProduto.Text))
            {
                validacao = false;
            }

            bool validaCodigo = int.TryParse(textBoxCodigoProduto.Text, out int resultadoCodigo);
            bool validaEstoque = decimal.TryParse(textBoxEstoqueProduto.Text, out decimal resultadoEstoque);
            bool validaPrecoVenda = decimal.TryParse(textBoxPrecoVendaProduto.Text, out decimal resultadoPrecoVenda);

            if (validaCodigo == false
                || validaEstoque == false
                || validaPrecoVenda == false)
            {
                validacao = false;
            }

            return validacao;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CadastroProduto_Load(object sender, EventArgs e)
        {

        }

        private void CadastroProduto_KeyDown(object sender, KeyEventArgs e)
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
