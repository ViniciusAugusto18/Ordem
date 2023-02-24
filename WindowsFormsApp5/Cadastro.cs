using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Cadastro : Form

    {
     
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd;
        SqlDataAdapter data;
        SqlDataReader dr;
        string strSQL;



        public Cadastro()
        {
            InitializeComponent();
           
          }



        private void btCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

       public void Cadastro_Load(object sender, EventArgs e)
        {
            try
            {
                conn.ConnectionString = @"Server = DESKTOP-RHAKQM0\SQLEXPRESS; Database = Cadastro; Trusted_Connection = True; ";
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir a conexão com BD " + ex.Message);
            }
        }

        private void cbLocal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btFinalizar_Click(object sender, EventArgs e)
        {
           
            
            try
            {
                
                strSQL = "insert into Cadastro (Funcionario,bloco,data,servico)values (@Funcionario,@bloco,@data,@servico) ";
                cmd = new SqlCommand(strSQL, conn);


                cmd.Parameters.AddWithValue("@Funcionario", tbTipo.Text);
                cmd.Parameters.AddWithValue("@bloco", CbLocal.Text);
                cmd.Parameters.AddWithValue("@data", mbdata.Text);
                cmd.Parameters.AddWithValue("@servico", tpservico.Text);
                
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cadastro efetuado com sucesso!!");


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar funcionario: " + ex);
            }
            

        }

        private void tbTipo_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbTipo.Clear();
            mbdata.Clear();
            tpservico.Clear();
           

        }
    }
}
