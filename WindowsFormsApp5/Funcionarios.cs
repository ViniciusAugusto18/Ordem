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
    public partial class Funcionarios : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd;
        SqlDataAdapter data;
        SqlDataReader dr;
        string strSQL;
        public Funcionarios()
        {
            InitializeComponent();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {

            try
            {

                strSQL = "delete Cadastro where Funcionario = @Funcionario ";
                cmd = new SqlCommand(strSQL, conn);


                cmd.Parameters.AddWithValue("@Funcionario", tbTipo.Text);
                

                cmd.ExecuteNonQuery();
                MessageBox.Show("Funcionario deletado com sucesso!!");


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao deletar funcionario: " + ex);
            }
        }

        private void Funcionarios_Load(object sender, EventArgs e)
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

        private void btEditar_Click(object sender, EventArgs e)
        {
            try
            {

                strSQL = "update Cadastro set Funcionario = @Funcionario ";
                cmd = new SqlCommand(strSQL, conn);


                cmd.Parameters.AddWithValue("@Funcionario", tbTipo.Text);
               

                cmd.ExecuteNonQuery();
                MessageBox.Show("Atualização efetuado com sucesso!!");


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Atualizar funcionario: " + ex);
            }

        }

        private void tbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void att_Click(object sender, EventArgs e)
        {
            try
            {

                strSQL = "select  Cadastro.Funcionario,Cadastro.bloco from Cadastro ";

                DataSet ds = new DataSet();
                data = new SqlDataAdapter(strSQL, conn);
                data.Fill(ds);
                dgvDados.DataSource = ds.Tables[0];


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar funcionario: " + ex);
            }
        }
       
        
            

        }
    }


