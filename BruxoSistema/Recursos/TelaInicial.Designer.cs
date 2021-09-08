
namespace BruxoSistema
{
    partial class TelaInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaInicial));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnVoltarParaTeleDeLogin = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAbrirTelaPDV = new System.Windows.Forms.ToolStripButton();
            this.btnAbrirTelaFormaPagamento = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnAbrirTelaCadastroProduto = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel4,
            this.btnVoltarParaTeleDeLogin});
            this.statusStrip1.Location = new System.Drawing.Point(0, 627);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1114, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(53, 17);
            this.toolStripStatusLabel1.Text = "Usuario: ";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Margin = new System.Windows.Forms.Padding(-7, 3, 0, 2);
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(12, 17);
            this.toolStripStatusLabel2.Text = "-";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(988, 17);
            this.toolStripStatusLabel4.Spring = true;
            // 
            // btnVoltarParaTeleDeLogin
            // 
            this.btnVoltarParaTeleDeLogin.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltarParaTeleDeLogin.Image")));
            this.btnVoltarParaTeleDeLogin.Name = "btnVoltarParaTeleDeLogin";
            this.btnVoltarParaTeleDeLogin.RightToLeftAutoMirrorImage = true;
            this.btnVoltarParaTeleDeLogin.Size = new System.Drawing.Size(53, 17);
            this.btnVoltarParaTeleDeLogin.Text = "Login";
            this.btnVoltarParaTeleDeLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVoltarParaTeleDeLogin.Click += new System.EventHandler(this.btnVoltarParaTeleDeLogin_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 897F));
            this.tableLayoutPanel1.Controls.Add(this.toolStrip1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.toolStrip2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1114, 76);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAbrirTelaPDV,
            this.btnAbrirTelaFormaPagamento});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStrip1.Location = new System.Drawing.Point(1, 1);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(214, 74);
            this.toolStrip1.TabIndex = 5;
            // 
            // btnAbrirTelaPDV
            // 
            this.btnAbrirTelaPDV.AutoSize = false;
            this.btnAbrirTelaPDV.Image = ((System.Drawing.Image)(resources.GetObject("btnAbrirTelaPDV.Image")));
            this.btnAbrirTelaPDV.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAbrirTelaPDV.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAbrirTelaPDV.Name = "btnAbrirTelaPDV";
            this.btnAbrirTelaPDV.Size = new System.Drawing.Size(100, 70);
            this.btnAbrirTelaPDV.Text = "Venda ENTER";
            this.btnAbrirTelaPDV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAbrirTelaPDV.Click += new System.EventHandler(this.btnAbrirTelaPDV_Click);
            // 
            // btnAbrirTelaFormaPagamento
            // 
            this.btnAbrirTelaFormaPagamento.AutoSize = false;
            this.btnAbrirTelaFormaPagamento.Image = ((System.Drawing.Image)(resources.GetObject("btnAbrirTelaFormaPagamento.Image")));
            this.btnAbrirTelaFormaPagamento.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAbrirTelaFormaPagamento.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAbrirTelaFormaPagamento.Name = "btnAbrirTelaFormaPagamento";
            this.btnAbrirTelaFormaPagamento.Size = new System.Drawing.Size(100, 70);
            this.btnAbrirTelaFormaPagamento.Text = "Pagamentos F1";
            this.btnAbrirTelaFormaPagamento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAbrirTelaFormaPagamento.Click += new System.EventHandler(this.btnAbrirTelaFormaPagamento_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAbrirTelaCadastroProduto});
            this.toolStrip2.Location = new System.Drawing.Point(216, 1);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(897, 74);
            this.toolStrip2.TabIndex = 6;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btnAbrirTelaCadastroProduto
            // 
            this.btnAbrirTelaCadastroProduto.AutoSize = false;
            this.btnAbrirTelaCadastroProduto.Image = ((System.Drawing.Image)(resources.GetObject("btnAbrirTelaCadastroProduto.Image")));
            this.btnAbrirTelaCadastroProduto.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAbrirTelaCadastroProduto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAbrirTelaCadastroProduto.Name = "btnAbrirTelaCadastroProduto";
            this.btnAbrirTelaCadastroProduto.Size = new System.Drawing.Size(100, 70);
            this.btnAbrirTelaCadastroProduto.Text = "Produtos F3";
            this.btnAbrirTelaCadastroProduto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAbrirTelaCadastroProduto.Click += new System.EventHandler(this.btnAbrirTelaCadastroProduto_Click);
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1114, 649);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimizeBox = false;
            this.Name = "TelaInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sige Bruxo";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TelaInicial_KeyDown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAbrirTelaPDV;
        private System.Windows.Forms.ToolStripButton btnAbrirTelaFormaPagamento;
        private System.Windows.Forms.ToolStripStatusLabel btnVoltarParaTeleDeLogin;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnAbrirTelaCadastroProduto;
    }
}