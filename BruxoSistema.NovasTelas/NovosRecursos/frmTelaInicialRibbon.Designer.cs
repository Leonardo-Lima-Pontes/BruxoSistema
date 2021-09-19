
namespace BruxoSistema.NovasTelas.NovosRecursos
{
    partial class frmTelaInicialRibbon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTelaInicialRibbon));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.lblSairLogin = new DevExpress.XtraBars.BarStaticItem();
            this.btnCadastroProdutos = new DevExpress.XtraBars.BarButtonItem();
            this.btnCadastroFormaPagamento = new DevExpress.XtraBars.BarButtonItem();
            this.btnVenda = new DevExpress.XtraBars.BarButtonItem();
            this.btnConfiguracoes = new DevExpress.XtraBars.BarButtonItem();
            this.txtUsuario = new DevExpress.XtraBars.BarStaticItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.cadastros = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.lblUsuario = new DevExpress.XtraBars.BarStaticItem();
            this.lblUsuarioLogado = new DevExpress.XtraBars.BarStaticItem();
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager();
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView();
            this.adornerUIManager1 = new DevExpress.Utils.VisualEffects.AdornerUIManager();
            this.badge1 = new DevExpress.Utils.VisualEffects.Badge();
            this.badge2 = new DevExpress.Utils.VisualEffects.Badge();
            this.badge3 = new DevExpress.Utils.VisualEffects.Badge();
            this.badge4 = new DevExpress.Utils.VisualEffects.Badge();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adornerUIManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.lblSairLogin,
            this.btnCadastroProdutos,
            this.btnCadastroFormaPagamento,
            this.btnVenda,
            this.btnConfiguracoes,
            this.txtUsuario,
            this.lblUsuario,
            this.lblUsuarioLogado});
            resources.ApplyResources(this.ribbon, "ribbon");
            this.ribbon.MaxItemId = 11;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3});
            this.ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowToolbarCustomizeItem = false;
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            // 
            // lblSairLogin
            // 
            this.lblSairLogin.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            resources.ApplyResources(this.lblSairLogin, "lblSairLogin");
            this.lblSairLogin.Id = 2;
            this.lblSairLogin.Name = "lblSairLogin";
            // 
            // btnCadastroProdutos
            // 
            resources.ApplyResources(this.btnCadastroProdutos, "btnCadastroProdutos");
            this.btnCadastroProdutos.Id = 3;
            this.btnCadastroProdutos.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastroProdutos.ImageOptions.Image")));
            this.btnCadastroProdutos.Name = "btnCadastroProdutos";
            this.btnCadastroProdutos.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnCadastroProdutos.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCadastroProdutos_ItemClick);
            // 
            // btnCadastroFormaPagamento
            // 
            resources.ApplyResources(this.btnCadastroFormaPagamento, "btnCadastroFormaPagamento");
            this.btnCadastroFormaPagamento.Id = 4;
            this.btnCadastroFormaPagamento.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastroFormaPagamento.ImageOptions.Image")));
            this.btnCadastroFormaPagamento.Name = "btnCadastroFormaPagamento";
            this.btnCadastroFormaPagamento.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnCadastroFormaPagamento.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCadastroFormaPagamento_ItemClick);
            // 
            // btnVenda
            // 
            resources.ApplyResources(this.btnVenda, "btnVenda");
            this.btnVenda.Id = 5;
            this.btnVenda.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnVenda.ImageOptions.Image")));
            this.btnVenda.Name = "btnVenda";
            this.btnVenda.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnVenda.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnVenda_ItemClick);
            // 
            // btnConfiguracoes
            // 
            resources.ApplyResources(this.btnConfiguracoes, "btnConfiguracoes");
            this.btnConfiguracoes.Id = 6;
            this.btnConfiguracoes.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnConfiguracoes.ImageOptions.Image")));
            this.btnConfiguracoes.Name = "btnConfiguracoes";
            this.btnConfiguracoes.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnConfiguracoes.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnConfiguracoes_ItemClick);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Id = 7;
            this.txtUsuario.Name = "txtUsuario";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.cadastros});
            this.ribbonPage1.Name = "ribbonPage1";
            resources.ApplyResources(this.ribbonPage1, "ribbonPage1");
            // 
            // cadastros
            // 
            this.cadastros.ItemLinks.Add(this.btnCadastroProdutos);
            this.cadastros.ItemLinks.Add(this.btnCadastroFormaPagamento);
            this.cadastros.Name = "cadastros";
            this.cadastros.ShowCaptionButton = false;
            resources.ApplyResources(this.cadastros, "cadastros");
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage2.Name = "ribbonPage2";
            resources.ApplyResources(this.ribbonPage2, "ribbonPage2");
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnVenda);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            resources.ApplyResources(this.ribbonPageGroup1, "ribbonPageGroup1");
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage3.Name = "ribbonPage3";
            resources.ApplyResources(this.ribbonPage3, "ribbonPage3");
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnConfiguracoes);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            resources.ApplyResources(this.ribbonPageGroup2, "ribbonPageGroup2");
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.lblSairLogin);
            this.ribbonStatusBar.ItemLinks.Add(this.lblUsuario);
            this.ribbonStatusBar.ItemLinks.Add(this.lblUsuarioLogado);
            resources.ApplyResources(this.ribbonStatusBar, "ribbonStatusBar");
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            // 
            // lblUsuario
            // 
            resources.ApplyResources(this.lblUsuario, "lblUsuario");
            this.lblUsuario.Id = 9;
            this.lblUsuario.Name = "lblUsuario";
            // 
            // lblUsuarioLogado
            // 
            this.lblUsuarioLogado.Id = 10;
            this.lblUsuarioLogado.Name = "lblUsuarioLogado";
            // 
            // documentManager1
            // 
            this.documentManager1.MdiParent = this;
            this.documentManager1.MenuManager = this.ribbon;
            this.documentManager1.View = this.tabbedView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
            // 
            // adornerUIManager1
            // 
            this.adornerUIManager1.Elements.Add(this.badge1);
            this.adornerUIManager1.Elements.Add(this.badge2);
            this.adornerUIManager1.Elements.Add(this.badge3);
            this.adornerUIManager1.Elements.Add(this.badge4);
            this.adornerUIManager1.Owner = this;
            // 
            // badge1
            // 
            this.badge1.Properties.Location = System.Drawing.ContentAlignment.TopLeft;
            this.badge1.TargetElement = this.btnCadastroProdutos;
            // 
            // badge2
            // 
            this.badge2.Properties.Location = System.Drawing.ContentAlignment.TopLeft;
            this.badge2.TargetElement = this.btnCadastroFormaPagamento;
            // 
            // badge3
            // 
            this.badge3.Properties.Location = System.Drawing.ContentAlignment.TopLeft;
            this.badge3.TargetElement = this.btnVenda;
            // 
            // badge4
            // 
            this.badge4.Properties.Location = System.Drawing.ContentAlignment.TopLeft;
            this.badge4.TargetElement = this.btnConfiguracoes;
            // 
            // frmTelaInicialRibbon
            // 
            this.Appearance.BackColor = ((System.Drawing.Color)(resources.GetObject("frmTelaInicialRibbon.Appearance.BackColor")));
            this.Appearance.Options.UseBackColor = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Name = "frmTelaInicialRibbon";
            this.Ribbon = this.ribbon;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StatusBar = this.ribbonStatusBar;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adornerUIManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup cadastros;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarStaticItem lblSairLogin;
        private DevExpress.XtraBars.BarButtonItem btnCadastroProdutos;
        private DevExpress.XtraBars.BarButtonItem btnCadastroFormaPagamento;
        private DevExpress.XtraBars.BarButtonItem btnVenda;
        private DevExpress.XtraBars.BarButtonItem btnConfiguracoes;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarStaticItem txtUsuario;
        private DevExpress.XtraBars.BarStaticItem lblUsuario;
        private DevExpress.XtraBars.BarStaticItem lblUsuarioLogado;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private DevExpress.Utils.VisualEffects.AdornerUIManager adornerUIManager1;
        private DevExpress.Utils.VisualEffects.Badge badge1;
        private DevExpress.Utils.VisualEffects.Badge badge2;
        private DevExpress.Utils.VisualEffects.Badge badge3;
        private DevExpress.Utils.VisualEffects.Badge badge4;
    }
}