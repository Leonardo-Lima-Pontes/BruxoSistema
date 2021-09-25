
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPdv));
            this.panel = new DevExpress.XtraEditors.PanelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtBuscaProdutos = new DevExpress.XtraEditors.SearchControl();
            this.btnAvançar = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.dgvProdutos = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clnCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clnDescricao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clnValorUnitario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clnQuantidade = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clnValorTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clnId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnlInformacoes = new DevExpress.XtraEditors.PanelControl();
            this.lblValorTotal = new DevExpress.XtraEditors.LabelControl();
            this.label1 = new DevExpress.XtraEditors.LabelControl();
            this.lblTotalItens = new DevExpress.XtraEditors.LabelControl();
            this.label2 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnReiniciar = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBuscaProdutos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlInformacoes)).BeginInit();
            this.pnlInformacoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.panel.Controls.Add(this.pictureEdit1);
            this.panel.Controls.Add(this.labelControl1);
            this.panel.Location = new System.Drawing.Point(910, 38);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(255, 656);
            this.panel.TabIndex = 1;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = global::BruxoSistema.NovasTelas.Properties.Resources.Logo_SistemasBr_Solid_hor;
            this.pictureEdit1.Location = new System.Drawing.Point(42, 310);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEdit1.Size = new System.Drawing.Size(184, 102);
            this.pictureEdit1.TabIndex = 18;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(128)))), ((int)(((byte)(162)))));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(37, 621);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(177, 30);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "www.Bruxaria.net";
            // 
            // txtBuscaProdutos
            // 
            this.txtBuscaProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscaProdutos.EditValue = "";
            this.txtBuscaProdutos.Location = new System.Drawing.Point(-1, 52);
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
            this.txtBuscaProdutos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtBuscaProdutos_KeyDown);
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
            this.btnAvançar.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(120)))));
            this.btnAvançar.AppearanceHovered.Options.UseBackColor = true;
            this.btnAvançar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnAvançar.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.btnAvançar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAvançar.Location = new System.Drawing.Point(1039, 702);
            this.btnAvançar.Name = "btnAvançar";
            this.btnAvançar.Size = new System.Drawing.Size(97, 35);
            this.btnAvançar.TabIndex = 7;
            this.btnAvançar.Text = "Avançar";
            this.btnAvançar.Click += new System.EventHandler(this.BtnAvançar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(139)))), ((int)(((byte)(148)))));
            this.btnCancelar.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(201)))));
            this.btnCancelar.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Appearance.Options.UseBackColor = true;
            this.btnCancelar.Appearance.Options.UseBorderColor = true;
            this.btnCancelar.Appearance.Options.UseFont = true;
            this.btnCancelar.Appearance.Options.UseForeColor = true;
            this.btnCancelar.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(120)))), ((int)(((byte)(130)))));
            this.btnCancelar.AppearanceHovered.Options.UseBackColor = true;
            this.btnCancelar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnCancelar.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.btnCancelar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnCancelar.Location = new System.Drawing.Point(936, 702);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(97, 35);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProdutos.Location = new System.Drawing.Point(-1, 111);
            this.dgvProdutos.MainView = this.gridView1;
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.Size = new System.Drawing.Size(912, 583);
            this.dgvProdutos.TabIndex = 8;
            this.dgvProdutos.TabStop = false;
            this.dgvProdutos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.clnCodigo,
            this.clnDescricao,
            this.clnValorUnitario,
            this.clnQuantidade,
            this.clnValorTotal,
            this.clnId});
            this.gridView1.GridControl = this.dgvProdutos;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanged);
            // 
            // clnCodigo
            // 
            this.clnCodigo.Caption = "Código";
            this.clnCodigo.CustomizationCaption = "Código";
            this.clnCodigo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.clnCodigo.FieldName = "CODIGO";
            this.clnCodigo.Name = "clnCodigo";
            this.clnCodigo.Visible = true;
            this.clnCodigo.VisibleIndex = 0;
            this.clnCodigo.Width = 50;
            // 
            // clnDescricao
            // 
            this.clnDescricao.Caption = "Descrição";
            this.clnDescricao.FieldName = "NOME";
            this.clnDescricao.Name = "clnDescricao";
            this.clnDescricao.Visible = true;
            this.clnDescricao.VisibleIndex = 1;
            this.clnDescricao.Width = 405;
            // 
            // clnValorUnitario
            // 
            this.clnValorUnitario.Caption = "Valor Unitário";
            this.clnValorUnitario.FieldName = "PRECOVENDA";
            this.clnValorUnitario.Name = "clnValorUnitario";
            this.clnValorUnitario.Visible = true;
            this.clnValorUnitario.VisibleIndex = 2;
            this.clnValorUnitario.Width = 133;
            // 
            // clnQuantidade
            // 
            this.clnQuantidade.Caption = "Quantidade";
            this.clnQuantidade.FieldName = "QUANTIDADE";
            this.clnQuantidade.Name = "clnQuantidade";
            this.clnQuantidade.Visible = true;
            this.clnQuantidade.VisibleIndex = 3;
            // 
            // clnValorTotal
            // 
            this.clnValorTotal.Caption = "Valor Total";
            this.clnValorTotal.FieldName = "VALORTOTAL";
            this.clnValorTotal.Name = "clnValorTotal";
            this.clnValorTotal.Visible = true;
            this.clnValorTotal.VisibleIndex = 4;
            this.clnValorTotal.Width = 170;
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
            this.pnlInformacoes.Controls.Add(this.lblValorTotal);
            this.pnlInformacoes.Controls.Add(this.label1);
            this.pnlInformacoes.Controls.Add(this.lblTotalItens);
            this.pnlInformacoes.Controls.Add(this.label2);
            this.pnlInformacoes.Location = new System.Drawing.Point(-1, 694);
            this.pnlInformacoes.Name = "pnlInformacoes";
            this.pnlInformacoes.Size = new System.Drawing.Size(912, 56);
            this.pnlInformacoes.TabIndex = 0;
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblValorTotal.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotal.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblValorTotal.Appearance.Options.UseFont = true;
            this.lblValorTotal.Appearance.Options.UseForeColor = true;
            this.lblValorTotal.Location = new System.Drawing.Point(826, 13);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(42, 30);
            this.lblValorTotal.TabIndex = 12;
            this.lblValorTotal.Text = "0,00";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Appearance.ForeColor = System.Drawing.Color.White;
            this.label1.Appearance.Options.UseFont = true;
            this.label1.Appearance.Options.UseForeColor = true;
            this.label1.Location = new System.Drawing.Point(799, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 30);
            this.label1.TabIndex = 13;
            this.label1.Text = "R$";
            // 
            // lblTotalItens
            // 
            this.lblTotalItens.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalItens.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblTotalItens.Appearance.Options.UseFont = true;
            this.lblTotalItens.Appearance.Options.UseForeColor = true;
            this.lblTotalItens.Location = new System.Drawing.Point(40, 20);
            this.lblTotalItens.Name = "lblTotalItens";
            this.lblTotalItens.Size = new System.Drawing.Size(7, 17);
            this.lblTotalItens.TabIndex = 11;
            this.lblTotalItens.Text = "0";
            // 
            // label2
            // 
            this.label2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Appearance.ForeColor = System.Drawing.Color.White;
            this.label2.Appearance.Options.UseFont = true;
            this.label2.Appearance.Options.UseForeColor = true;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Itens";
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(119)))), ((int)(((byte)(203)))));
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.btnReiniciar);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1165, 38);
            this.panelControl1.TabIndex = 17;
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReiniciar.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReiniciar.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnReiniciar.Appearance.Options.UseFont = true;
            this.btnReiniciar.Appearance.Options.UseForeColor = true;
            this.btnReiniciar.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(157)))), ((int)(((byte)(217)))));
            this.btnReiniciar.AppearanceHovered.Options.UseBackColor = true;
            this.btnReiniciar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnReiniciar.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.btnReiniciar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReiniciar.ImageOptions.Image")));
            this.btnReiniciar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnReiniciar.Location = new System.Drawing.Point(1056, 5);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(97, 29);
            this.btnReiniciar.TabIndex = 18;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(39, 15);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(70, 21);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Leonardo";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(39, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(57, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "VENDEDOR";
            // 
            // frmPdv
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 749);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.pnlInformacoes);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.btnAvançar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtBuscaProdutos);
            this.KeyPreview = true;
            this.Name = "frmPdv";
            this.Text = "Venda";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPdv_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBuscaProdutos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlInformacoes)).EndInit();
            this.pnlInformacoes.ResumeLayout(false);
            this.pnlInformacoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl panel;
        private DevExpress.XtraEditors.SearchControl txtBuscaProdutos;
        private DevExpress.XtraEditors.SimpleButton btnAvançar;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraGrid.GridControl dgvProdutos;
        private DevExpress.XtraEditors.PanelControl pnlInformacoes;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lblValorTotal;
        private DevExpress.XtraEditors.LabelControl label1;
        private DevExpress.XtraEditors.LabelControl lblTotalItens;
        private DevExpress.XtraEditors.LabelControl label2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnReiniciar;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.Columns.GridColumn clnCodigo;
        private DevExpress.XtraGrid.Columns.GridColumn clnDescricao;
        private DevExpress.XtraGrid.Columns.GridColumn clnValorUnitario;
        private DevExpress.XtraGrid.Columns.GridColumn clnValorTotal;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn clnQuantidade;
        private DevExpress.XtraGrid.Columns.GridColumn clnId;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
    }
}