
namespace BruxoSistema.NovasTelas.NovosRecursos
{
    partial class frmLogin
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
            DevExpress.XtraEditors.PictureEdit pictureEdit1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.txtLogin = new DevExpress.XtraEditors.TextEdit();
            this.lblUsuairo = new DevExpress.XtraEditors.LabelControl();
            this.lblSenha = new DevExpress.XtraEditors.LabelControl();
            this.txtSenha = new DevExpress.XtraEditors.TextEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdicionarUsuario = new DevExpress.XtraEditors.SimpleButton();
            this.btnEntrar = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLogin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSenha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureEdit1
            // 
            pictureEdit1.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.False;
            pictureEdit1.CausesValidation = false;
            pictureEdit1.EditValue = global::BruxoSistema.NovasTelas.Properties.Resources.Logo_SistemasBr_Solid_hor;
            pictureEdit1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            pictureEdit1.Location = new System.Drawing.Point(52, 5);
            pictureEdit1.Name = "pictureEdit1";
            pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            pictureEdit1.ShowToolTips = false;
            pictureEdit1.Size = new System.Drawing.Size(297, 132);
            pictureEdit1.TabIndex = 9;
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(133, 207);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(126)))), ((int)(((byte)(210)))));
            this.txtLogin.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.Properties.Appearance.Options.UseBorderColor = true;
            this.txtLogin.Properties.Appearance.Options.UseFont = true;
            this.txtLogin.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White;
            this.txtLogin.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtLogin.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtLogin.Size = new System.Drawing.Size(199, 26);
            this.txtLogin.TabIndex = 1;
            this.txtLogin.ToolTip = "Leo";
            this.txtLogin.ToolTipTitle = "Leozin";
            // 
            // lblUsuairo
            // 
            this.lblUsuairo.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuairo.Appearance.Options.UseFont = true;
            this.lblUsuairo.Location = new System.Drawing.Point(68, 210);
            this.lblUsuairo.Name = "lblUsuairo";
            this.lblUsuairo.Size = new System.Drawing.Size(59, 20);
            this.lblUsuairo.TabIndex = 2;
            this.lblUsuairo.Text = "Usuário:";
            // 
            // lblSenha
            // 
            this.lblSenha.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Appearance.Options.UseFont = true;
            this.lblSenha.Location = new System.Drawing.Point(76, 253);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(51, 20);
            this.lblSenha.TabIndex = 4;
            this.lblSenha.Text = "Senha:";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(133, 250);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(126)))), ((int)(((byte)(210)))));
            this.txtSenha.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Properties.Appearance.Options.UseBorderColor = true;
            this.txtSenha.Properties.Appearance.Options.UseFont = true;
            this.txtSenha.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White;
            this.txtSenha.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtSenha.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtSenha.Properties.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(199, 26);
            this.txtSenha.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(126)))), ((int)(((byte)(215)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(68, 306);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 1);
            this.panel1.TabIndex = 8;
            // 
            // btnAdicionarUsuario
            // 
            this.btnAdicionarUsuario.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(126)))), ((int)(((byte)(210)))));
            this.btnAdicionarUsuario.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(126)))), ((int)(((byte)(210)))));
            this.btnAdicionarUsuario.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarUsuario.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnAdicionarUsuario.Appearance.Options.UseBackColor = true;
            this.btnAdicionarUsuario.Appearance.Options.UseBorderColor = true;
            this.btnAdicionarUsuario.Appearance.Options.UseFont = true;
            this.btnAdicionarUsuario.Appearance.Options.UseForeColor = true;
            this.btnAdicionarUsuario.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnAdicionarUsuario.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.btnAdicionarUsuario.ImageOptions.Image = global::BruxoSistema.NovasTelas.Properties.Resources._216490_add_user_icon__1_;
            this.btnAdicionarUsuario.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAdicionarUsuario.Location = new System.Drawing.Point(262, 337);
            this.btnAdicionarUsuario.Name = "btnAdicionarUsuario";
            this.btnAdicionarUsuario.Size = new System.Drawing.Size(70, 35);
            this.btnAdicionarUsuario.TabIndex = 7;
            // 
            // btnEntrar
            // 
            this.btnEntrar.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(126)))), ((int)(((byte)(210)))));
            this.btnEntrar.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(201)))));
            this.btnEntrar.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnEntrar.Appearance.Options.UseBackColor = true;
            this.btnEntrar.Appearance.Options.UseBorderColor = true;
            this.btnEntrar.Appearance.Options.UseFont = true;
            this.btnEntrar.Appearance.Options.UseForeColor = true;
            this.btnEntrar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnEntrar.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.btnEntrar.ImageOptions.Image = global::BruxoSistema.NovasTelas.Properties.Resources.entrar;
            this.btnEntrar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnEntrar.Location = new System.Drawing.Point(76, 337);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(180, 35);
            this.btnEntrar.TabIndex = 3;
            this.btnEntrar.Text = "Entrar";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 407);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(58, 13);
            this.labelControl1.TabIndex = 10;
            this.labelControl1.Text = "By: Bruxaria";
            // 
            // frmLogin
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseBorderColor = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 432);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAdicionarUsuario);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.lblUsuairo);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(pictureEdit1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bem-Vindo";
            ((System.ComponentModel.ISupportInitialize)(pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLogin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSenha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit txtLogin;
        private DevExpress.XtraEditors.LabelControl lblUsuairo;
        private DevExpress.XtraEditors.LabelControl lblSenha;
        private DevExpress.XtraEditors.TextEdit txtSenha;
        private DevExpress.XtraEditors.SimpleButton btnEntrar;
        private DevExpress.XtraEditors.SimpleButton btnAdicionarUsuario;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
    }
}