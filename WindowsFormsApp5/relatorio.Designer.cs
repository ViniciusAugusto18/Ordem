namespace WindowsFormsApp5
{
    partial class relatorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(relatorio));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.PanelAditivo = new System.Windows.Forms.Panel();
            this.LabelSistemas = new System.Windows.Forms.Label();
            this.loginLogo = new System.Windows.Forms.PictureBox();
            this.cadastroDataSet = new WindowsFormsApp5.CadastroDataSet();
            this.cadastroDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.CadastroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cadastroBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cadastroTableAdapter = new WindowsFormsApp5.CadastroDataSetTableAdapters.CadastroTableAdapter();
            this.cadastroBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.cadastroDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2 = new WindowsFormsApp5.DataSet2();
            this.dataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btFechar = new System.Windows.Forms.Button();
            this.cadastroBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.PanelAditivo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CadastroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroBindingSource3)).BeginInit();
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
            this.LabelSistemas.Location = new System.Drawing.Point(81, 208);
            this.LabelSistemas.Name = "LabelSistemas";
            this.LabelSistemas.Size = new System.Drawing.Size(122, 33);
            this.LabelSistemas.TabIndex = 2;
            this.LabelSistemas.Text = "Relatório";
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
            // cadastroDataSet
            // 
            this.cadastroDataSet.DataSetName = "CadastroDataSet";
            this.cadastroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cadastroDataSetBindingSource
            // 
            this.cadastroDataSetBindingSource.DataSource = this.cadastroDataSet;
            this.cadastroDataSetBindingSource.Position = 0;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.cadastroBindingSource3;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp5.ordem.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(335, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(667, 241);
            this.reportViewer1.TabIndex = 3;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // CadastroBindingSource
            // 
            this.CadastroBindingSource.DataMember = "Cadastro";
            this.CadastroBindingSource.DataSource = this.cadastroDataSet;
            // 
            // cadastroBindingSource1
            // 
            this.cadastroBindingSource1.DataMember = "Cadastro";
            this.cadastroBindingSource1.DataSource = this.cadastroDataSetBindingSource;
            // 
            // cadastroTableAdapter
            // 
            this.cadastroTableAdapter.ClearBeforeFill = true;
            // 
            // cadastroBindingSource2
            // 
            this.cadastroBindingSource2.DataMember = "Cadastro";
            this.cadastroBindingSource2.DataSource = this.cadastroDataSetBindingSource;
            // 
            // cadastroDataSetBindingSource1
            // 
            this.cadastroDataSetBindingSource1.DataSource = this.cadastroDataSet;
            this.cadastroDataSetBindingSource1.Position = 0;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet2BindingSource
            // 
            this.dataSet2BindingSource.DataSource = this.dataSet2;
            this.dataSet2BindingSource.Position = 0;
            // 
            // btFechar
            // 
            this.btFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFechar.Location = new System.Drawing.Point(626, 332);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(173, 42);
            this.btFechar.TabIndex = 4;
            this.btFechar.Text = "Fechar";
            this.btFechar.UseVisualStyleBackColor = true;
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // cadastroBindingSource3
            // 
            this.cadastroBindingSource3.DataMember = "Cadastro";
            this.cadastroBindingSource3.DataSource = this.cadastroDataSet;
            // 
            // relatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 450);
            this.Controls.Add(this.btFechar);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.PanelAditivo);
            this.Name = "relatorio";
            this.Text = "Inventário";
            this.Load += new System.EventHandler(this.Inventario_Load);
            this.PanelAditivo.ResumeLayout(false);
            this.PanelAditivo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CadastroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroBindingSource3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelAditivo;
        private System.Windows.Forms.Label LabelSistemas;
        private System.Windows.Forms.PictureBox loginLogo;
        private System.Windows.Forms.BindingSource cadastroDataSetBindingSource;
        private CadastroDataSet cadastroDataSet;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource CadastroBindingSource;
        private System.Windows.Forms.BindingSource cadastroBindingSource1;
        private CadastroDataSetTableAdapters.CadastroTableAdapter cadastroTableAdapter;
        private System.Windows.Forms.BindingSource cadastroBindingSource2;
        private System.Windows.Forms.BindingSource cadastroDataSetBindingSource1;
        private System.Windows.Forms.BindingSource dataSet2BindingSource;
        private DataSet2 dataSet2;
        private System.Windows.Forms.Button btFechar;
        private System.Windows.Forms.BindingSource cadastroBindingSource3;
    }
}