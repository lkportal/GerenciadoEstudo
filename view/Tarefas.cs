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
using System.Globalization;
using System.Threading;

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
                
                conecta.Open();
                DateTime date = DateTime.Now;
                CultureInfo culture = new CultureInfo("pt-BR");
                string mes = culture.DateTimeFormat.GetMonthName(date.Month);
               
                
                 id = GetID();
                cmd.Connection = conecta;
                cmd.CommandText = queryInsert;

                materia = new Materia(txtMateria.Text, dateDay.Text, double.Parse(timeHours.Text), mes, txtPlataforma.Text, txtDescricao.Text);
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
            
            id = GetID();
            labelNome.Text = nome;
        }

        private void Tarefas_FormClosed(object sender, FormClosedEventArgs e) {
            BDConnection.DesconectaBD();
        }

        private void button1_Click(object sender, EventArgs e) {
            lista.Rows.Clear();
            SqlConnection conecta = new SqlConnection(BDConnection.urlConnection);
            SqlCommand comando = new SqlCommand();
            string query = "SELECT NOME,DIA, MES , HORAS AS Horas_Estudadas FROM MATERIA WHERE FK_USUARIO = @ID  ";
            try {
                int Mes = DateTime.Now.Month;
                id = GetID();
                conecta.Open();
                comando.Connection = conecta;
                comando.CommandText = query;
                comando.Parameters.AddWithValue("@ID", id);
                comando.ExecuteNonQuery();
                SqlDataAdapter adpter = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                adpter.Fill(dt);
                foreach(DataRow listasDados in dt.Rows) {
                    lista.Rows.Add(listasDados.ItemArray);
                   

                }
                


            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                conecta.Close();
                comando.Dispose();
            }

        }

        private void labelVolta_Click(object sender, EventArgs e) {
            Close();
            Thread t = new Thread(() => Application.Run(new Form1()));
            t.Start();
        }
    }
}
