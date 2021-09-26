
namespace BruxoSistema.NovasTelas.NovosRecursos
{
    partial class frmNovasTelasConfig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.btnGravarConfiguracoes = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tgsNovoFluxoFaturamento = new DevExpress.XtraEditors.ToggleSwitch();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.tgsModificarQuantidade = new DevExpress.XtraEditors.ToggleSwitch();
            ((System.ComponentModel.ISupportInitialize)(this.tgsNovoFluxoFaturamento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tgsModificarQuantidade.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(168, 27);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(112, 13);
            this.labelControl7.TabIndex = 18;
            this.labelControl7.Text = "Novas telas SigeBruxo";
            // 
            // btnGravarConfiguracoes
            // 
            this.btnGravarConfiguracoes.Location = new System.Drawing.Point(168, 191);
            this.btnGravarConfiguracoes.Name = "btnGravarConfiguracoes";
            this.btnGravarConfiguracoes.Size = new System.Drawing.Size(75, 23);
            this.btnGravarConfiguracoes.TabIndex = 23;
            this.btnGravarConfiguracoes.Text = "Gravar";
            this.btnGravarConfiguracoes.Click += new System.EventHandler(this.btnGravarConfiguracoes_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(263, 91);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(127, 13);
            this.labelControl1.TabIndex = 25;
            this.labelControl1.Text = "Novo Fluxo Faturamento";
            // 
            // tgsNovoFluxoFaturamento
            // 
            this.tgsNovoFluxoFaturamento.Location = new System.Drawing.Point(396, 85);
            this.tgsNovoFluxoFaturamento.Name = "tgsNovoFluxoFaturamento";
            this.tgsNovoFluxoFaturamento.Properties.OffText = "Off";
            this.tgsNovoFluxoFaturamento.Properties.OnText = "On";
            this.tgsNovoFluxoFaturamento.Size = new System.Drawing.Size(95, 25);
            this.tgsNovoFluxoFaturamento.TabIndex = 24;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(182, 122);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(208, 13);
            this.labelControl2.TabIndex = 27;
            this.labelControl2.Text = "Modificar quantidade ao lançar produto";
            // 
            // tgsModificarQuantidade
            // 
            this.tgsModificarQuantidade.Location = new System.Drawing.Point(396, 116);
            this.tgsModificarQuantidade.Name = "tgsModificarQuantidade";
            this.tgsModificarQuantidade.Properties.OffText = "Off";
            this.tgsModificarQuantidade.Properties.OnText = "On";
            this.tgsModificarQuantidade.Size = new System.Drawing.Size(95, 25);
            this.tgsModificarQuantidade.TabIndex = 26;
            // 
            // frmNovasTelasConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 353);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.tgsModificarQuantidade);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.tgsNovoFluxoFaturamento);
            this.Controls.Add(this.btnGravarConfiguracoes);
            this.Controls.Add(this.labelControl7);
            this.Name = "frmNovasTelasConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuracoes";
            this.Load += new System.EventHandler(this.frmNovasTelasConfig_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tgsNovoFluxoFaturamento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tgsModificarQuantidade.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SimpleButton btnGravarConfiguracoes;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ToggleSwitch tgsNovoFluxoFaturamento;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ToggleSwitch tgsModificarQuantidade;
    }
}