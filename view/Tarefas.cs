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
using GerenciadoEstudo.model;
using GerenciadoEstudo.controller;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using System.Data.Common;

namespace GerenciadoEstudo.view {
    public partial class Tarefas : Form {
        string nome;
        int id;
        public Tarefas(string dados) {
            InitializeComponent();
            nome = dados;
        }
     

        private void btnCompletar_Click(object sender, EventArgs e) {
            SqlConnection conecta = new SqlConnection(BDConnection.urlConnection);
            SqlCommand cmd = new SqlCommand();
            Materia materia;
            string queryInsert = "INSERT INTO MATERIA(NOME,PLATAFORMA_ESTUDO," +
                "DETALHES,FK_USUARIO,DIA,MES,HORAS) VALUES (@NOME,@PLATAFORMA_ESTUDO," +
                "@DETALHES,@FK_USUARIO,@DIA,@MES,@HORAS)";
           
            try {
                 string Mouth = DateTime.Now.Month.ToString();
                conecta.Open();
                nome = getNameBD();

                 id = GetID();
                cmd.Connection = conecta;
                cmd.CommandText = queryInsert;

                materia = new Materia(txtMateria.Text, dateDay.Text, double.Parse(timeHours.Text), Mouth, txtPlataforma.Text, txtDescricao.Text);
                cmd.Parameters.AddWithValue("@NOME",materia.NomeMateria );
                cmd.Parameters.AddWithValue("@PLATAFORMA_ESTUDO", materia.Plataforma);
                cmd.Parameters.AddWithValue("@DETALHES", materia.Detalhes);
                cmd.Parameters.AddWithValue("@FK_USUARIO",id);
                cmd.Parameters.AddWithValue("@DIA", materia.Day);
                cmd.Parameters.AddWithValue("@MES", materia.Mouth);
                cmd.Parameters.AddWithValue("@HORAS",materia.Hours);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                MessageBox.Show("Dados Inseridos");


            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                conecta.Close();
                cmd.Dispose();
                txtMateria.Text = "";
                txtPlataforma.Text = "";
                txtDescricao.Text = "";
                dateDay.Text = "";
                timeHours.Text = "";
                
            }
        }

        public string getNameBD() {
            string query = "SELECT NOME FROM USUARIO"; 
            SqlConnection conecta = new SqlConnection(BDConnection.urlConnection);
            SqlCommand getName = new SqlCommand(query,conecta);
            try {
                conecta.Open();
                SqlDataAdapter dt = new SqlDataAdapter(getName);
                DataTable tb = new DataTable();
                dt.Fill(tb);
                foreach(DataRow dr in tb.Rows) {
                    if (dr["Nome"].Equals(nome))
                        return dr["NOME"].ToString();
                } 
            }catch(Exception ex) {
                MessageBox.Show("getNameBD: " + ex.Message);
            } finally {
                conecta.Close();
            }
            return "";
        }

        public int GetID() {
            SqlConnection conecta = new SqlConnection(BDConnection.urlConnection);
            SqlCommand cmdSe = new SqlCommand();
            string querySelectId = "SELECT IDUSUARIO FROM USUARIO WHERE NOME = @NOME";
            try {
                conecta.Open();
                cmdSe.Connection = conecta;
                cmdSe.CommandText = querySelectId;
                cmdSe.Parameters.AddWithValue("@NOME", nome);
                labelNome.Text = nome;
                cmdSe.ExecuteNonQuery();
                SqlDataAdapter dt = new SqlDataAdapter(cmdSe);
                DataTable colum = new DataTable();
                dt.Fill(colum);
                foreach (DataRow linha in colum.Rows) {
                    labelteste.Text =linha["IDUSUARIO"].ToString();
                    return  (int)linha["IDUSUARIO"];
                   

                }

            } catch(Exception e) {
                MessageBox.Show(e.Message);
            } finally {
                cmdSe.Dispose();
                conecta.Close();
            }
            return 0;
        }

        private void Tarefas_Load(object sender, EventArgs e) {
            nome = getNameBD();
            id = GetID();
            labelNome.Text = nome;
        }

        private void Tarefas_FormClosed(object sender, FormClosedEventArgs e) {
            BDConnection.DesconectaBD();
        }
    }
}
