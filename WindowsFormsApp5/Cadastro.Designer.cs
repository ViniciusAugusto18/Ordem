namespace WindowsFormsApp5
{
    partial class Cadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro));
            this.PanelAditivo = new System.Windows.Forms.Panel();
            this.LabelSistemas = new System.Windows.Forms.Label();
            this.loginLogo = new System.Windows.Forms.PictureBox();
            this.tbTipo = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.CbLocal = new System.Windows.Forms.ComboBox();
            this.lbLocal = new System.Windows.Forms.Label();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btFinalizar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.mbdata = new System.Windows.Forms.MaskedTextBox();
            this.lbData = new System.Windows.Forms.Label();
            this.tpservico = new System.Windows.Forms.TextBox();
            this.lbTipo = new System.Windows.Forms.Label();
            this.PanelAditivo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginLogo)).BeginInit();
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
            this.PanelAditivo.Size = new System.Drawing.Size(300, 450);
            this.PanelAditivo.TabIndex = 1;
            // 
            // LabelSistemas
            // 
            this.LabelSistemas.AutoSize = true;
            this.LabelSistemas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LabelSistemas.Font = new System.Drawing.Font("Microsoft Tai Le", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSistemas.ForeColor = System.Drawing.Color.LightCyan;
            this.LabelSistemas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LabelSistemas.Location = new System.Drawing.Point(12, 208);
            this.LabelSistemas.Name = "LabelSistemas";
            this.LabelSistemas.Size = new System.Drawing.Size(277, 66);
            this.LabelSistemas.TabIndex = 2;
            this.LabelSistemas.Text = "Cadastro de \r\nFuncionário e Serviços";
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
            // tbTipo
            // 
            this.tbTipo.Location = new System.Drawing.Point(502, 139);
            this.tbTipo.Name = "tbTipo";
            this.tbTipo.Size = new System.Drawing.Size(184, 20);
            this.tbTipo.TabIndex = 8;
            this.tbTipo.TextChanged += new System.EventHandler(this.tbTipo_TextChanged);
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbNome.Location = new System.Drawing.Point(306, 139);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(179, 20);
            this.lbNome.TabIndex = 7;
            this.lbNome.Text = "Nome do funcionário:";
            // 
            // CbLocal
            // 
            this.CbLocal.FormattingEnabled = true;
            this.CbLocal.Items.AddRange(new object[] {
            "Bloco: 1 ",
            "Bloco: 2 ",
            "Bloco: 3",
            "Bloco: 4"});
            this.CbLocal.Location = new System.Drawing.Point(502, 175);
            this.CbLocal.Name = "CbLocal";
            this.CbLocal.Size = new System.Drawing.Size(114, 21);
            this.CbLocal.TabIndex = 12;
            this.CbLocal.SelectedIndexChanged += new System.EventHandler(this.cbLocal_SelectedIndexChanged);
            // 
            // lbLocal
            // 
            this.lbLocal.AutoSize = true;
            this.lbLocal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLocal.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbLocal.Location = new System.Drawing.Point(327, 176);
            this.lbLocal.Name = "lbLocal";
            this.lbLocal.Size = new System.Drawing.Size(153, 20);
            this.lbLocal.TabIndex = 11;
            this.lbLocal.Text = "Local de trabalho:";
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btCancelar.Location = new System.Drawing.Point(502, 305);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(96, 36);
            this.btCancelar.TabIndex = 16;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btFinalizar
            // 
            this.btFinalizar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFinalizar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btFinalizar.Location = new System.Drawing.Point(391, 305);
            this.btFinalizar.Name = "btFinalizar";
            this.btFinalizar.Size = new System.Drawing.Size(89, 36);
            this.btFinalizar.TabIndex = 15;
            this.btFinalizar.Text = "Finalizar";
            this.btFinalizar.UseVisualStyleBackColor = false;
            this.btFinalizar.Click += new System.EventHandler(this.btFinalizar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(628, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 36);
            this.button1.TabIndex = 17;
            this.button1.Text = "Novo";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mbdata
            // 
            this.mbdata.Location = new System.Drawing.Point(502, 220);
            this.mbdata.Mask = "00/00/0000";
            this.mbdata.Name = "mbdata";
            this.mbdata.Size = new System.Drawing.Size(68, 20);
            this.mbdata.TabIndex = 21;
            this.mbdata.ValidatingType = typeof(System.DateTime);
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbData.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbData.Location = new System.Drawing.Point(346, 218);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(139, 20);
            this.lbData.TabIndex = 20;
            this.lbData.Text = "Data do serviço:";
            // 
            // tpservico
            // 
            this.tpservico.Location = new System.Drawing.Point(502, 256);
            this.tpservico.Name = "tpservico";
            this.tpservico.Size = new System.Drawing.Size(182, 20);
            this.tpservico.TabIndex = 19;
            // 
            // lbTipo
            // 
            this.lbTipo.AutoSize = true;
            this.lbTipo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTipo.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbTipo.Location = new System.Drawing.Point(346, 254);
            this.lbTipo.Name = "lbTipo";
            this.lbTipo.Size = new System.Drawing.Size(134, 20);
            this.lbTipo.TabIndex = 18;
            this.lbTipo.Text = "Tipo de serviço:";
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mbdata);
            this.Controls.Add(this.lbData);
            this.Controls.Add(this.tpservico);
            this.Controls.Add(this.lbTipo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btFinalizar);
            this.Controls.Add(this.CbLocal);
            this.Controls.Add(this.lbLocal);
            this.Controls.Add(this.tbTipo);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.PanelAditivo);
            this.Name = "Cadastro";
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.Cadastro_Load);
            this.PanelAditivo.ResumeLayout(false);
            this.PanelAditivo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelAditivo;
        private System.Windows.Forms.Label LabelSistemas;
        private System.Windows.Forms.PictureBox loginLogo;
        private System.Windows.Forms.TextBox tbTipo;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.ComboBox CbLocal;
        private System.Windows.Forms.Label lbLocal;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btFinalizar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox mbdata;
        private System.Windows.Forms.Label lbData;
        private System.Windows.Forms.TextBox tpservico;
        private System.Windows.Forms.Label lbTipo;
    }
}