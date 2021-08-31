
namespace BruxoSistema
{
    partial class PDV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PDV));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBoxPesquisaProduto = new System.Windows.Forms.TextBox();
            this.buttonFaturarVenda = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewProdutos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelCliente = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelVendedor = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.labelTotalVenda = new System.Windows.Forms.Label();
            this.labelQuantidadeItens = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxPesquisaProduto
            // 
            this.textBoxPesquisaProduto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPesquisaProduto.Location = new System.Drawing.Point(91, 11);
            this.textBoxPesquisaProduto.Name = "textBoxPesquisaProduto";
            this.textBoxPesquisaProduto.PlaceholderText = "Digita aqui o produto para vender";
            this.textBoxPesquisaProduto.Size = new System.Drawing.Size(650, 29);
            this.textBoxPesquisaProduto.TabIndex = 1;
            this.textBoxPesquisaProduto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPesquisarProdutoEnter_KeyDown);
            // 
            // buttonFaturarVenda
            // 
            this.buttonFaturarVenda.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonFaturarVenda.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonFaturarVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFaturarVenda.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonFaturarVenda.Location = new System.Drawing.Point(747, 502);
            this.buttonFaturarVenda.Name = "buttonFaturarVenda";
            this.buttonFaturarVenda.Size = new System.Drawing.Size(175, 70);
            this.buttonFaturarVenda.TabIndex = 2;
            this.buttonFaturarVenda.Text = "Finalizar (ENTER)";
            this.buttonFaturarVenda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonFaturarVenda.UseVisualStyleBackColor = false;
            this.buttonFaturarVenda.Click += new System.EventHandler(this.buttonFaturarVenda_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Itens:";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTotal.Location = new System.Drawing.Point(3, 79);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(49, 21);
            this.labelTotal.TabIndex = 5;
            this.labelTotal.Text = "Total:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1077, 375);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1087, 403);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(12, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "Produto:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(747, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(747, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 1);
            this.panel1.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(747, 495);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(175, 1);
            this.panel2.TabIndex = 17;
            // 
            // dataGridViewProdutos
            // 
            this.dataGridViewProdutos.AllowUserToAddRows = false;
            this.dataGridViewProdutos.AllowUserToResizeColumns = false;
            this.dataGridViewProdutos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridViewProdutos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProdutos.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewProdutos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewProdutos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewProdutos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewProdutos.EnableHeadersVisualStyles = false;
            this.dataGridViewProdutos.GridColor = System.Drawing.Color.White;
            this.dataGridViewProdutos.Location = new System.Drawing.Point(14, 46);
            this.dataGridViewProdutos.Name = "dataGridViewProdutos";
            this.dataGridViewProdutos.RowHeadersVisible = false;
            this.dataGridViewProdutos.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            this.dataGridViewProdutos.RowTemplate.Height = 25;
            this.dataGridViewProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProdutos.Size = new System.Drawing.Size(727, 491);
            this.dataGridViewProdutos.TabIndex = 18;
            this.dataGridViewProdutos.TabStop = false;
            this.dataGridViewProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProdutos_CellClick);
            this.dataGridViewProdutos.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProdutos_CellEndEdit);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 43.14721F;
            this.Column1.HeaderText = "Codigo";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 209.6561F;
            this.Column2.HeaderText = "Descrição";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 82.11393F;
            this.Column3.HeaderText = "Valor Unitário";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.FillWeight = 71.64872F;
            this.Column4.HeaderText = "Quantidade";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.FillWeight = 93.43407F;
            this.Column5.HeaderText = "Valor Total";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Id";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Codigo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Descrição";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // labelCliente
            // 
            this.labelCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCliente.Location = new System.Drawing.Point(0, 0);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(173, 49);
            this.labelCliente.TabIndex = 19;
            this.labelCliente.Text = "Consumidor";
            this.labelCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.labelCliente);
            this.panel3.Location = new System.Drawing.Point(747, 191);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(175, 51);
            this.panel3.TabIndex = 20;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.labelVendedor);
            this.panel4.Location = new System.Drawing.Point(747, 126);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(175, 51);
            this.panel4.TabIndex = 22;
            // 
            // labelVendedor
            // 
            this.labelVendedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelVendedor.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelVendedor.Location = new System.Drawing.Point(0, 0);
            this.labelVendedor.Name = "labelVendedor";
            this.labelVendedor.Size = new System.Drawing.Size(173, 49);
            this.labelVendedor.TabIndex = 0;
            this.labelVendedor.Text = "label7";
            this.labelVendedor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.labelTotalVenda);
            this.panel5.Controls.Add(this.labelQuantidadeItens);
            this.panel5.Controls.Add(this.labelTotal);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(747, 286);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(175, 140);
            this.panel5.TabIndex = 23;
            // 
            // labelTotalVenda
            // 
            this.labelTotalVenda.AutoSize = true;
            this.labelTotalVenda.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTotalVenda.Location = new System.Drawing.Point(80, 79);
            this.labelTotalVenda.Name = "labelTotalVenda";
            this.labelTotalVenda.Size = new System.Drawing.Size(0, 21);
            this.labelTotalVenda.TabIndex = 21;
            // 
            // labelQuantidadeItens
            // 
            this.labelQuantidadeItens.AutoSize = true;
            this.labelQuantidadeItens.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelQuantidadeItens.Location = new System.Drawing.Point(80, 36);
            this.labelQuantidadeItens.Name = "labelQuantidadeItens";
            this.labelQuantidadeItens.Size = new System.Drawing.Size(0, 21);
            this.labelQuantidadeItens.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(806, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Vendedor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(811, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Cliente";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(798, 280);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Informações";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(14, 543);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 29);
            this.button2.TabIndex = 24;
            this.button2.Text = "Limpar Venda";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // PDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(931, 582);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dataGridViewProdutos);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonFaturarVenda);
            this.Controls.Add(this.textBoxPesquisaProduto);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PDV";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Boas Vendas";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FecharPDV_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxPesquisaProduto;
        private System.Windows.Forms.Button buttonFaturarVenda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewProdutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label labelCliente;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label labelTotalVenda;
        private System.Windows.Forms.Label labelQuantidadeItens;
        private System.Windows.Forms.Label labelVendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
    }
}