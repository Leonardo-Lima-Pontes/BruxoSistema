using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BruxoBiblioteca.NovasTelas.Models;
using BruxoSistema.NovasTelas.NovosRecursos;
using BruxoSistema.NovasTelas.Recursos;

namespace BruxoSistema
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();

            toolStripStatusLabel2.Text = UsuarioSessao.NomeUsuario;
        }

        private void btnAbrirTelaCadastroProduto_Click(object sender, EventArgs e)
        {
            AbrirTelaCadastroProduto();
        }

        private void AbrirTelaCadastroProduto()
        {
            CadastroProduto cadastroProduto = new CadastroProduto();
            cadastroProduto.ShowDialog();
        }

        private void btnAbrirTelaFormaPagamento_Click(object sender, EventArgs e)
        {
            AbrirTelaFormaPagamento();
        }

        private void AbrirTelaFormaPagamento()
        {
            CadastroFormaPagamento formaPagamento = new CadastroFormaPagamento();
            formaPagamento.ShowDialog();
        }

        private void btnAbrirTelaPDV_Click(object sender, EventArgs e)
        {
            AbrirTelaPDV();
        }

        private void AbrirTelaPDV()
        {
            PDV pdv = new PDV();
            pdv.ShowDialog();
        }

        private void btnVoltarParaTeleDeLogin_Click(object sender, EventArgs e)
        {
            VoltarParaTeleDeLogin();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            AbrirTelaConfiguracoes();
        }

        private void AbrirTelaConfiguracoes()
        {
            frmNovasTelasConfig frmCpnfig = new frmNovasTelasConfig();
            frmCpnfig.ShowDialog();
        }

        private void VoltarParaTeleDeLogin()
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
                case Keys.Enter: AbrirTelaPDV(); break;
                case Keys.F1: AbrirTelaFormaPagamento(); break;
                case Keys.F3: AbrirTelaCadastroProduto(); break;
                case Keys.Escape:SairDoSistema();break;
            }
        }

        private void SairDoSistema()
        {
            DialogResult result = MessageBox.Show("Deseja realmente sair do sistema ?", "SAIR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes) Close();
        }
    }
}
