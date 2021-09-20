
namespace BruxoSistema.NovasTelas.NovosRecursos
{
    partial class FrmCadastroProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroProduto));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnHabilitarCampos = new System.Windows.Forms.ToolStripButton();
            this.btnGravar = new System.Windows.Forms.ToolStripButton();
            this.BtnFechar = new System.Windows.Forms.ToolStripButton();
            this.lblEstoque = new DevExpress.XtraEditors.LabelControl();
            this.txtEstoque = new DevExpress.XtraEditors.TextEdit();
            this.lblPreco = new DevExpress.XtraEditors.LabelControl();
            this.txtPreco = new DevExpress.XtraEditors.TextEdit();
            this.lblNome = new DevExpress.XtraEditors.LabelControl();
            this.txtNome = new DevExpress.XtraEditors.TextEdit();
            this.lblCodigo = new DevExpress.XtraEditors.LabelControl();
            this.txtCodigo = new DevExpress.XtraEditors.TextEdit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEstoque.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPreco.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNome.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnHabilitarCampos,
            this.btnGravar,
            this.BtnFechar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1089, 63);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnHabilitarCampos
            // 
            this.btnHabilitarCampos.AutoSize = false;
            this.btnHabilitarCampos.Image = ((System.Drawing.Image)(resources.GetObject("btnHabilitarCampos.Image")));
            this.btnHabilitarCampos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnHabilitarCampos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHabilitarCampos.Name = "btnHabilitarCampos";
            this.btnHabilitarCampos.Size = new System.Drawing.Size(80, 60);
            this.btnHabilitarCampos.Text = "F2 - Novo";
            this.btnHabilitarCampos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHabilitarCampos.Click += new System.EventHandler(this.BtnHabilitarCampos_Click);
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
            this.btnGravar.Click += new System.EventHandler(this.BtnGravar_Click);
            // 
            // BtnFechar
            // 
            this.BtnFechar.AutoSize = false;
            this.BtnFechar.Image = ((System.Drawing.Image)(resources.GetObject("BtnFechar.Image")));
            this.BtnFechar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnFechar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(80, 60);
            this.BtnFechar.Text = "ESC - Fechar";
            this.BtnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnFechar.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // lblEstoque
            // 
            this.lblEstoque.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstoque.Appearance.Options.UseFont = true;
            this.lblEstoque.Location = new System.Drawing.Point(53, 251);
            this.lblEstoque.Name = "lblEstoque";
            this.lblEstoque.Size = new System.Drawing.Size(64, 20);
            this.lblEstoque.TabIndex = 23;
            this.lblEstoque.Text = "Estoque:";
            // 
            // txtEstoque
            // 
            this.txtEstoque.Location = new System.Drawing.Point(123, 248);
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(126)))), ((int)(((byte)(210)))));
            this.txtEstoque.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstoque.Properties.Appearance.Options.UseBorderColor = true;
            this.txtEstoque.Properties.Appearance.Options.UseFont = true;
            this.txtEstoque.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White;
            this.txtEstoque.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtEstoque.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtEstoque.Size = new System.Drawing.Size(199, 26);
            this.txtEstoque.TabIndex = 4;
            // 
            // lblPreco
            // 
            this.lblPreco.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco.Appearance.Options.UseFont = true;
            this.lblPreco.Location = new System.Drawing.Point(72, 165);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(45, 20);
            this.lblPreco.TabIndex = 22;
            this.lblPreco.Text = "Preco:";
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(123, 162);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(126)))), ((int)(((byte)(210)))));
            this.txtPreco.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco.Properties.Appearance.Options.UseBorderColor = true;
            this.txtPreco.Properties.Appearance.Options.UseFont = true;
            this.txtPreco.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White;
            this.txtPreco.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtPreco.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtPreco.Size = new System.Drawing.Size(199, 26);
            this.txtPreco.TabIndex = 2;
            // 
            // lblNome
            // 
            this.lblNome.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Appearance.Options.UseFont = true;
            this.lblNome.Location = new System.Drawing.Point(71, 120);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(46, 20);
            this.lblNome.TabIndex = 21;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(123, 117);
            this.txtNome.Name = "txtNome";
            this.txtNome.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(126)))), ((int)(((byte)(210)))));
            this.txtNome.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Properties.Appearance.Options.UseBorderColor = true;
            this.txtNome.Properties.Appearance.Options.UseFont = true;
            this.txtNome.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White;
            this.txtNome.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtNome.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtNome.Size = new System.Drawing.Size(199, 26);
            this.txtNome.TabIndex = 1;
            this.txtNome.ToolTip = "Leo";
            this.txtNome.ToolTipTitle = "Leozin";
            // 
            // lblCodigo
            // 
            this.lblCodigo.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Appearance.Options.UseFont = true;
            this.lblCodigo.Location = new System.Drawing.Point(63, 209);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(54, 20);
            this.lblCodigo.TabIndex = 25;
            this.lblCodigo.Text = "Código:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(123, 206);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(126)))), ((int)(((byte)(210)))));
            this.txtCodigo.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Properties.Appearance.Options.UseBorderColor = true;
            this.txtCodigo.Properties.Appearance.Options.UseFont = true;
            this.txtCodigo.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White;
            this.txtCodigo.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtCodigo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtCodigo.Size = new System.Drawing.Size(199, 26);
            this.txtCodigo.TabIndex = 3;
            // 
            // FrmCadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 683);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblEstoque);
            this.Controls.Add(this.txtEstoque);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.toolStrip1);
            this.KeyPreview = true;
            this.Name = "FrmCadastroProduto";
            this.Text = "Cadastro de produto";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmCadastrarProduto_KeyDown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEstoque.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPreco.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNome.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnHabilitarCampos;
        private System.Windows.Forms.ToolStripButton btnGravar;
        private System.Windows.Forms.ToolStripButton BtnFechar;
        private DevExpress.XtraEditors.LabelControl lblEstoque;
        private DevExpress.XtraEditors.TextEdit txtEstoque;
        private DevExpress.XtraEditors.LabelControl lblPreco;
        private DevExpress.XtraEditors.TextEdit txtPreco;
        private DevExpress.XtraEditors.LabelControl lblNome;
        private DevExpress.XtraEditors.TextEdit txtNome;
        private DevExpress.XtraEditors.LabelControl lblCodigo;
        private DevExpress.XtraEditors.TextEdit txtCodigo;
    }
}