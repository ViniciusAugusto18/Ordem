using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Gestao : Form
    {
        public Gestao()
        {
            InitializeComponent();
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btFuncionarios_Click(object sender, EventArgs e)
        {
            Funcionarios funcionarios = new Funcionarios();
            funcionarios.MdiParent = this;
            funcionarios.Show();
        }

        private void btOS_Click(object sender, EventArgs e)
        {
            OS os = new OS();
            os.MdiParent = this;
            os.Show();
        }

        private void Gestao_Load(object sender, EventArgs e)
        {

        }
    }
}
