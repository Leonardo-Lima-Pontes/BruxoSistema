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
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void TelaInicial_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = UsuarioSessao.Nomeusuario;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            CadastroProduto cadastroProduto = new CadastroProduto();
            cadastroProduto.ShowDialog();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            CadastroFormaPagamento formaPagamento = new CadastroFormaPagamento();
            formaPagamento.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            PDV pdv = new PDV();
            pdv.ShowDialog();
        }
    }
}
