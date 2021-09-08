
namespace BruxoSistema
{
    partial class Faturamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Faturamento));
            this.label1 = new System.Windows.Forms.Label();
            this.btnFaturarVenda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(159, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 21);
            this.label1.TabIndex = 101;
            this.label1.Text = "FORMA DE PAGAMENTO";
            // 
            // btnFaturarVenda
            // 
            this.btnFaturarVenda.Image = ((System.Drawing.Image)(resources.GetObject("btnFaturarVenda.Image")));
            this.btnFaturarVenda.Location = new System.Drawing.Point(163, 293);
            this.btnFaturarVenda.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnFaturarVenda.Name = "btnFaturarVenda";
            this.btnFaturarVenda.Size = new System.Drawing.Size(180, 35);
            this.btnFaturarVenda.TabIndex = 102;
            this.btnFaturarVenda.Text = "Faturar (ENTER)";
            this.btnFaturarVenda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFaturarVenda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFaturarVenda.UseVisualStyleBackColor = true;
            this.btnFaturarVenda.Click += new System.EventHandler(this.btnFaturarVenda_Click);
            // 
            // Faturamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(506, 340);
            this.Controls.Add(this.btnFaturarVenda);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Faturamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Faturamento";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FaturarOuSair_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFaturarVenda;
    }
}