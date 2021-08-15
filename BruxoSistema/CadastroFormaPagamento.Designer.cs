
namespace BruxoSistema
{
    partial class CadastroFormaPagamento
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
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.labelNomeProduto = new System.Windows.Forms.Label();
            this.textBoxNomeFormaPagamento = new System.Windows.Forms.MaskedTextBox();
            this.checkBoxDesabilitado = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(139, 224);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(100, 23);
            this.buttonCancelar.TabIndex = 15;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(139, 195);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(100, 23);
            this.buttonSalvar.TabIndex = 13;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // labelNomeProduto
            // 
            this.labelNomeProduto.AutoSize = true;
            this.labelNomeProduto.Location = new System.Drawing.Point(61, 122);
            this.labelNomeProduto.Name = "labelNomeProduto";
            this.labelNomeProduto.Size = new System.Drawing.Size(43, 15);
            this.labelNomeProduto.TabIndex = 14;
            this.labelNomeProduto.Text = "Nome:";
            // 
            // textBoxNomeFormaPagamento
            // 
            this.textBoxNomeFormaPagamento.Location = new System.Drawing.Point(110, 119);
            this.textBoxNomeFormaPagamento.Name = "textBoxNomeFormaPagamento";
            this.textBoxNomeFormaPagamento.Size = new System.Drawing.Size(161, 23);
            this.textBoxNomeFormaPagamento.TabIndex = 9;
            // 
            // checkBoxDesabilitado
            // 
            this.checkBoxDesabilitado.AutoSize = true;
            this.checkBoxDesabilitado.Location = new System.Drawing.Point(110, 148);
            this.checkBoxDesabilitado.Name = "checkBoxDesabilitado";
            this.checkBoxDesabilitado.Size = new System.Drawing.Size(91, 19);
            this.checkBoxDesabilitado.TabIndex = 16;
            this.checkBoxDesabilitado.Text = "Desabilitado";
            this.checkBoxDesabilitado.UseVisualStyleBackColor = true;
            // 
            // CadastroFormaPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 321);
            this.Controls.Add(this.checkBoxDesabilitado);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.labelNomeProduto);
            this.Controls.Add(this.textBoxNomeFormaPagamento);
            this.Name = "CadastroFormaPagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroFormaPagamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Label labelNomeProduto;
        private System.Windows.Forms.MaskedTextBox textBoxNomeFormaPagamento;
        private System.Windows.Forms.CheckBox checkBoxDesabilitado;
    }
}