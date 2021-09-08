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
            toolStripStatusLabel2.Text = UsuarioSessao.NomeUsuario;
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

        private void toolStripStatusLabel3_Click(object sender, EventArgs e)
        {
            DialogResult restarAplicacao = MessageBox.Show("Deseja realmente sair da conta meu consagrado ?", "Voltar para login", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (restarAplicacao == DialogResult.Yes)
            {
                Application.Restart();
            }
        }

        private void TelaInicial_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter: toolStripButton1_Click(sender, e); break;
                case Keys.F1: toolStripButton3_Click(sender, e); break;
                case Keys.F3: toolStripButton4_Click(sender, e); break;
                case Keys.Escape:

                    DialogResult result = MessageBox.Show("Deseja sair do sistema ?", "SAIR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        this.Close();
                    }
                    break;
            }
        }
    }
}
