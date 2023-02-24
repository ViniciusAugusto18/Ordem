namespace WindowsFormsApp5
{
    partial class OS
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
            this.btExcluir = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.lbOS = new System.Windows.Forms.Label();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.tbTipo = new System.Windows.Forms.TextBox();
            this.att = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // btExcluir
            // 
            this.btExcluir.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExcluir.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btExcluir.Location = new System.Drawing.Point(161, 329);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(89, 36);
            this.btExcluir.TabIndex = 22;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = false;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btCancelar.Location = new System.Drawing.Point(287, 329);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(96, 36);
            this.btCancelar.TabIndex = 21;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btEditar
            // 
            this.btEditar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btEditar.Location = new System.Drawing.Point(32, 329);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(89, 36);
            this.btEditar.TabIndex = 20;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = false;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // lbOS
            // 
            this.lbOS.AutoSize = true;
            this.lbOS.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOS.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbOS.Location = new System.Drawing.Point(23, 135);
            this.lbOS.Name = "lbOS";
            this.lbOS.Size = new System.Drawing.Size(258, 20);
            this.lbOS.TabIndex = 18;
            this.lbOS.Text = "Escreva uma ordem de serviço:";
            // 
            // dgvDados
            // 
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(27, 170);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.Size = new System.Drawing.Size(500, 153);
            this.dgvDados.TabIndex = 23;
            this.dgvDados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tbTipo
            // 
            this.tbTipo.Location = new System.Drawing.Point(302, 137);
            this.tbTipo.Name = "tbTipo";
            this.tbTipo.Size = new System.Drawing.Size(108, 20);
            this.tbTipo.TabIndex = 24;
            // 
            // att
            // 
            this.att.BackColor = System.Drawing.Color.LightSeaGreen;
            this.att.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.att.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.att.Location = new System.Drawing.Point(533, 214);
            this.att.Name = "att";
            this.att.Size = new System.Drawing.Size(96, 36);
            this.att.TabIndex = 26;
            this.att.Text = "Atualizar";
            this.att.UseVisualStyleBackColor = false;
            this.att.Click += new System.EventHandler(this.att_Click);
            // 
            // OS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.att);
            this.Controls.Add(this.tbTipo);
            this.Controls.Add(this.dgvDados);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.lbOS);
            this.Name = "OS";
            this.Text = "OS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.OS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Label lbOS;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.TextBox tbTipo;
        private System.Windows.Forms.Button att;
    }
}