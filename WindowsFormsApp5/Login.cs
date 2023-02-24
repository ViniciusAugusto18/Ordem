using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;
using System.Security.Policy;

namespace WindowsFormsApp5 {
    public partial class FrmPrincipal : Form
    {
    
        
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void label3_Click(object sender, EventArgs e) {

        }

        private void pictureBox1_Click(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e) {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e) {

        }

        private void button1_Click_1(object sender, EventArgs e) {
            Application.Exit();
        }

        private void ButtonEntrar_Click(object sender, EventArgs e) {
            {
                {


                    StreamReader sr = new StreamReader("Dados.txt");//caminho do seu arquivo txt
                    string usuario = sr.ReadLine(); //vai ler a primeira linha onde está o usuario
                    string senha = sr.ReadLine(); //vai ler a segunda linha onde está a senha
                    if (texLogin.Text == usuario && texSenha.Text == senha)
                    {
                        MessageBox.Show("Login realizado com sucesso!");
                        FrmMenu tMenu = new FrmMenu();
                        tMenu.Show();
                    }
                    else
                    {
                        MessageBox.Show("Usuário ou senha incorretos!");
                    }

                }

            }






            //private void btnEntrar_MouseDown(object sender, MouseEventArgs e)// 


        }

        private void texLogin_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
