
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
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.cadastros = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem2 = new DevExpress.XtraBars.BarStaticItem();
            this.btnCadastroProdutos = new DevExpress.XtraBars.BarButtonItem();
            this.btnCadastroFormaPagamento = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnVenda = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnConfiguracoes = new DevExpress.XtraBars.BarButtonItem();
            this.txtUsuario = new DevExpress.XtraBars.BarStaticItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            resources.ApplyResources(this.ribbon, "ribbon");
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.ExpandCollapseItem.ImageOptions.ImageIndex = ((int)(resources.GetObject("ribbon.ExpandCollapseItem.ImageOptions.ImageIndex")));
            this.ribbon.ExpandCollapseItem.ImageOptions.LargeImageIndex = ((int)(resources.GetObject("ribbon.ExpandCollapseItem.ImageOptions.LargeImageIndex")));
            this.ribbon.ExpandCollapseItem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ribbon.ExpandCollapseItem.ImageOptions.SvgImage")));
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.barStaticItem1,
            this.barStaticItem2,
            this.btnCadastroProdutos,
            this.btnCadastroFormaPagamento,
            this.btnVenda,
            this.btnConfiguracoes,
            this.txtUsuario});
            this.ribbon.MaxItemId = 8;
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
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.cadastros});
            this.ribbonPage1.ImageOptions.ImageIndex = ((int)(resources.GetObject("ribbonPage1.ImageOptions.ImageIndex")));
            this.ribbonPage1.Name = "ribbonPage1";
            resources.ApplyResources(this.ribbonPage1, "ribbonPage1");
            // 
            // cadastros
            // 
            this.cadastros.ImageOptions.ImageIndex = ((int)(resources.GetObject("ribbonPageGroup1.ImageOptions.ImageIndex")));
            this.cadastros.ItemLinks.Add(this.btnCadastroProdutos);
            this.cadastros.ItemLinks.Add(this.btnCadastroFormaPagamento);
            this.cadastros.Name = "cadastros";
            this.cadastros.ShowCaptionButton = false;
            resources.ApplyResources(this.cadastros, "cadastros");
            // 
            // ribbonStatusBar
            // 
            resources.ApplyResources(this.ribbonStatusBar, "ribbonStatusBar");
            this.ribbonStatusBar.ItemLinks.Add(this.barStaticItem1);
            this.ribbonStatusBar.ItemLinks.Add(this.barStaticItem2);
            this.ribbonStatusBar.ItemLinks.Add(this.txtUsuario);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            // 
            // barStaticItem1
            // 
            resources.ApplyResources(this.barStaticItem1, "barStaticItem1");
            this.barStaticItem1.Id = 1;
            this.barStaticItem1.ImageOptions.ImageIndex = ((int)(resources.GetObject("barStaticItem1.ImageOptions.ImageIndex")));
            this.barStaticItem1.ImageOptions.LargeImageIndex = ((int)(resources.GetObject("barStaticItem1.ImageOptions.LargeImageIndex")));
            this.barStaticItem1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barStaticItem1.ImageOptions.SvgImage")));
            this.barStaticItem1.Name = "barStaticItem1";
            // 
            // barStaticItem2
            // 
            resources.ApplyResources(this.barStaticItem2, "barStaticItem2");
            this.barStaticItem2.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barStaticItem2.Id = 2;
            this.barStaticItem2.ImageOptions.ImageIndex = ((int)(resources.GetObject("barStaticItem2.ImageOptions.ImageIndex")));
            this.barStaticItem2.ImageOptions.LargeImageIndex = ((int)(resources.GetObject("barStaticItem2.ImageOptions.LargeImageIndex")));
            this.barStaticItem2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barStaticItem2.ImageOptions.SvgImage")));
            this.barStaticItem2.Name = "barStaticItem2";
            // 
            // btnCadastroProdutos
            // 
            resources.ApplyResources(this.btnCadastroProdutos, "btnCadastroProdutos");
            this.btnCadastroProdutos.Id = 3;
            this.btnCadastroProdutos.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.btnCadastroProdutos.ImageOptions.ImageIndex = ((int)(resources.GetObject("barButtonItem1.ImageOptions.ImageIndex")));
            this.btnCadastroProdutos.ImageOptions.LargeImageIndex = ((int)(resources.GetObject("barButtonItem1.ImageOptions.LargeImageIndex")));
            this.btnCadastroProdutos.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage")));
            this.btnCadastroProdutos.Name = "btnCadastroProdutos";
            this.btnCadastroProdutos.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnCadastroFormaPagamento
            // 
            resources.ApplyResources(this.btnCadastroFormaPagamento, "btnCadastroFormaPagamento");
            this.btnCadastroFormaPagamento.Id = 4;
            this.btnCadastroFormaPagamento.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image1")));
            this.btnCadastroFormaPagamento.ImageOptions.ImageIndex = ((int)(resources.GetObject("barButtonItem1.ImageOptions.ImageIndex1")));
            this.btnCadastroFormaPagamento.ImageOptions.LargeImageIndex = ((int)(resources.GetObject("barButtonItem1.ImageOptions.LargeImageIndex1")));
            this.btnCadastroFormaPagamento.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage1")));
            this.btnCadastroFormaPagamento.Name = "btnCadastroFormaPagamento";
            this.btnCadastroFormaPagamento.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage2.ImageOptions.ImageIndex = ((int)(resources.GetObject("ribbonPage2.ImageOptions.ImageIndex")));
            this.ribbonPage2.Name = "ribbonPage2";
            resources.ApplyResources(this.ribbonPage2, "ribbonPage2");
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ImageOptions.ImageIndex = ((int)(resources.GetObject("ribbonPageGroup1.ImageOptions.ImageIndex1")));
            this.ribbonPageGroup1.ItemLinks.Add(this.btnVenda);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            resources.ApplyResources(this.ribbonPageGroup1, "ribbonPageGroup1");
            // 
            // btnVenda
            // 
            resources.ApplyResources(this.btnVenda, "btnVenda");
            this.btnVenda.Id = 5;
            this.btnVenda.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image2")));
            this.btnVenda.ImageOptions.ImageIndex = ((int)(resources.GetObject("barButtonItem1.ImageOptions.ImageIndex2")));
            this.btnVenda.ImageOptions.LargeImageIndex = ((int)(resources.GetObject("barButtonItem1.ImageOptions.LargeImageIndex2")));
            this.btnVenda.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage2")));
            this.btnVenda.Name = "btnVenda";
            this.btnVenda.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage3.ImageOptions.ImageIndex = ((int)(resources.GetObject("ribbonPage3.ImageOptions.ImageIndex")));
            this.ribbonPage3.Name = "ribbonPage3";
            resources.ApplyResources(this.ribbonPage3, "ribbonPage3");
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ImageOptions.ImageIndex = ((int)(resources.GetObject("ribbonPageGroup2.ImageOptions.ImageIndex")));
            this.ribbonPageGroup2.ItemLinks.Add(this.btnConfiguracoes);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            resources.ApplyResources(this.ribbonPageGroup2, "ribbonPageGroup2");
            // 
            // btnConfiguracoes
            // 
            resources.ApplyResources(this.btnConfiguracoes, "btnConfiguracoes");
            this.btnConfiguracoes.Id = 6;
            this.btnConfiguracoes.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.btnConfiguracoes.ImageOptions.ImageIndex = ((int)(resources.GetObject("barButtonItem2.ImageOptions.ImageIndex")));
            this.btnConfiguracoes.ImageOptions.LargeImageIndex = ((int)(resources.GetObject("barButtonItem2.ImageOptions.LargeImageIndex")));
            this.btnConfiguracoes.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem2.ImageOptions.SvgImage")));
            this.btnConfiguracoes.Name = "btnConfiguracoes";
            this.btnConfiguracoes.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // txtUsuario
            // 
            resources.ApplyResources(this.txtUsuario, "txtUsuario");
            this.txtUsuario.Id = 7;
            this.txtUsuario.ImageOptions.ImageIndex = ((int)(resources.GetObject("barStaticItem3.ImageOptions.ImageIndex")));
            this.txtUsuario.ImageOptions.LargeImageIndex = ((int)(resources.GetObject("barStaticItem3.ImageOptions.LargeImageIndex")));
            this.txtUsuario.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barStaticItem3.ImageOptions.SvgImage")));
            this.txtUsuario.Name = "txtUsuario";
            // 
            // frmTelaInicialRibbon
            // 
            resources.ApplyResources(this, "$this");
            this.Appearance.BackColor = ((System.Drawing.Color)(resources.GetObject("frmTelaInicialRibbon.Appearance.BackColor")));
            this.Appearance.FontSizeDelta = ((int)(resources.GetObject("frmTelaInicialRibbon.Appearance.FontSizeDelta")));
            this.Appearance.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("frmTelaInicialRibbon.Appearance.FontStyleDelta")));
            this.Appearance.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("frmTelaInicialRibbon.Appearance.GradientMode")));
            this.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("frmTelaInicialRibbon.Appearance.Image")));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.KeyPreview = true;
            this.Name = "frmTelaInicialRibbon";
            this.Ribbon = this.ribbon;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StatusBar = this.ribbonStatusBar;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup cadastros;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem2;
        private DevExpress.XtraBars.BarButtonItem btnCadastroProdutos;
        private DevExpress.XtraBars.BarButtonItem btnCadastroFormaPagamento;
        private DevExpress.XtraBars.BarButtonItem btnVenda;
        private DevExpress.XtraBars.BarButtonItem btnConfiguracoes;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarStaticItem txtUsuario;
    }
}