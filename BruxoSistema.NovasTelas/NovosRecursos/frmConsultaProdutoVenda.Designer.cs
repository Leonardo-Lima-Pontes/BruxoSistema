
namespace BruxoSistema.NovasTelas.NovosRecursos
{
    partial class FrmConsultaProdutoVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaProdutoVenda));
            this.dgvProdutos = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clnCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clnDescricao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clnValorUnitario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clnEstoque = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clnId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnReiniciar = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProdutos.Location = new System.Drawing.Point(12, 90);
            this.dgvProdutos.MainView = this.gridView1;
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.Size = new System.Drawing.Size(649, 476);
            this.dgvProdutos.TabIndex = 1;
            this.dgvProdutos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.clnCodigo,
            this.clnDescricao,
            this.clnValorUnitario,
            this.clnEstoque,
            this.clnId});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridView1.GridControl = this.dgvProdutos;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // clnCodigo
            // 
            this.clnCodigo.Caption = "Código";
            this.clnCodigo.CustomizationCaption = "Código";
            this.clnCodigo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.clnCodigo.FieldName = "CODIGO";
            this.clnCodigo.Name = "clnCodigo";
            this.clnCodigo.OptionsColumn.AllowEdit = false;
            this.clnCodigo.Visible = true;
            this.clnCodigo.VisibleIndex = 0;
            this.clnCodigo.Width = 67;
            // 
            // clnDescricao
            // 
            this.clnDescricao.Caption = "Descrição";
            this.clnDescricao.FieldName = "NOME";
            this.clnDescricao.Name = "clnDescricao";
            this.clnDescricao.OptionsColumn.AllowEdit = false;
            this.clnDescricao.Visible = true;
            this.clnDescricao.VisibleIndex = 1;
            this.clnDescricao.Width = 322;
            // 
            // clnValorUnitario
            // 
            this.clnValorUnitario.Caption = "Valor Unitário";
            this.clnValorUnitario.FieldName = "PRECOVENDA";
            this.clnValorUnitario.Name = "clnValorUnitario";
            this.clnValorUnitario.OptionsColumn.AllowEdit = false;
            this.clnValorUnitario.Visible = true;
            this.clnValorUnitario.VisibleIndex = 2;
            this.clnValorUnitario.Width = 105;
            // 
            // clnEstoque
            // 
            this.clnEstoque.Caption = "Estoque";
            this.clnEstoque.FieldName = "ESTOQUE";
            this.clnEstoque.Name = "clnEstoque";
            this.clnEstoque.OptionsColumn.AllowEdit = false;
            this.clnEstoque.Visible = true;
            this.clnEstoque.VisibleIndex = 3;
            this.clnEstoque.Width = 137;
            // 
            // clnId
            // 
            this.clnId.Caption = "Id";
            this.clnId.FieldName = "ID_PRODUTO";
            this.clnId.Name = "clnId";
            this.clnId.OptionsColumn.AllowEdit = false;
            this.clnId.OptionsColumn.AllowFocus = false;
            this.clnId.OptionsColumn.AllowMove = false;
            this.clnId.OptionsColumn.AllowShowHide = false;
            this.clnId.OptionsColumn.AllowSize = false;
            this.clnId.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.clnId.OptionsColumn.ReadOnly = true;
            this.clnId.OptionsColumn.ShowCaption = false;
            this.clnId.OptionsColumn.ShowInCustomizationForm = false;
            this.clnId.OptionsColumn.ShowInExpressionEditor = false;
            this.clnId.OptionsColumn.TabStop = false;
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(119)))), ((int)(((byte)(203)))));
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.btnReiniciar);
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(673, 84);
            this.panelControl1.TabIndex = 18;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(213, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(247, 32);
            this.labelControl1.TabIndex = 19;
            this.labelControl1.Text = "Pesquisa de Produtos";
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReiniciar.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReiniciar.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnReiniciar.Appearance.Options.UseFont = true;
            this.btnReiniciar.Appearance.Options.UseForeColor = true;
            this.btnReiniciar.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(157)))), ((int)(((byte)(217)))));
            this.btnReiniciar.AppearanceHovered.Options.UseBackColor = true;
            this.btnReiniciar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnReiniciar.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.btnReiniciar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReiniciar.ImageOptions.Image")));
            this.btnReiniciar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnReiniciar.Location = new System.Drawing.Point(236, 52);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(200, 29);
            this.btnReiniciar.TabIndex = 2;
            this.btnReiniciar.TabStop = false;
            this.btnReiniciar.Text = "[ENTER] - Confirmar";
            this.btnReiniciar.Click += new System.EventHandler(this.BtnReiniciar_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(673, 578);
            this.panel1.TabIndex = 19;
            // 
            // frmConsultaProdutoVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 578);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FrmConsultaProdutoVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConsultaProdutoVenda";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmConsultaProdutoVenda_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgvProdutos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn clnCodigo;
        private DevExpress.XtraGrid.Columns.GridColumn clnDescricao;
        private DevExpress.XtraGrid.Columns.GridColumn clnValorUnitario;
        private DevExpress.XtraGrid.Columns.GridColumn clnEstoque;
        private DevExpress.XtraGrid.Columns.GridColumn clnId;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnReiniciar;
        private System.Windows.Forms.Panel panel1;
    }
}