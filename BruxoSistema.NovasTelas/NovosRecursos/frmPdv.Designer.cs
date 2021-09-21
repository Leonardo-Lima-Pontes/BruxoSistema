
namespace BruxoSistema.NovasTelas.NovosRecursos
{
    partial class frmPdv
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
            this.lblItensTotalizador = new DevExpress.XtraEditors.PanelControl();
            this.txtBuscaProdutos = new DevExpress.XtraEditors.SearchControl();
            this.btnAvançar = new DevExpress.XtraEditors.SimpleButton();
            this.btnCadastrar = new DevExpress.XtraEditors.SimpleButton();
            this.dgvProdutos = new DevExpress.XtraGrid.GridControl();
            this.pnlInformacoes = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lblItens = new DevExpress.XtraEditors.LabelControl();
            this.lblTotalTotalizador = new DevExpress.XtraEditors.LabelControl();
            this.lblValorTotalizador = new DevExpress.XtraEditors.LabelControl();
            this.lblTotalVenda = new DevExpress.XtraEditors.LabelControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label = new DevExpress.XtraEditors.LabelControl();
            this.lblVendedor = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.lblItensTotalizador)).BeginInit();
            this.lblItensTotalizador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBuscaProdutos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlInformacoes)).BeginInit();
            this.pnlInformacoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblItensTotalizador
            // 
            this.lblItensTotalizador.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblItensTotalizador.Controls.Add(this.lblVendedor);
            this.lblItensTotalizador.Controls.Add(this.label);
            this.lblItensTotalizador.Controls.Add(this.labelControl1);
            this.lblItensTotalizador.Location = new System.Drawing.Point(910, 0);
            this.lblItensTotalizador.Name = "lblItensTotalizador";
            this.lblItensTotalizador.Size = new System.Drawing.Size(255, 761);
            this.lblItensTotalizador.TabIndex = 1;
            // 
            // txtBuscaProdutos
            // 
            this.txtBuscaProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscaProdutos.EditValue = "";
            this.txtBuscaProdutos.Location = new System.Drawing.Point(-1, 5);
            this.txtBuscaProdutos.Name = "txtBuscaProdutos";
            this.txtBuscaProdutos.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscaProdutos.Properties.Appearance.Options.UseFont = true;
            this.txtBuscaProdutos.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtBuscaProdutos.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.txtBuscaProdutos.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtBuscaProdutos.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtBuscaProdutos.Size = new System.Drawing.Size(912, 40);
            this.txtBuscaProdutos.TabIndex = 1;
            // 
            // btnAvançar
            // 
            this.btnAvançar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAvançar.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(145)))));
            this.btnAvançar.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(145)))));
            this.btnAvançar.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvançar.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnAvançar.Appearance.Options.UseBackColor = true;
            this.btnAvançar.Appearance.Options.UseBorderColor = true;
            this.btnAvançar.Appearance.Options.UseFont = true;
            this.btnAvançar.Appearance.Options.UseForeColor = true;
            this.btnAvançar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnAvançar.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.btnAvançar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAvançar.Location = new System.Drawing.Point(1039, 769);
            this.btnAvançar.Name = "btnAvançar";
            this.btnAvançar.Size = new System.Drawing.Size(97, 35);
            this.btnAvançar.TabIndex = 7;
            this.btnAvançar.Text = "Avançar";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCadastrar.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(139)))), ((int)(((byte)(148)))));
            this.btnCadastrar.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(201)))));
            this.btnCadastrar.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Appearance.Options.UseBackColor = true;
            this.btnCadastrar.Appearance.Options.UseBorderColor = true;
            this.btnCadastrar.Appearance.Options.UseFont = true;
            this.btnCadastrar.Appearance.Options.UseForeColor = true;
            this.btnCadastrar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnCadastrar.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.btnCadastrar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnCadastrar.Location = new System.Drawing.Point(936, 769);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(97, 35);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "Cancelar";
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProdutos.Location = new System.Drawing.Point(-1, 49);
            this.dgvProdutos.MainView = this.gridView1;
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.Size = new System.Drawing.Size(912, 712);
            this.dgvProdutos.TabIndex = 8;
            this.dgvProdutos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // pnlInformacoes
            // 
            this.pnlInformacoes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlInformacoes.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(128)))), ((int)(((byte)(145)))));
            this.pnlInformacoes.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(128)))), ((int)(((byte)(145)))));
            this.pnlInformacoes.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(128)))), ((int)(((byte)(145)))));
            this.pnlInformacoes.Appearance.Options.UseBackColor = true;
            this.pnlInformacoes.Appearance.Options.UseBorderColor = true;
            this.pnlInformacoes.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlInformacoes.Controls.Add(this.lblValorTotalizador);
            this.pnlInformacoes.Controls.Add(this.lblTotalVenda);
            this.pnlInformacoes.Controls.Add(this.lblTotalTotalizador);
            this.pnlInformacoes.Controls.Add(this.lblItens);
            this.pnlInformacoes.Location = new System.Drawing.Point(-1, 761);
            this.pnlInformacoes.Name = "pnlInformacoes";
            this.pnlInformacoes.Size = new System.Drawing.Size(912, 56);
            this.pnlInformacoes.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(128)))), ((int)(((byte)(162)))));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(37, 726);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(177, 30);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "www.Bruxaria.net";
            // 
            // lblItens
            // 
            this.lblItens.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItens.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblItens.Appearance.Options.UseFont = true;
            this.lblItens.Appearance.Options.UseForeColor = true;
            this.lblItens.Location = new System.Drawing.Point(7, 20);
            this.lblItens.Name = "lblItens";
            this.lblItens.Size = new System.Drawing.Size(27, 17);
            this.lblItens.TabIndex = 9;
            this.lblItens.Text = "Itens";
            // 
            // lblTotalTotalizador
            // 
            this.lblTotalTotalizador.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTotalizador.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblTotalTotalizador.Appearance.Options.UseFont = true;
            this.lblTotalTotalizador.Appearance.Options.UseForeColor = true;
            this.lblTotalTotalizador.Location = new System.Drawing.Point(40, 20);
            this.lblTotalTotalizador.Name = "lblTotalTotalizador";
            this.lblTotalTotalizador.Size = new System.Drawing.Size(7, 17);
            this.lblTotalTotalizador.TabIndex = 11;
            this.lblTotalTotalizador.Text = "0";
            // 
            // lblValorTotalizador
            // 
            this.lblValorTotalizador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblValorTotalizador.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotalizador.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblValorTotalizador.Appearance.Options.UseFont = true;
            this.lblValorTotalizador.Appearance.Options.UseForeColor = true;
            this.lblValorTotalizador.Location = new System.Drawing.Point(826, 13);
            this.lblValorTotalizador.Name = "lblValorTotalizador";
            this.lblValorTotalizador.Size = new System.Drawing.Size(42, 30);
            this.lblValorTotalizador.TabIndex = 12;
            this.lblValorTotalizador.Text = "0,00";
            // 
            // lblTotalVenda
            // 
            this.lblTotalVenda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalVenda.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalVenda.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblTotalVenda.Appearance.Options.UseFont = true;
            this.lblTotalVenda.Appearance.Options.UseForeColor = true;
            this.lblTotalVenda.Location = new System.Drawing.Point(799, 13);
            this.lblTotalVenda.Name = "lblTotalVenda";
            this.lblTotalVenda.Size = new System.Drawing.Size(26, 30);
            this.lblTotalVenda.TabIndex = 13;
            this.lblTotalVenda.Text = "R$";
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.dgvProdutos;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // label
            // 
            this.label.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(128)))), ((int)(((byte)(162)))));
            this.label.Appearance.Options.UseFont = true;
            this.label.Appearance.Options.UseForeColor = true;
            this.label.Location = new System.Drawing.Point(74, 5);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(53, 13);
            this.label.TabIndex = 15;
            this.label.Text = "Vendedor:";
            // 
            // lblVendedor
            // 
            this.lblVendedor.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendedor.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(128)))), ((int)(((byte)(162)))));
            this.lblVendedor.Appearance.Options.UseFont = true;
            this.lblVendedor.Appearance.Options.UseForeColor = true;
            this.lblVendedor.Location = new System.Drawing.Point(133, 5);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(48, 13);
            this.lblVendedor.TabIndex = 16;
            this.lblVendedor.Text = "Leonardo";
            // 
            // frmPdv
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 816);
            this.Controls.Add(this.lblItensTotalizador);
            this.Controls.Add(this.pnlInformacoes);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.btnAvançar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtBuscaProdutos);
            this.Name = "frmPdv";
            this.Text = "Venda";
            ((System.ComponentModel.ISupportInitialize)(this.lblItensTotalizador)).EndInit();
            this.lblItensTotalizador.ResumeLayout(false);
            this.lblItensTotalizador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBuscaProdutos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlInformacoes)).EndInit();
            this.pnlInformacoes.ResumeLayout(false);
            this.pnlInformacoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl lblItensTotalizador;
        private DevExpress.XtraEditors.SearchControl txtBuscaProdutos;
        private DevExpress.XtraEditors.SimpleButton btnAvançar;
        private DevExpress.XtraEditors.SimpleButton btnCadastrar;
        private DevExpress.XtraGrid.GridControl dgvProdutos;
        private DevExpress.XtraEditors.PanelControl pnlInformacoes;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lblValorTotalizador;
        private DevExpress.XtraEditors.LabelControl lblTotalVenda;
        private DevExpress.XtraEditors.LabelControl lblTotalTotalizador;
        private DevExpress.XtraEditors.LabelControl lblItens;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl label;
        private DevExpress.XtraEditors.LabelControl lblVendedor;
    }
}