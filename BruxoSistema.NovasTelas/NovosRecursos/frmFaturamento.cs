using BruxoBiblioteca.NovasTelas.Faturamento;
using BruxoBiblioteca.NovasTelas.Models;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BruxoSistema.NovasTelas.NovosRecursos
{
    public partial class FrmFaturamento : DevExpress.XtraEditors.XtraForm
    {
        public List<FormaPagamento> FormasDePagamentosHabilitadas = new List<FormaPagamento>();
        public FormaPagamento FormaPagamentoSelecionada;

        public FrmFaturamento()
        {
            InitializeComponent();
            CarregarFormasDePagamento();
        }

        private void CarregarFormasDePagamento()
        {
            FormasDePagamentosHabilitadas = FaturamentoController.SelecionarFormasDePagamentoHabilitadas();
            CriarBotoesDeFormasDePagamentos(FormasDePagamentosHabilitadas);
        }

        private void CriarBotoesDeFormasDePagamentos(List<FormaPagamento> formasDePagamentosHabilitadas)
        {
            int posicaoInicialX = 70;
            int posicaoInicialY = 9;
            int tabIndex = 1;

            foreach (var forma in formasDePagamentosHabilitadas)
            {
                CheckButton novoBotão = new CheckButton();
                novoBotão.Tag = forma;
                novoBotão.Text = forma.NOME;
                novoBotão.Location = new Point(posicaoInicialY, posicaoInicialX);
                novoBotão.Width = 160;
                novoBotão.TabIndex = tabIndex;
                novoBotão.Height = 50;
                novoBotão.BorderStyle = BorderStyles.Simple;
                novoBotão.GroupIndex = 1;
                panelControl2.Controls.Add(novoBotão);

                tabIndex++;

                posicaoInicialY += 165;
                if (posicaoInicialY > 400)
                {
                    posicaoInicialX += 70;
                    posicaoInicialY = 9;
                }
            }

            panelControl2.Controls.OfType<CheckButton>().First().Select();
        }

        private void FaturarVenda()
        {
            FormaPagamentoSelecionada = (FormaPagamento)panelControl2.Controls.OfType<CheckButton>().FirstOrDefault(r => r.Checked).Tag;
            Close();
        }

        private void BtnFaturar_Click(object sender, EventArgs e)
        {
            FaturarVenda();
        }

        private void FrmConfirmarFaturamento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                FaturarVenda();

            if (e.KeyCode == Keys.Escape)
                Close();
        }
    }
}