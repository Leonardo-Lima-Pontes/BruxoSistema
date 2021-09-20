
namespace BruxoSistema.NovasTelas.NovosRecursos
{
    partial class frmCadastroFormaPagamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroFormaPagamento));
            this.lblForma = new DevExpress.XtraEditors.LabelControl();
            this.txtForma = new DevExpress.XtraEditors.TextEdit();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnCadastrar = new System.Windows.Forms.ToolStripButton();
            this.btnGravar = new System.Windows.Forms.ToolStripButton();
            this.btnFechar = new System.Windows.Forms.ToolStripButton();
            this.tgsDesabilitado = new DevExpress.XtraEditors.ToggleSwitch();
            this.lblDesabilitado = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtForma.Properties)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tgsDesabilitado.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblForma
            // 
            this.lblForma.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForma.Appearance.Options.UseFont = true;
            this.lblForma.Location = new System.Drawing.Point(83, 119);
            this.lblForma.Name = "lblForma";
            this.lblForma.Size = new System.Drawing.Size(50, 20);
            this.lblForma.TabIndex = 30;
            this.lblForma.Text = "Forma:";
            // 
            // txtForma
            // 
            this.txtForma.Location = new System.Drawing.Point(139, 116);
            this.txtForma.Name = "txtForma";
            this.txtForma.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(126)))), ((int)(((byte)(210)))));
            this.txtForma.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtForma.Properties.Appearance.Options.UseBorderColor = true;
            this.txtForma.Properties.Appearance.Options.UseFont = true;
            this.txtForma.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White;
            this.txtForma.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtForma.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtForma.Size = new System.Drawing.Size(199, 26);
            this.txtForma.TabIndex = 27;
            this.txtForma.ToolTip = "Leo";
            this.txtForma.ToolTipTitle = "Leozin";
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCadastrar,
            this.btnGravar,
            this.btnFechar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1003, 63);
            this.toolStrip1.TabIndex = 26;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.AutoSize = false;
            this.btnCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrar.Image")));
            this.btnCadastrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCadastrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(80, 60);
            this.btnCadastrar.Text = "F2 - Novo";
            this.btnCadastrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnGravar
            // 
            this.btnGravar.AutoSize = false;
            this.btnGravar.Image = ((System.Drawing.Image)(resources.GetObject("btnGravar.Image")));
            this.btnGravar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnGravar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(80, 60);
            this.btnGravar.Text = "F5 - Gravar";
            this.btnGravar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnFechar
            // 
            this.btnFechar.AutoSize = false;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnFechar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(80, 60);
            this.btnFechar.Text = "ESC - Fechar";
            this.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tgsDesabilitado
            // 
            this.tgsDesabilitado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tgsDesabilitado.Location = new System.Drawing.Point(915, 600);
            this.tgsDesabilitado.Name = "tgsDesabilitado";
            this.tgsDesabilitado.Properties.OffText = "Off";
            this.tgsDesabilitado.Properties.OnText = "On";
            this.tgsDesabilitado.Properties.ShowText = false;
            this.tgsDesabilitado.Size = new System.Drawing.Size(76, 25);
            this.tgsDesabilitado.TabIndex = 31;
            // 
            // lblDesabilitado
            // 
            this.lblDesabilitado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDesabilitado.Location = new System.Drawing.Point(854, 606);
            this.lblDesabilitado.Name = "lblDesabilitado";
            this.lblDesabilitado.Size = new System.Drawing.Size(57, 13);
            this.lblDesabilitado.TabIndex = 32;
            this.lblDesabilitado.Text = "Desativado";
            // 
            // frmCadastroFormaPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 637);
            this.Controls.Add(this.lblDesabilitado);
            this.Controls.Add(this.tgsDesabilitado);
            this.Controls.Add(this.lblForma);
            this.Controls.Add(this.txtForma);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmCadastroFormaPagamento";
            this.Text = "Cadastro de forma de pagamentos";
            ((System.ComponentModel.ISupportInitialize)(this.txtForma.Properties)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tgsDesabilitado.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblForma;
        private DevExpress.XtraEditors.TextEdit txtForma;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnCadastrar;
        private System.Windows.Forms.ToolStripButton btnGravar;
        private System.Windows.Forms.ToolStripButton btnFechar;
        private DevExpress.XtraEditors.ToggleSwitch tgsDesabilitado;
        private DevExpress.XtraEditors.LabelControl lblDesabilitado;
    }
}