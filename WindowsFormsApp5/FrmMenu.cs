using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5 {
    public partial class FrmMenu : Form {
        public FrmMenu() {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {

        }

        private void pictureBox1_Click(object sender, EventArgs e) {

        }

        private void button3_Click(object sender, EventArgs e) {
            Cadastro cadastro = new Cadastro();
            cadastro.Show();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void btnGestaoOs_Click(object sender, EventArgs e)
        {
            Gestao gestao = new Gestao();
            gestao.Show();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            relatorio relatorio = new relatorio();
            relatorio.Show();
        }
    }
}
