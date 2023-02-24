namespace WindowsFormsApp5
{
    partial class Gestao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gestao));
            this.PanelAditivo = new System.Windows.Forms.Panel();
            this.btOS = new System.Windows.Forms.Button();
            this.btFuncionarios = new System.Windows.Forms.Button();
            this.btFechar = new System.Windows.Forms.Button();
            this.LabelSistemas = new System.Windows.Forms.Label();
            this.loginLogo = new System.Windows.Forms.PictureBox();
            this.PanelAditivo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelAditivo
            // 
            this.PanelAditivo.BackColor = System.Drawing.Color.LightSeaGreen;
            this.PanelAditivo.Controls.Add(this.btOS);
            this.PanelAditivo.Controls.Add(this.btFuncionarios);
            this.PanelAditivo.Controls.Add(this.btFechar);
            this.PanelAditivo.Controls.Add(this.LabelSistemas);
            this.PanelAditivo.Controls.Add(this.loginLogo);
            this.PanelAditivo.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelAditivo.Location = new System.Drawing.Point(0, 0);
            this.PanelAditivo.Name = "PanelAditivo";
            this.PanelAditivo.Size = new System.Drawing.Size(300, 450);
            this.PanelAditivo.TabIndex = 1;
            // 
            // btOS
            // 
            this.btOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOS.Location = new System.Drawing.Point(152, 301);
            this.btOS.Name = "btOS";
            this.btOS.Size = new System.Drawing.Size(139, 42);
            this.btOS.TabIndex = 5;
            this.btOS.Text = "Dados de O.S.";
            this.btOS.UseVisualStyleBackColor = true;
            this.btOS.Click += new System.EventHandler(this.btOS_Click);
            // 
            // btFuncionarios
            // 
            this.btFuncionarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFuncionarios.Location = new System.Drawing.Point(12, 301);
            this.btFuncionarios.Name = "btFuncionarios";
            this.btFuncionarios.Size = new System.Drawing.Size(134, 42);
            this.btFuncionarios.TabIndex = 4;
            this.btFuncionarios.Text = "Dados de Funcionários";
            this.btFuncionarios.UseVisualStyleBackColor = true;
            this.btFuncionarios.Click += new System.EventHandler(this.btFuncionarios_Click);
            // 
            // btFechar
            // 
            this.btFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFechar.Location = new System.Drawing.Point(63, 370);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(173, 42);
            this.btFechar.TabIndex = 3;
            this.btFechar.Text = "Fechar";
            this.btFechar.UseVisualStyleBackColor = true;
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // LabelSistemas
            // 
            this.LabelSistemas.AutoSize = true;
            this.LabelSistemas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LabelSistemas.Font = new System.Drawing.Font("Microsoft Tai Le", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSistemas.ForeColor = System.Drawing.Color.LightCyan;
            this.LabelSistemas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LabelSistemas.Location = new System.Drawing.Point(41, 204);
            this.LabelSistemas.Name = "LabelSistemas";
            this.LabelSistemas.Size = new System.Drawing.Size(211, 33);
            this.LabelSistemas.TabIndex = 2;
            this.LabelSistemas.Text = "Gestão de Dados";
            this.LabelSistemas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // 
            // Gestao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PanelAditivo);
            this.IsMdiContainer = true;
            this.Name = "Gestao";
            this.Text = "Gestão de Dados";
            this.Load += new System.EventHandler(this.Gestao_Load);
            this.PanelAditivo.ResumeLayout(false);
            this.PanelAditivo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelAditivo;
        private System.Windows.Forms.Label LabelSistemas;
        private System.Windows.Forms.PictureBox loginLogo;
        private System.Windows.Forms.Button btOS;
        private System.Windows.Forms.Button btFuncionarios;
        private System.Windows.Forms.Button btFechar;
    }
}