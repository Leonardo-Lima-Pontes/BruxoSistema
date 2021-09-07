using BruxoBiblioteca.Controllers;
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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SalvarProduto();
        }

        private void SalvarProduto()
        {
            try
            {
                string nome = txtNomeProduto.Text;
                string codigo = txtCodigoProduto.Text;
                string estoque = txtEstoqueProduto.Text;
                string precoVenda = txtPrecoVendaProduto.Text;

                bool loginInformacoesValidas = CadastroProdutoController.ValidarProduto(nome, codigo, estoque, precoVenda);
                if (!loginInformacoesValidas)
                {
                    MessageBox.Show("Por favor consagrado preencha os campos corretamente!");
                    return;
                }

                CadastroProdutoController.InserirNovoProduto(nome, codigo, estoque, precoVenda);

                MessageBox.Show("Produto cadastrado com sucesso!");
                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro por favor entre em contato com o Bruxo! \n {ex.Message} \n {ex.StackTrace}");
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            if (!ValidarSeTemCampoPreenchido())
                Close();

            var resultado = MessageBox.Show("Os itens da venda serão perdidos",
                "Limpar Venda", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
                Close();
        }

        private bool ValidarSeTemCampoPreenchido()
        {
            if (!string.IsNullOrWhiteSpace(txtCodigoProduto.Text)
                || !string.IsNullOrWhiteSpace(txtEstoqueProduto.Text)
                || !string.IsNullOrWhiteSpace(txtNomeProduto.Text)
                || !string.IsNullOrWhiteSpace(txtPrecoVendaProduto.Text))
            {
                return true;
            }

            return false;
        }

        private void CadastroProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SalvarProduto();

            if (e.KeyCode == Keys.Escape)
                Close();
        }
    }
}
