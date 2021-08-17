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
    public partial class ConsultaProdutoVenda : Form
    {
        public List<Produto> produtosParaEscolher;
        public Produto produtoSelecionado = new Produto();

        public ConsultaProdutoVenda(List<Produto> produtos)
        {
            InitializeComponent();

            produtosParaEscolher = produtos;
            InserirProdutosNaConsulta(produtosParaEscolher);
        }

        // colocar os produtos no datagridview para selação
        private void InserirProdutosNaConsulta(List<Produto> produtosParaEscolher)
        {
            foreach (var produto in produtosParaEscolher)
            {
                int index = this.dataGridViewProdutos.Rows.Add();
                dataGridViewProdutos.Rows[index].Cells[1].Value = produto.CODIGO;
                dataGridViewProdutos.Rows[index].Cells[2].Value = produto.NOME;
                dataGridViewProdutos.Rows[index].Cells[3].Value = produto.PRECOVENDA;
                dataGridViewProdutos.Rows[index].Cells[4].Value = produto.ESTOQUE;
                dataGridViewProdutos.Rows[index].Cells[5].Value = produto.ID_PRODUTO;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = dataGridViewProdutos.SelectedRows[0].Index;

            produtoSelecionado.CODIGO = int.Parse(dataGridViewProdutos.Rows[index].Cells[1].Value.ToString());
            produtoSelecionado.NOME = dataGridViewProdutos.Rows[index].Cells[2].Value.ToString();
            produtoSelecionado.PRECOVENDA = decimal.Parse(dataGridViewProdutos.Rows[index].Cells[3].Value.ToString());
            produtoSelecionado.ID_PRODUTO = int.Parse(dataGridViewProdutos.Rows[index].Cells[5].Value.ToString());

            this.Close();
        }
    }
}
