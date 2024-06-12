namespace GerenciadoEstudo.view {
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
            this.labelNome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lv = new System.Windows.Forms.Label();
            this.btnCompletar = new System.Windows.Forms.Button();
            this.txtMateria = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPlataforma = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.lista = new System.Windows.Forms.DataGridView();
            this.labelVolta = new System.Windows.Forms.Label();
            this.txtTempoEstudado = new System.Windows.Forms.MaskedTextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.listaRelatorio = new System.Windows.Forms.DataGridView();
            this.mesEstudado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horasEstudadas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRelatorioMes = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Rotinas = new System.Windows.Forms.TabPage();
            this.Informaçoes = new System.Windows.Forms.TabPage();
            this.NomeUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.lista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaRelatorio)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.Rotinas.SuspendLayout();
            this.Informaçoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNome
            // 
            this.labelNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(12, 20);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(63, 25);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nivel";
            // 
            // lv
            // 
            this.lv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv.Location = new System.Drawing.Point(141, 20);
            this.lv.Name = "lv";
            this.lv.Size = new System.Drawing.Size(50, 25);
            this.lv.TabIndex = 2;
            this.lv.Text = "0";
            // 
            // btnCompletar
            // 
            this.btnCompletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompletar.Location = new System.Drawing.Point(324, 411);
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
            this.txtMateria.Location = new System.Drawing.Point(274, 41);
            this.txtMateria.Name = "txtMateria";
            this.txtMateria.Size = new System.Drawing.Size(235, 24);
            this.txtMateria.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(352, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Materia";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(310, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tempo Estudado";
            // 
            // txtPlataforma
            // 
            this.txtPlataforma.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlataforma.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtPlataforma.Location = new System.Drawing.Point(274, 113);
            this.txtPlataforma.Name = "txtPlataforma";
            this.txtPlataforma.Size = new System.Drawing.Size(235, 24);
            this.txtPlataforma.TabIndex = 10;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtDescricao.Location = new System.Drawing.Point(274, 265);
            this.txtDescricao.MaxLength = 100;
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(235, 105);
            this.txtDescricao.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(248, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(297, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Local ou Plataforma de estudo";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(336, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Descrição";
            // 
            // btnMostrar
            // 
            this.btnMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.Location = new System.Drawing.Point(198, 231);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(86, 26);
            this.btnMostrar.TabIndex = 16;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // lista
            // 
            this.lista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.lista.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lista.ColumnHeadersHeight = 30;
            this.lista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomeUsuario,
            this.data,
            this.Mes,
            this.horas});
            this.lista.Dock = System.Windows.Forms.DockStyle.Top;
            this.lista.Location = new System.Drawing.Point(3, 3);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(786, 222);
            this.lista.TabIndex = 17;
            // 
            // labelVolta
            // 
            this.labelVolta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVolta.Location = new System.Drawing.Point(716, 9);
            this.labelVolta.Name = "labelVolta";
            this.labelVolta.Size = new System.Drawing.Size(72, 39);
            this.labelVolta.TabIndex = 19;
            this.labelVolta.Text = "Volta";
            this.labelVolta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelVolta.Click += new System.EventHandler(this.labelVolta_Click);
            // 
            // txtTempoEstudado
            // 
            this.txtTempoEstudado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTempoEstudado.Location = new System.Drawing.Point(356, 193);
            this.txtTempoEstudado.Mask = "00.00";
            this.txtTempoEstudado.Name = "txtTempoEstudado";
            this.txtTempoEstudado.Size = new System.Drawing.Size(52, 29);
            this.txtTempoEstudado.TabIndex = 20;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(534, 231);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(80, 26);
            this.btnExcluir.TabIndex = 21;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // listaRelatorio
            // 
            this.listaRelatorio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listaRelatorio.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.listaRelatorio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaRelatorio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mesEstudado,
            this.ano,
            this.horasEstudadas});
            this.listaRelatorio.Location = new System.Drawing.Point(421, 281);
            this.listaRelatorio.Name = "listaRelatorio";
            this.listaRelatorio.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.listaRelatorio.Size = new System.Drawing.Size(363, 170);
            this.listaRelatorio.TabIndex = 23;
            // 
            // mesEstudado
            // 
            this.mesEstudado.HeaderText = "Mes";
            this.mesEstudado.Name = "mesEstudado";
            // 
            // ano
            // 
            this.ano.HeaderText = "Ano";
            this.ano.Name = "ano";
            // 
            // horasEstudadas
            // 
            this.horasEstudadas.HeaderText = "HorasTotais";
            this.horasEstudadas.Name = "horasEstudadas";
            // 
            // btnRelatorioMes
            // 
            this.btnRelatorioMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorioMes.Location = new System.Drawing.Point(569, 467);
            this.btnRelatorioMes.Name = "btnRelatorioMes";
            this.btnRelatorioMes.Size = new System.Drawing.Size(86, 26);
            this.btnRelatorioMes.TabIndex = 25;
            this.btnRelatorioMes.Text = "Mostrar";
            this.btnRelatorioMes.UseVisualStyleBackColor = true;
            this.btnRelatorioMes.Click += new System.EventHandler(this.btnRelatorioMes_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Rotinas);
            this.tabControl1.Controls.Add(this.Informaçoes);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 51);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 532);
            this.tabControl1.TabIndex = 26;
            // 
            // Rotinas
            // 
            this.Rotinas.Controls.Add(this.label4);
            this.Rotinas.Controls.Add(this.txtMateria);
            this.Rotinas.Controls.Add(this.label3);
            this.Rotinas.Controls.Add(this.txtPlataforma);
            this.Rotinas.Controls.Add(this.label6);
            this.Rotinas.Controls.Add(this.txtTempoEstudado);
            this.Rotinas.Controls.Add(this.label7);
            this.Rotinas.Controls.Add(this.txtDescricao);
            this.Rotinas.Controls.Add(this.btnCompletar);
            this.Rotinas.Location = new System.Drawing.Point(4, 25);
            this.Rotinas.Name = "Rotinas";
            this.Rotinas.Padding = new System.Windows.Forms.Padding(3);
            this.Rotinas.Size = new System.Drawing.Size(792, 503);
            this.Rotinas.TabIndex = 0;
            this.Rotinas.Text = "Rotinas";
            this.Rotinas.UseVisualStyleBackColor = true;
            // 
            // Informaçoes
            // 
            this.Informaçoes.Controls.Add(this.btnExcluir);
            this.Informaçoes.Controls.Add(this.btnRelatorioMes);
            this.Informaçoes.Controls.Add(this.lista);
            this.Informaçoes.Controls.Add(this.btnMostrar);
            this.Informaçoes.Controls.Add(this.listaRelatorio);
            this.Informaçoes.Location = new System.Drawing.Point(4, 25);
            this.Informaçoes.Name = "Informaçoes";
            this.Informaçoes.Padding = new System.Windows.Forms.Padding(3);
            this.Informaçoes.Size = new System.Drawing.Size(792, 503);
            this.Informaçoes.TabIndex = 1;
            this.Informaçoes.Text = "Informaçoes";
            this.Informaçoes.UseVisualStyleBackColor = true;
            // 
            // NomeUsuario
            // 
            this.NomeUsuario.HeaderText = "Nome";
            this.NomeUsuario.Name = "NomeUsuario";
            // 
            // data
            // 
            this.data.HeaderText = "Data";
            this.data.Name = "data";
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
            // Tarefas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 583);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.labelVolta);
            this.Controls.Add(this.lv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelNome);
            this.Name = "Tarefas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tarefas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Tarefas_FormClosed);
            this.Load += new System.EventHandler(this.Tarefas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaRelatorio)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.Rotinas.ResumeLayout(false);
            this.Rotinas.PerformLayout();
            this.Informaçoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lv;
        private System.Windows.Forms.Button btnCompletar;
        private System.Windows.Forms.TextBox txtMateria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPlataforma;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.DataGridView lista;
        private System.Windows.Forms.Label labelVolta;
        private System.Windows.Forms.MaskedTextBox txtTempoEstudado;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DataGridView listaRelatorio;
        private System.Windows.Forms.Button btnRelatorioMes;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesEstudado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ano;
        private System.Windows.Forms.DataGridViewTextBoxColumn horasEstudadas;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Rotinas;
        private System.Windows.Forms.TabPage Informaçoes;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mes;
        private System.Windows.Forms.DataGridViewTextBoxColumn horas;
    }
}