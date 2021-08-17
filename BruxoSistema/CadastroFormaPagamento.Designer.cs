
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroFormaPagamento));
            this.checkBoxDesabilitado = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonEntrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNomeFormaPagamento = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBoxDesabilitado
            // 
            this.checkBoxDesabilitado.AutoSize = true;
            this.checkBoxDesabilitado.Location = new System.Drawing.Point(197, 152);
            this.checkBoxDesabilitado.Name = "checkBoxDesabilitado";
            this.checkBoxDesabilitado.Size = new System.Drawing.Size(91, 19);
            this.checkBoxDesabilitado.TabIndex = 16;
            this.checkBoxDesabilitado.TabStop = false;
            this.checkBoxDesabilitado.Text = "Desabilitado";
            this.checkBoxDesabilitado.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(140, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Image = global::BruxoSistema.Properties.Resources.sair__1_;
            this.button1.Location = new System.Drawing.Point(52, 227);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(236, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "Cancelar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonEntrar
            // 
            this.buttonEntrar.Image = global::BruxoSistema.Properties.Resources.entrar;
            this.buttonEntrar.Location = new System.Drawing.Point(52, 186);
            this.buttonEntrar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonEntrar.Name = "buttonEntrar";
            this.buttonEntrar.Size = new System.Drawing.Size(236, 35);
            this.buttonEntrar.TabIndex = 2;
            this.buttonEntrar.Text = "Cadastrar Forma";
            this.buttonEntrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonEntrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonEntrar.UseVisualStyleBackColor = true;
            this.buttonEntrar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(41, 122);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "Nome:";
            // 
            // textBoxNomeFormaPagamento
            // 
            this.textBoxNomeFormaPagamento.Location = new System.Drawing.Point(98, 121);
            this.textBoxNomeFormaPagamento.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxNomeFormaPagamento.Name = "textBoxNomeFormaPagamento";
            this.textBoxNomeFormaPagamento.PlaceholderText = "Nome da forma de pagamento";
            this.textBoxNomeFormaPagamento.Size = new System.Drawing.Size(190, 23);
            this.textBoxNomeFormaPagamento.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(52, 179);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 1);
            this.panel1.TabIndex = 30;
            // 
            // CadastroFormaPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(328, 321);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonEntrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNomeFormaPagamento);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkBoxDesabilitado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadastroFormaPagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forma de pagamento";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CadastroFormaPagamento_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox checkBoxDesabilitado;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonEntrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNomeFormaPagamento;
        private System.Windows.Forms.Panel panel1;
    }
}