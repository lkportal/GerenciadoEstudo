using GerenciadoEstudo.controller;
using GerenciadoEstudo.model;
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
using GerenciadoEstudo.view;
using System.Threading;

namespace GerenciadoEstudo {
    public partial class Form1 : Form {
        Usuario user;

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            BDConnection.ConectaBD();

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e) {
            BDConnection.DesconectaBD();
        }

        private void btnEntrar_Click(object sender, EventArgs e) {
            string query = "SELECT NOME, IDENTIFICADOR FROM USUARIO WHERE NOME = @NOME AND IDENTIFICADOR = @SENHA";
            SqlConnection conecta = new SqlConnection(BDConnection.urlConnection);
            SqlCommand cmd = new SqlCommand(query, conecta);
            DataTable dt = new DataTable();
          
            try {
                conecta.Open();
                user = new Usuario(txtNomeLogin.Text.ToLower(), txtIdentificadorLogin.Text.ToLower());
                cmd.Parameters.AddWithValue("@NOME", user.nome);
                cmd.Parameters.AddWithValue("@SENHA", user.senha);
                SqlDataAdapter adpter = new SqlDataAdapter(cmd);
                adpter.Fill(dt);
               
                foreach (DataRow linhas in dt.Rows) {
                    if (linhas["NOME"].ToString() == user.nome && linhas["IDENTIFICADOR"].ToString() == user.senha) {
                        Close();
                        Thread t = new Thread(() => Application.Run(new Tarefas(linhas["nome"].ToString())));
                        t.Start();
                        
                       
                    }
                    else {
                        MessageBox.Show("Senha ou usuario errado");
                    }
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
        
            } finally {
                conecta.Close();
                cmd.Dispose();
                txtNomeLogin.Text = "";
                txtIdentificadorLogin.Text = "";
                
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e) {
            string query = $"INSERT INTO USUARIO (NOME,NIVEL,IDENTIFICADOR) VALUES" +
                    $"(@NOME,@NIVEL,@IDENTIFICADOR) ";
            SqlConnection conecta = new SqlConnection(BDConnection.urlConnection);
            try {

                conecta.Open();
                SqlCommand comando = new SqlCommand(query);
                comando.Connection = conecta;


                if (txtIdentificadorCadastrar.Text != "" && txtNomeCadastrar.Text != "") {
                    user = new Usuario(txtNomeCadastrar.Text, txtIdentificadorCadastrar.Text);
           
                    comando.Parameters.AddWithValue("@NOME",user.nome.ToLower());
                    comando.Parameters.AddWithValue("@NIVEL", user.nivel);
                    comando.Parameters.AddWithValue("@IDENTIFICADOR", user.senha.ToLower());
                    comando.ExecuteNonQuery();
                    comando.Dispose();
                    txtResultaErro.Text = "Cadastrado";
                }
                else {
                    MessageBox.Show("Prencha o campo vazio");
                }

            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                conecta.Close();
                txtNomeCadastrar.Text = "";
                txtIdentificadorCadastrar.Text = "";
                 
            }
        }
    }
}
