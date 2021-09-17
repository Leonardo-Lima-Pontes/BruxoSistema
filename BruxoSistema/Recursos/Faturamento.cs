using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BruxoBiblioteca.NovasTelas.Faturamento;
using BruxoBiblioteca.NovasTelas.Models;

namespace BruxoSistema
{
    public partial class Faturamento : Form
    {
        public List<FormaPagamento> formasDePagamentosHabilitadas = new List<FormaPagamento>();
        public FormaPagamento formaPagamentoSelecionada;

        public Faturamento()
        {
            InitializeComponent();

            CarregarFormasDePagamento();
        }

        private void CarregarFormasDePagamento()
        {
            formasDePagamentosHabilitadas = FaturamentoController.SelecionarFormasDePagamentoHabilitadas();
            CriarBotoesDeFormasDePagamentos(formasDePagamentosHabilitadas);
        }

        private void CriarBotoesDeFormasDePagamentos(List<FormaPagamento> formasDePagamentosHabilitadas)
        {
            int posicaoInicialX = 70;
            int posicaoInicialY = 9;
            int tabIndex = 1;

            foreach (var forma in formasDePagamentosHabilitadas)
            {
                RadioButton novoBotão = new RadioButton();
                novoBotão.Tag = forma;
                novoBotão.Appearance = Appearance.Button;
                novoBotão.Text = forma.NOME;
                novoBotão.Location = new Point(posicaoInicialY, posicaoInicialX);
                novoBotão.Width = 160;
                novoBotão.TabIndex = tabIndex;
                novoBotão.Height = 50;
                novoBotão.BackColor = Color.White;
                novoBotão.TextAlign = ContentAlignment.MiddleCenter;
                novoBotão.AutoSize = false;
                novoBotão.FlatStyle = FlatStyle.Flat;
                novoBotão.Click += new EventHandler(MudarCorFormaPagamentoSelecionada);
                this.Controls.Add(novoBotão);

                tabIndex++;

                posicaoInicialY += 165;
                if (posicaoInicialY > 400)
                {
                    posicaoInicialX += 70;
                    posicaoInicialY = 9;
                }
            }

            Controls.OfType<RadioButton>().First().Select();
        }

        private void MudarCorFormaPagamentoSelecionada(object sender, EventArgs e)
        {
            foreach (RadioButton forma in Controls.OfType<RadioButton>())
            {
                if (forma.Checked == false)
                    forma.BackColor = Color.White;
                else
                    forma.BackColor = Color.LightBlue;
            }
        }

        private void btnFaturarVenda_Click(object sender, EventArgs e)
        {
            FaturarVenda();
        }

        private void FaturarVenda()
        {
            formaPagamentoSelecionada = (FormaPagamento)this.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Tag;
            Close();
        }

        private void FaturarOuSair_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                FaturarVenda();

            if (e.KeyCode == Keys.Escape)
                Close();
        }
    }
}
