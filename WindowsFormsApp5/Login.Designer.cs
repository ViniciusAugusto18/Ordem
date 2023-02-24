namespace WindowsFormsApp5 {
    partial class FrmPrincipal {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.PanelAditivo = new System.Windows.Forms.Panel();
            this.LabelSistemas = new System.Windows.Forms.Label();
            this.loginLogo = new System.Windows.Forms.PictureBox();
            this.PanelPrincipal = new System.Windows.Forms.Panel();
            this.BtnSair = new System.Windows.Forms.Button();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.PanelSenha = new System.Windows.Forms.Panel();
            this.texSenha = new System.Windows.Forms.TextBox();
            this.iconeSenha = new System.Windows.Forms.PictureBox();
            this.Panelusuario = new System.Windows.Forms.Panel();
            this.texLogin = new System.Windows.Forms.TextBox();
            this.iconeUsuario = new System.Windows.Forms.PictureBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.LabelHarpa = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelAditivo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginLogo)).BeginInit();
            this.PanelPrincipal.SuspendLayout();
            this.PanelSenha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconeSenha)).BeginInit();
            this.Panelusuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconeUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelAditivo
            // 
            this.PanelAditivo.BackColor = System.Drawing.Color.LightSeaGreen;
            this.PanelAditivo.Controls.Add(this.LabelSistemas);
            this.PanelAditivo.Controls.Add(this.loginLogo);
            this.PanelAditivo.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelAditivo.Location = new System.Drawing.Point(0, 0);
            this.PanelAditivo.Name = "PanelAditivo";
            this.PanelAditivo.Size = new System.Drawing.Size(300, 530);
            this.PanelAditivo.TabIndex = 0;
            // 
            // LabelSistemas
            // 
            this.LabelSistemas.AutoSize = true;
            this.LabelSistemas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LabelSistemas.Font = new System.Drawing.Font("Microsoft Tai Le", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSistemas.ForeColor = System.Drawing.Color.LightCyan;
            this.LabelSistemas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LabelSistemas.Location = new System.Drawing.Point(4, 195);
            this.LabelSistemas.Name = "LabelSistemas";
            this.LabelSistemas.Size = new System.Drawing.Size(293, 66);
            this.LabelSistemas.TabIndex = 2;
            this.LabelSistemas.Text = "Sistema Gerenciador de\r\n Ordem de Serviço";
            this.LabelSistemas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelSistemas.Click += new System.EventHandler(this.label3_Click);
            // 
            // loginLogo
            // 
            this.loginLogo.BackColor = System.Drawing.Color.LightCyan;
            this.loginLogo.Image = ((System.Drawing.Image)(resources.GetObject("loginLogo.Image")));
            this.loginLogo.Location = new System.Drawing.Point(0, 12);
            this.loginLogo.Name = "loginLogo";
            this.loginLogo.Size = new System.Drawing.Size(301, 62);
            this.loginLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loginLogo.TabIndex = 0;
            this.loginLogo.TabStop = false;
            this.loginLogo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // PanelPrincipal
            // 
            this.PanelPrincipal.Controls.Add(this.BtnSair);
            this.PanelPrincipal.Controls.Add(this.btnEntrar);
            this.PanelPrincipal.Controls.Add(this.PanelSenha);
            this.PanelPrincipal.Controls.Add(this.Panelusuario);
            this.PanelPrincipal.Controls.Add(this.labelLogin);
            this.PanelPrincipal.Controls.Add(this.btnFechar);
            this.PanelPrincipal.Controls.Add(this.LabelHarpa);
            this.PanelPrincipal.Controls.Add(this.label1);
            this.PanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelPrincipal.Location = new System.Drawing.Point(300, 0);
            this.PanelPrincipal.Name = "PanelPrincipal";
            this.PanelPrincipal.Size = new System.Drawing.Size(450, 530);
            this.PanelPrincipal.TabIndex = 1;
            this.PanelPrincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // BtnSair
            // 
            this.BtnSair.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BtnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSair.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BtnSair.Location = new System.Drawing.Point(207, 439);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(63, 24);
            this.BtnSair.TabIndex = 9;
            this.BtnSair.Text = "SAIR";
            this.BtnSair.UseVisualStyleBackColor = false;
            this.BtnSair.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnEntrar.Location = new System.Drawing.Point(113, 439);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(63, 24);
            this.btnEntrar.TabIndex = 8;
            this.btnEntrar.Text = "ENTRAR";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.ButtonEntrar_Click);
            // 
            // PanelSenha
            // 
            this.PanelSenha.Controls.Add(this.texSenha);
            this.PanelSenha.Controls.Add(this.iconeSenha);
            this.PanelSenha.Location = new System.Drawing.Point(45, 378);
            this.PanelSenha.Name = "PanelSenha";
            this.PanelSenha.Size = new System.Drawing.Size(304, 38);
            this.PanelSenha.TabIndex = 7;
            // 
            // texSenha
            // 
            this.texSenha.Location = new System.Drawing.Point(47, 9);
            this.texSenha.Name = "texSenha";
            this.texSenha.Size = new System.Drawing.Size(243, 26);
            this.texSenha.TabIndex = 11;
            // 
            // iconeSenha
            // 
            this.iconeSenha.Image = ((System.Drawing.Image)(resources.GetObject("iconeSenha.Image")));
            this.iconeSenha.InitialImage = ((System.Drawing.Image)(resources.GetObject("iconeSenha.InitialImage")));
            this.iconeSenha.Location = new System.Drawing.Point(0, 0);
            this.iconeSenha.Name = "iconeSenha";
            this.iconeSenha.Size = new System.Drawing.Size(41, 38);
            this.iconeSenha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconeSenha.TabIndex = 10;
            this.iconeSenha.TabStop = false;
            this.iconeSenha.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // Panelusuario
            // 
            this.Panelusuario.Controls.Add(this.texLogin);
            this.Panelusuario.Controls.Add(this.iconeUsuario);
            this.Panelusuario.Location = new System.Drawing.Point(45, 317);
            this.Panelusuario.Name = "Panelusuario";
            this.Panelusuario.Size = new System.Drawing.Size(304, 38);
            this.Panelusuario.TabIndex = 6;
            // 
            // texLogin
            // 
            this.texLogin.Location = new System.Drawing.Point(47, 9);
            this.texLogin.Name = "texLogin";
            this.texLogin.Size = new System.Drawing.Size(243, 26);
            this.texLogin.TabIndex = 10;
            this.texLogin.TextChanged += new System.EventHandler(this.texLogin_TextChanged);
            // 
            // iconeUsuario
            // 
            this.iconeUsuario.Image = ((System.Drawing.Image)(resources.GetObject("iconeUsuario.Image")));
            this.iconeUsuario.Location = new System.Drawing.Point(0, 0);
            this.iconeUsuario.Name = "iconeUsuario";
            this.iconeUsuario.Size = new System.Drawing.Size(41, 38);
            this.iconeUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconeUsuario.TabIndex = 9;
            this.iconeUsuario.TabStop = false;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.ForeColor = System.Drawing.Color.DarkCyan;
            this.labelLogin.Location = new System.Drawing.Point(6, 284);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(147, 20);
            this.labelLogin.TabIndex = 4;
            this.labelLogin.Text = "Faça o seu Login";
            // 
            // btnFechar
            // 
            this.btnFechar.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.Teal;
            this.btnFechar.Location = new System.Drawing.Point(269, 12);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(80, 28);
            this.btnFechar.TabIndex = 2;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.button1_Click);
            // 
            // LabelHarpa
            // 
            this.LabelHarpa.AutoSize = true;
            this.LabelHarpa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHarpa.ForeColor = System.Drawing.Color.DarkCyan;
            this.LabelHarpa.Location = new System.Drawing.Point(228, 508);
            this.LabelHarpa.Name = "LabelHarpa";
            this.LabelHarpa.Size = new System.Drawing.Size(121, 13);
            this.LabelHarpa.TabIndex = 1;
            this.LabelHarpa.Text = "Harpa Sistemas S/A";
            this.LabelHarpa.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 39);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 530);
            this.Controls.Add(this.PanelPrincipal);
            this.Controls.Add(this.PanelAditivo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.PanelAditivo.ResumeLayout(false);
            this.PanelAditivo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginLogo)).EndInit();
            this.PanelPrincipal.ResumeLayout(false);
            this.PanelPrincipal.PerformLayout();
            this.PanelSenha.ResumeLayout(false);
            this.PanelSenha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconeSenha)).EndInit();
            this.Panelusuario.ResumeLayout(false);
            this.Panelusuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconeUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelAditivo;
        private System.Windows.Forms.Panel PanelPrincipal;
        private System.Windows.Forms.PictureBox loginLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelSistemas;
        private System.Windows.Forms.Label LabelHarpa;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Panel Panelusuario;
        private System.Windows.Forms.Panel PanelSenha;
        private System.Windows.Forms.PictureBox iconeUsuario;
        private System.Windows.Forms.PictureBox iconeSenha;
        private System.Windows.Forms.TextBox texSenha;
        private System.Windows.Forms.TextBox texLogin;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Button BtnSair;
    }
}

