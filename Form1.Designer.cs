namespace GerenciadoEstudo {
    partial class Form1 {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.btnEntrar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtNomeLogin = new System.Windows.Forms.TextBox();
            this.txtIdentificadorLogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeCadastrar = new System.Windows.Forms.TextBox();
            this.txtIdentificadorCadastrar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtResultaErro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEntrar
            // 
            this.btnEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.Location = new System.Drawing.Point(151, 300);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(148, 45);
            this.btnEntrar.TabIndex = 0;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(523, 300);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(148, 45);
            this.btnCadastrar.TabIndex = 1;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtNomeLogin
            // 
            this.txtNomeLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeLogin.Location = new System.Drawing.Point(122, 161);
            this.txtNomeLogin.Name = "txtNomeLogin";
            this.txtNomeLogin.Size = new System.Drawing.Size(210, 31);
            this.txtNomeLogin.TabIndex = 2;
            // 
            // txtIdentificadorLogin
            // 
            this.txtIdentificadorLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentificadorLogin.Location = new System.Drawing.Point(122, 249);
            this.txtIdentificadorLogin.Name = "txtIdentificadorLogin";
            this.txtIdentificadorLogin.PasswordChar = '*';
            this.txtIdentificadorLogin.Size = new System.Drawing.Size(210, 31);
            this.txtIdentificadorLogin.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(122, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 36);
            this.label2.TabIndex = 5;
            this.label2.Text = "Senha";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNomeCadastrar
            // 
            this.txtNomeCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCadastrar.Location = new System.Drawing.Point(488, 161);
            this.txtNomeCadastrar.Name = "txtNomeCadastrar";
            this.txtNomeCadastrar.Size = new System.Drawing.Size(210, 31);
            this.txtNomeCadastrar.TabIndex = 6;
            // 
            // txtIdentificadorCadastrar
            // 
            this.txtIdentificadorCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentificadorCadastrar.Location = new System.Drawing.Point(488, 249);
            this.txtIdentificadorCadastrar.Name = "txtIdentificadorCadastrar";
            this.txtIdentificadorCadastrar.Size = new System.Drawing.Size(210, 31);
            this.txtIdentificadorCadastrar.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(488, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 36);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nome";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(488, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 36);
            this.label4.TabIndex = 9;
            this.label4.Text = "Senha";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(488, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(210, 36);
            this.label6.TabIndex = 11;
            this.label6.Text = "Cadastrar";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(121, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(210, 36);
            this.label7.TabIndex = 12;
            this.label7.Text = "Entrar";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtResultaErro
            // 
            this.txtResultaErro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultaErro.Location = new System.Drawing.Point(223, 477);
            this.txtResultaErro.Name = "txtResultaErro";
            this.txtResultaErro.Size = new System.Drawing.Size(417, 48);
            this.txtResultaErro.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 534);
            this.Controls.Add(this.txtResultaErro);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIdentificadorCadastrar);
            this.Controls.Add(this.txtNomeCadastrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIdentificadorLogin);
            this.Controls.Add(this.txtNomeLogin);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnEntrar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrar";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtNomeLogin;
        private System.Windows.Forms.TextBox txtIdentificadorLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeCadastrar;
        private System.Windows.Forms.TextBox txtIdentificadorCadastrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label txtResultaErro;
    }
}

