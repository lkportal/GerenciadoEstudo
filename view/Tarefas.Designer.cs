﻿namespace GerenciadoEstudo.view {
    partial class Tarefas {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.labelNome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lv = new System.Windows.Forms.Label();
            this.btnCompletar = new System.Windows.Forms.Button();
            this.txtMateria = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.txtPlataforma = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateDay = new System.Windows.Forms.TextBox();
            this.timeHours = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lista = new System.Windows.Forms.DataGridView();
            this.NomeUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.media = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.lista)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNome
            // 
            this.labelNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(12, 9);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(63, 25);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nivel";
            // 
            // lv
            // 
            this.lv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv.Location = new System.Drawing.Point(141, 9);
            this.lv.Name = "lv";
            this.lv.Size = new System.Drawing.Size(50, 25);
            this.lv.TabIndex = 2;
            this.lv.Text = "0";
            // 
            // btnCompletar
            // 
            this.btnCompletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompletar.Location = new System.Drawing.Point(71, 384);
            this.btnCompletar.Name = "btnCompletar";
            this.btnCompletar.Size = new System.Drawing.Size(144, 37);
            this.btnCompletar.TabIndex = 3;
            this.btnCompletar.Text = "Completar";
            this.btnCompletar.UseVisualStyleBackColor = true;
            this.btnCompletar.Click += new System.EventHandler(this.btnCompletar_Click);
            // 
            // txtMateria
            // 
            this.txtMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMateria.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtMateria.Location = new System.Drawing.Point(12, 62);
            this.txtMateria.Name = "txtMateria";
            this.txtMateria.Size = new System.Drawing.Size(235, 24);
            this.txtMateria.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Materia";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Data";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(152, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Horas";
            // 
            // txtPlataforma
            // 
            this.txtPlataforma.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlataforma.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtPlataforma.Location = new System.Drawing.Point(12, 117);
            this.txtPlataforma.Name = "txtPlataforma";
            this.txtPlataforma.Size = new System.Drawing.Size(235, 24);
            this.txtPlataforma.TabIndex = 10;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtDescricao.Location = new System.Drawing.Point(16, 246);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(235, 105);
            this.txtDescricao.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(297, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Local ou Plataforma de estudo";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Descrição";
            // 
            // dateDay
            // 
            this.dateDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDay.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.dateDay.Location = new System.Drawing.Point(12, 163);
            this.dateDay.Name = "dateDay";
            this.dateDay.Size = new System.Drawing.Size(100, 24);
            this.dateDay.TabIndex = 14;
            // 
            // timeHours
            // 
            this.timeHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeHours.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.timeHours.Location = new System.Drawing.Point(136, 163);
            this.timeHours.MaxLength = 4;
            this.timeHours.Name = "timeHours";
            this.timeHours.Size = new System.Drawing.Size(100, 24);
            this.timeHours.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(488, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 37);
            this.button1.TabIndex = 16;
            this.button1.Text = "Mostrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lista
            // 
            this.lista.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomeUsuario,
            this.Mes,
            this.horas,
            this.media});
            this.lista.Location = new System.Drawing.Point(345, 19);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(443, 150);
            this.lista.TabIndex = 17;
            // 
            // NomeUsuario
            // 
            this.NomeUsuario.HeaderText = "Nome";
            this.NomeUsuario.Name = "NomeUsuario";
            // 
            // Mes
            // 
            this.Mes.HeaderText = "Mes";
            this.Mes.Name = "Mes";
            // 
            // horas
            // 
            this.horas.HeaderText = "Total_Horas";
            this.horas.Name = "horas";
            // 
            // media
            // 
            this.media.HeaderText = "Media";
            this.media.Name = "media";
            // 
            // Tarefas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.timeHours);
            this.Controls.Add(this.dateDay);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtPlataforma);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMateria);
            this.Controls.Add(this.btnCompletar);
            this.Controls.Add(this.lv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelNome);
            this.Name = "Tarefas";
            this.Text = "Tarefas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Tarefas_FormClosed);
            this.Load += new System.EventHandler(this.Tarefas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lv;
        private System.Windows.Forms.Button btnCompletar;
        private System.Windows.Forms.TextBox txtMateria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPlataforma;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox dateDay;
        private System.Windows.Forms.TextBox timeHours;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView lista;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mes;
        private System.Windows.Forms.DataGridViewTextBoxColumn horas;
        private System.Windows.Forms.DataGridViewTextBoxColumn media;
    }
}