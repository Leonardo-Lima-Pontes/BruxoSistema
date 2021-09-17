using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BruxoBiblioteca.NovasTelas.Configuracoes;
using BruxoBiblioteca.NovasTelas.Models;
using BruxoSistema.NovasTelas.NovosRecursos;

namespace BruxoSistema.NovasTelas.Recursos
{
    public partial class frmLoginteste : DevExpress.XtraEditors.XtraForm
    {
        public frmLoginteste()
        {
            InitializeComponent();
            CarregarConfiguracoesIniciais();
        }

        private void CarregarConfiguracoesIniciais()
        {
            ConfiguracoesController.CarregarConfiguracoes();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            frmNovasTelasConfig config = new frmNovasTelasConfig();
            config.ShowDialog();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (ConfiguracoesGlobais.NovasTelas.NovaTelaInicial)
            {
                frmNovaTelaInicial novaTelaInicial = new frmNovaTelaInicial();
                novaTelaInicial.ShowDialog();
            }
            else
            {
                frmTelaInicial telaInicial = new frmTelaInicial();
                telaInicial.ShowDialog();
            }
        }
    }
}