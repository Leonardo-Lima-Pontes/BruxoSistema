
namespace BruxoSistema
{
    partial class CadastroProduto
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
            this.textBoxCodigoProduto = new System.Windows.Forms.TextBox();
            this.textBoxNomeProduto = new System.Windows.Forms.MaskedTextBox();
            this.textBoxPrecoVendaProduto = new System.Windows.Forms.MaskedTextBox();
            this.textBoxEstoqueProduto = new System.Windows.Forms.MaskedTextBox();
            this.labelNomeProduto = new System.Windows.Forms.Label();
            this.labelCodigoProduto = new System.Windows.Forms.Label();
            this.labelEstoque = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxCodigoProduto
            // 
            this.textBoxCodigoProduto.Location = new System.Drawing.Point(141, 145);
            this.textBoxCodigoProduto.Name = "textBoxCodigoProduto";
            this.textBoxCodigoProduto.Size = new System.Drawing.Size(161, 23);
            this.textBoxCodigoProduto.TabIndex = 3;
            // 
            // textBoxNomeProduto
            // 
            this.textBoxNomeProduto.Location = new System.Drawing.Point(141, 87);
            this.textBoxNomeProduto.Name = "textBoxNomeProduto";
            this.textBoxNomeProduto.Size = new System.Drawing.Size(161, 23);
            this.textBoxNomeProduto.TabIndex = 1;
            // 
            // textBoxPrecoVendaProduto
            // 
            this.textBoxPrecoVendaProduto.Location = new System.Drawing.Point(141, 116);
            this.textBoxPrecoVendaProduto.Name = "textBoxPrecoVendaProduto";
            this.textBoxPrecoVendaProduto.Size = new System.Drawing.Size(161, 23);
            this.textBoxPrecoVendaProduto.TabIndex = 2;
            // 
            // textBoxEstoqueProduto
            // 
            this.textBoxEstoqueProduto.Location = new System.Drawing.Point(141, 174);
            this.textBoxEstoqueProduto.Name = "textBoxEstoqueProduto";
            this.textBoxEstoqueProduto.Size = new System.Drawing.Size(161, 23);
            this.textBoxEstoqueProduto.TabIndex = 4;
            // 
            // labelNomeProduto
            // 
            this.labelNomeProduto.AutoSize = true;
            this.labelNomeProduto.Location = new System.Drawing.Point(92, 90);
            this.labelNomeProduto.Name = "labelNomeProduto";
            this.labelNomeProduto.Size = new System.Drawing.Size(43, 15);
            this.labelNomeProduto.TabIndex = 5;
            this.labelNomeProduto.Text = "Nome:";
            // 
            // labelCodigoProduto
            // 
            this.labelCodigoProduto.AutoSize = true;
            this.labelCodigoProduto.Location = new System.Drawing.Point(86, 148);
            this.labelCodigoProduto.Name = "labelCodigoProduto";
            this.labelCodigoProduto.Size = new System.Drawing.Size(49, 15);
            this.labelCodigoProduto.TabIndex = 6;
            this.labelCodigoProduto.Text = "Codigo:";
            // 
            // labelEstoque
            // 
            this.labelEstoque.AutoSize = true;
            this.labelEstoque.Location = new System.Drawing.Point(83, 177);
            this.labelEstoque.Name = "labelEstoque";
            this.labelEstoque.Size = new System.Drawing.Size(52, 15);
            this.labelEstoque.TabIndex = 7;
            this.labelEstoque.Text = "Estoque:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Preço de Venda:";
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(176, 203);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(100, 23);
            this.buttonSalvar.TabIndex = 5;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(176, 232);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(100, 23);
            this.buttonCancelar.TabIndex = 6;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // CadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 321);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelEstoque);
            this.Controls.Add(this.labelCodigoProduto);
            this.Controls.Add(this.labelNomeProduto);
            this.Controls.Add(this.textBoxEstoqueProduto);
            this.Controls.Add(this.textBoxPrecoVendaProduto);
            this.Controls.Add(this.textBoxNomeProduto);
            this.Controls.Add(this.textBoxCodigoProduto);
            this.Name = "CadastroProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroProduto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCodigoProduto;
        private System.Windows.Forms.MaskedTextBox textBoxNomeProduto;
        private System.Windows.Forms.MaskedTextBox textBoxPrecoVendaProduto;
        private System.Windows.Forms.MaskedTextBox textBoxEstoqueProduto;
        private System.Windows.Forms.Label labelNomeProduto;
        private System.Windows.Forms.Label labelCodigoProduto;
        private System.Windows.Forms.Label labelEstoque;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonCancelar;
    }
}