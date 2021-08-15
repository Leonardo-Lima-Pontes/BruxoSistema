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
    public partial class PDV : Form
    {
        public PDV()
        {
            InitializeComponent();

            labelVendedor.Text = UsuarioSessao.Nomeusuario;
        }

        //fechar pdv
        private void PDV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27)) //ESC
            {
                var resultado = MessageBox.Show("Deseja fechar a tela de vendas ?", "SAIR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }

        //lança produto
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            //VALIDA INFOMAÇÃO - OK
            //PROCURA NO BANCO DE DADOS E RETORNA - OK
            //COLOCA O PRODUTO NO BOX
            //SALVA AS INFORMAÇÕES DE PEDIDO
            //SALVA AS INFORMAÇÕES DE PRODUTO PEDIDO


            if (e.KeyValue.Equals(13)) //Enter
            {
                if (ValidaInformacaoProduto())
                {
                    // encontra produto no banco com base no codigo
                    int codigoProduto = int.Parse(textBoxPesquisaProduto.Text);
                    List<Produto> produtosParaVenda = Produto.SelecionarProdutoVenda(codigoProduto);

                    if (produtosParaVenda.Count == 0)
                    {
                        MessageBox.Show("produto não encontrado");
                        return;
                    }

                    if (produtosParaVenda.Count == 1)
                    {
                        int index = this.dataGridViewProdutos.Rows.Add();
                        dataGridViewProdutos.Rows[index].Cells[0].Value = produtosParaVenda[0].CODIGO;
                        dataGridViewProdutos.Rows[index].Cells[1].Value = produtosParaVenda[0].NOME;
                        dataGridViewProdutos.Rows[index].Cells[2].Value = produtosParaVenda[0].PRECOVENDA;
                        dataGridViewProdutos.Rows[index].Cells[3].Value = 1;
                        dataGridViewProdutos.Rows[index].Cells[4].Value = produtosParaVenda[0].PRECOVENDA;
                        textBoxPesquisaProduto.Text = "";

                        labelTotal.Text = dataGridViewProdutos.Rows.Cast<DataGridViewRow>().Sum(i => Convert.ToDecimal(i.Cells[4].Value)).ToString("N2");
                    } 
                    else if (produtosParaVenda.Count > 1)
                    {
                        //TODO - abrir tela de pesquisa de produtos para selação
                    }
                }
                else
                {
                    MessageBox.Show("Informe o codigo do produto de maneira correta");
                }

            }
        }

        //valida pesquisa
        private bool ValidaInformacaoProduto()
        {
            bool validacao = true;

            if (string.IsNullOrWhiteSpace(textBoxPesquisaProduto.Text))
            {
                validacao = false;
            }

            bool validaCodigo = int.TryParse(textBoxPesquisaProduto.Text, out int codigoProduto);
            if (!validaCodigo)
            {
                validacao = false;
            }

            return validacao;
        }

        private void dataGridViewProdutos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewProdutos.RowCount > 0)
            {
                decimal novoValorUnitario = decimal.Parse(dataGridViewProdutos.Rows[e.RowIndex].Cells[2].Value.ToString());
                decimal novaQuantidade = decimal.Parse(dataGridViewProdutos.Rows[e.RowIndex].Cells[3].Value.ToString());
                dataGridViewProdutos.Rows[e.RowIndex].Cells[4].Value = novoValorUnitario * novaQuantidade;
            }
        }
    }
}
