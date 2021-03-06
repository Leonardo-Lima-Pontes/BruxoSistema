using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BruxoBiblioteca.NovasTelas.Models;

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

        private void InserirProdutosNaConsulta(List<Produto> produtosParaEscolher)
        {
            foreach (var produto in produtosParaEscolher)
            {
                int index = this.dataGridViewProdutos.Rows.Add();
                dataGridViewProdutos.Rows[index].Cells[0].Value = produto.CODIGO;
                dataGridViewProdutos.Rows[index].Cells[1].Value = produto.NOME;
                dataGridViewProdutos.Rows[index].Cells[2].Value = produto.PRECOVENDA;
                dataGridViewProdutos.Rows[index].Cells[3].Value = produto.ESTOQUE;
                dataGridViewProdutos.Rows[index].Cells[4].Value = produto.ID_PRODUTO;
            }
        }

        private void btnSelecionarProduto_Click(object sender, EventArgs e)
        {
            SelecionarProdutoParaVenda();
        }

        private void SelecionarProdutoParaVenda()
        {
            int index = dataGridViewProdutos.SelectedRows[0].Index;

            produtoSelecionado.CODIGO = int.Parse(dataGridViewProdutos.Rows[index].Cells[0].Value.ToString());
            produtoSelecionado.NOME = dataGridViewProdutos.Rows[index].Cells[1].Value.ToString();
            produtoSelecionado.PRECOVENDA = decimal.Parse(dataGridViewProdutos.Rows[index].Cells[2].Value.ToString());
            produtoSelecionado.ID_PRODUTO = int.Parse(dataGridViewProdutos.Rows[index].Cells[4].Value.ToString());

            Close();
        }

        private void SelecionarProdutoOuSair_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SelecionarProdutoParaVenda();

            if (e.KeyCode == Keys.Escape)
                Close();
        }
    }
}
