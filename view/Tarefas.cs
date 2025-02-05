﻿using System;
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
        SqlConnection conecta;
        SqlCommand cmd;
        public Tarefas(string dados) {
            InitializeComponent();
            nome = dados;
        }


        private void btnCompletar_Click(object sender, EventArgs e) {
            conecta = new SqlConnection(BDConnection.urlConnection);
            cmd = new SqlCommand();
            Materia materia;
            string queryInsert = "INSERT INTO MATERIA(NOME,PLATAFORMA_ESTUDO," +
                "DETALHES,FK_USUARIO,DIA,MES,HORAS,ANO) VALUES (@NOME,@PLATAFORMA_ESTUDO," +
                "@DETALHES,@FK_USUARIO,@DIA,@MES,@HORAS,@ANO)";

            try {

                conecta.Open();
                DateTime date = DateTime.Now;
                CultureInfo culture = new CultureInfo("pt-BR");
                string mes = culture.DateTimeFormat.GetMonthName(date.Month);


                id = GetID();
                cmd.Connection = conecta;
                cmd.CommandText = queryInsert;

                materia = new Materia(txtMateria.Text, date.ToShortDateString()
                    , double.Parse(txtTempoEstudado.Text), mes, txtPlataforma.Text, txtDescricao.Text);
                cmd.Parameters.AddWithValue("@NOME", materia.NomeMateria);
                cmd.Parameters.AddWithValue("@PLATAFORMA_ESTUDO", materia.Plataforma);
                cmd.Parameters.AddWithValue("@DETALHES", materia.Detalhes);
                cmd.Parameters.AddWithValue("@FK_USUARIO", id);
                cmd.Parameters.AddWithValue("@DIA", materia.Day);
                cmd.Parameters.AddWithValue("@MES", materia.Mouth);
                cmd.Parameters.AddWithValue("@HORAS", materia.Hours);
                cmd.Parameters.AddWithValue("@ANO", DateTime.Now.Year);
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
                txtTempoEstudado.Text = "";


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

                    return (int)linha["IDUSUARIO"];


                }

            } catch (Exception e) {
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

        private void btnMostrar_Click(object sender, EventArgs e) {
            lista.Rows.Clear();
            conecta = new SqlConnection(BDConnection.urlConnection);
            SqlCommand comando = new SqlCommand();
            string query = "SELECT TOP 10  NOME,DIA, MES , HORAS AS Horas_Estudadas FROM MATERIA WHERE FK_USUARIO = @ID ORDER BY IDMATERIA DESC  ";
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
                foreach (DataRow listasDados in dt.Rows) {
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

        private void btnExcluir_Click(object sender, EventArgs e) {

            string query = "DELETE FROM MATERIA WHERE IDMATERIA = @ID";
            conecta = new SqlConnection(BDConnection.urlConnection);
            cmd = new SqlCommand(query, conecta);


            try {
                conecta.Open();
                int indice = (int)lista.SelectedRows[0].Cells[0].Value;
                cmd.Parameters.AddWithValue("@ID", indice);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Dados Excluido");

            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                conecta.Close();
                cmd.Dispose();
                lista.ClearSelection();
            }

        }

        private void btnRelatorioMes_Click(object sender, EventArgs e) {
            listaRelatorio.Rows.Clear();
            string query = "SELECT \r\n    CAST(SUM(horas) AS INT) AS Horas,\r\n    CAST((SUM(horas) - CAST(SUM(horas) AS INT)) * 60 AS INT) AS Minutos,mes,ano\r\nFROM \r\n    materia\r\ngroup by mes,ano\r\n\r\n";
            using (conecta = new SqlConnection(BDConnection.urlConnection))
            using (cmd = new SqlCommand(query, conecta))
            using (SqlDataAdapter adp = new SqlDataAdapter(cmd))
                try {
                    conecta.Open();
                    DataTable tb = new DataTable();
                    adp.Fill(tb);
                    foreach (DataRow data in tb.Rows) {

                        listaRelatorio.Rows.Add(data.ItemArray);
                    }



                } catch (Exception ex) {

                } finally {
                    conecta.Close();
                }

        }

        private int GetPts() {
            try {
                BDConnection.ConectaBD();
            } catch (SqlException ex) {
                MessageBox.Show(ex.Message);
            } finally {
                BDConnection.DesconectaBD();
            }

            return 0;
        }
    }
}
