using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Cliente{
    public partial class Form1 : Form{
        SqlConnection conexao;
        SqlCommand comando;
        SqlDataAdapter da;
        SqlDataReader dr;

        string strSQL;
        public Form1(){
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e){

        }

        private void BtnNovo_Click(object sender, EventArgs e){


            try{
                conexao = new SqlConnection("Server=DESKTOP-GI8KG8T;Database=Cliente;User Id=sa;Password=13072001cms;");

                strSQL = "INSERT INTO CAD_CLIENTE (nome, numero) VALUES (@nome, @numero) ";

                comando = new SqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@nome", TextNome.Text);
                comando.Parameters.AddWithValue("@numero", TextNumero.Text);

                conexao.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex){

                MessageBox.Show(ex.Message);
            }
            finally{
                conexao.Close();
                conexao = null;
                comando = null;
            }
        }

        private void BtnExibir_Click(object sender, EventArgs e){
            try{
                conexao = new SqlConnection("Server=DESKTOP-GI8KG8T;Database=Cliente;User Id=sa;Password=13072001cms;");

                strSQL = "Select * from CAD_CLIENTE";

                DataSet ds = new DataSet();

                da = new SqlDataAdapter(strSQL, conexao);

                conexao.Open();

                da.Fill(ds);

                DgvDados.DataSource = ds.Tables[0];
            }
            catch (Exception ex){

                MessageBox.Show(ex.Message);
            }
            finally{
                conexao.Close();
                conexao = null;
                comando = null;
            }
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {

            try{
                conexao = new SqlConnection("Server=DESKTOP-GI8KG8T;Database=Cliente;User Id=sa;Password=13072001cms;");

                strSQL = "Select * from CAD_CLIENTE WHERE ID =  @ID";

                comando = new SqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@ID", TextId.Text);
               
                conexao.Open();

                dr = comando.ExecuteReader();

                while (dr.Read()){
                    TextNome.Text = (string)dr["nome"];
                    TextNumero.Text = Convert.ToString(dr["numero"]);
                }
            }
            catch (Exception ex){

                MessageBox.Show(ex.Message);
            }
            finally{
                conexao.Close();
                conexao = null;
                comando = null;
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e){

            try{
                conexao = new SqlConnection("Server=DESKTOP-GI8KG8T;Database=Cliente;User Id=sa;Password=13072001cms;");

                strSQL = "UPDATE CAD_CLIENTE SET nome = @nome, numero = @numero WHERE Id = @id";

                comando = new SqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@id", TextId.Text);
                comando.Parameters.AddWithValue("@nome", TextNome.Text);
                comando.Parameters.AddWithValue("@numero", TextNumero.Text);

                conexao.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex){

                MessageBox.Show(ex.Message);
            }
            finally{
                conexao.Close();
                conexao = null;
                comando = null;
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e){
            try{
                conexao = new SqlConnection("Server=DESKTOP-GI8KG8T;Database=Cliente;User Id=sa;Password=13072001cms;");

                strSQL = "DELETE CAD_CLIENTE WHERE Id = @id";

                comando = new SqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@ID", TextId.Text);

                conexao.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex){

                MessageBox.Show(ex.Message);
            }
            finally{
                conexao.Close();
                conexao = null;
                comando = null;
            }
        }
    }
}
