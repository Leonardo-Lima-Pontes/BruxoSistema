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
    public partial class Faturamento : Form
    {
        public List<FormaPagamento> formasDePagamentosHabilitadas = new List<FormaPagamento>();
        public FormaPagamento formaPagamentoSelecionada = new FormaPagamento();

        public Faturamento()
        {
            InitializeComponent();

            CarregarFormasDePagamento();
        }

        //carrega todas formas de pagamentos habilitadas no sistema
        private void CarregarFormasDePagamento()
        {
            formasDePagamentosHabilitadas = FormaPagamento.SelecionarFormasDePagamentoHabilitadas();

            int posicaoInicialX = 20;
            int posicaoInicialY = 10;

            foreach (var forma in formasDePagamentosHabilitadas)
            {

                RadioButton novoBotão = new RadioButton();
                novoBotão.Tag = forma;
                novoBotão.Appearance = Appearance.Button;
                novoBotão.Text = forma.NOME;
                novoBotão.Location = new Point(posicaoInicialY, posicaoInicialX);
                this.Controls.Add(novoBotão);

                posicaoInicialY += 100;
                if (posicaoInicialY > 620)
                {
                    posicaoInicialX += 50;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formaPagamentoSelecionada = (FormaPagamento)this.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Tag;
            this.Close();
        }
    }
}
