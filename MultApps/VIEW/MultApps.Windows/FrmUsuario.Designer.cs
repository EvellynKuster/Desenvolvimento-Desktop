namespace MultApps.Windows
{
    partial class FrmUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.groupBoxCadastrarCategoria = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblCpf = new System.Windows.Forms.Label();
            this.maskedCpf = new System.Windows.Forms.MaskedTextBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.txtDataAlteracao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDataCriacao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbFiltro = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxCadastrarCategoria.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Wheat;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(491, 294);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(538, 369);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FloralWhite;
            this.btnLimpar.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnLimpar.Location = new System.Drawing.Point(208, 537);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(95, 30);
            this.btnLimpar.TabIndex = 20;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // groupBoxCadastrarCategoria
            // 
            this.groupBoxCadastrarCategoria.BackColor = System.Drawing.Color.Wheat;
            this.groupBoxCadastrarCategoria.Controls.Add(this.label8);
            this.groupBoxCadastrarCategoria.Controls.Add(this.txtSenha);
            this.groupBoxCadastrarCategoria.Controls.Add(this.lblEmail);
            this.groupBoxCadastrarCategoria.Controls.Add(this.btnLimpar);
            this.groupBoxCadastrarCategoria.Controls.Add(this.txtEmail);
            this.groupBoxCadastrarCategoria.Controls.Add(this.btnDeletar);
            this.groupBoxCadastrarCategoria.Controls.Add(this.btnSalvar);
            this.groupBoxCadastrarCategoria.Controls.Add(this.lblCpf);
            this.groupBoxCadastrarCategoria.Controls.Add(this.maskedCpf);
            this.groupBoxCadastrarCategoria.Controls.Add(this.cmbStatus);
            this.groupBoxCadastrarCategoria.Controls.Add(this.txtDataAlteracao);
            this.groupBoxCadastrarCategoria.Controls.Add(this.label2);
            this.groupBoxCadastrarCategoria.Controls.Add(this.txtNome);
            this.groupBoxCadastrarCategoria.Controls.Add(this.txtId);
            this.groupBoxCadastrarCategoria.Controls.Add(this.label7);
            this.groupBoxCadastrarCategoria.Controls.Add(this.label3);
            this.groupBoxCadastrarCategoria.Controls.Add(this.txtDataCriacao);
            this.groupBoxCadastrarCategoria.Controls.Add(this.label5);
            this.groupBoxCadastrarCategoria.Controls.Add(this.label6);
            this.groupBoxCadastrarCategoria.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCadastrarCategoria.Location = new System.Drawing.Point(12, 59);
            this.groupBoxCadastrarCategoria.Name = "groupBoxCadastrarCategoria";
            this.groupBoxCadastrarCategoria.Size = new System.Drawing.Size(463, 604);
            this.groupBoxCadastrarCategoria.TabIndex = 18;
            this.groupBoxCadastrarCategoria.TabStop = false;
            this.groupBoxCadastrarCategoria.Text = "Cadastrar novo usuário";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(261, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 19);
            this.label8.TabIndex = 23;
            this.label8.Text = "Senha";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(261, 203);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(153, 26);
            this.txtSenha.TabIndex = 22;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(34, 181);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 19);
            this.lblEmail.TabIndex = 21;
            this.lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(38, 203);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(153, 26);
            this.txtEmail.TabIndex = 20;
            // 
            // btnDeletar
            // 
            this.btnDeletar.BackColor = System.Drawing.Color.FloralWhite;
            this.btnDeletar.Enabled = false;
            this.btnDeletar.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnDeletar.Location = new System.Drawing.Point(96, 537);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(95, 30);
            this.btnDeletar.TabIndex = 17;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = false;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Goldenrod;
            this.btnSalvar.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnSalvar.Location = new System.Drawing.Point(319, 527);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(95, 40);
            this.btnSalvar.TabIndex = 14;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.Location = new System.Drawing.Point(261, 30);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(38, 19);
            this.lblCpf.TabIndex = 19;
            this.lblCpf.Text = "CPF";
            // 
            // maskedCpf
            // 
            this.maskedCpf.Location = new System.Drawing.Point(261, 52);
            this.maskedCpf.Mask = "000.000.000-00";
            this.maskedCpf.Name = "maskedCpf";
            this.maskedCpf.Size = new System.Drawing.Size(153, 26);
            this.maskedCpf.TabIndex = 18;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Inativo",
            "Ativo"});
            this.cmbStatus.Location = new System.Drawing.Point(261, 123);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(153, 27);
            this.cmbStatus.TabIndex = 13;
            // 
            // txtDataAlteracao
            // 
            this.txtDataAlteracao.Enabled = false;
            this.txtDataAlteracao.Location = new System.Drawing.Point(265, 282);
            this.txtDataAlteracao.Name = "txtDataAlteracao";
            this.txtDataAlteracao.Size = new System.Drawing.Size(149, 26);
            this.txtDataAlteracao.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label2.Location = new System.Drawing.Point(34, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(38, 123);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(153, 26);
            this.txtNome.TabIndex = 12;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(38, 52);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(153, 26);
            this.txtId.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(34, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 19);
            this.label7.TabIndex = 11;
            this.label7.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(261, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Status";
            // 
            // txtDataCriacao
            // 
            this.txtDataCriacao.Enabled = false;
            this.txtDataCriacao.Location = new System.Drawing.Point(38, 282);
            this.txtDataCriacao.Name = "txtDataCriacao";
            this.txtDataCriacao.Size = new System.Drawing.Size(153, 26);
            this.txtDataCriacao.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label5.Location = new System.Drawing.Point(261, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Data do ultimo acesso";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label6.Location = new System.Drawing.Point(34, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "Data de criação";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 31);
            this.label1.TabIndex = 17;
            this.label1.Text = "Cadastros de usuários";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label4.Location = new System.Drawing.Point(585, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(355, 55);
            this.label4.TabIndex = 20;
            this.label4.Text = "Seja bem vindo!";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Goldenrod;
            this.label9.Location = new System.Drawing.Point(620, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(276, 108);
            this.label9.TabIndex = 21;
            this.label9.Text = "Cadastre-se no nosso\r\n     aplicativo para\r\n  muitos benefícios!";
            // 
            // cmbFiltro
            // 
            this.cmbFiltro.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFiltro.FormattingEnabled = true;
            this.cmbFiltro.Items.AddRange(new object[] {
            "Inativo",
            "Ativo",
            "Todos"});
            this.cmbFiltro.Location = new System.Drawing.Point(876, 271);
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.Size = new System.Drawing.Size(153, 29);
            this.cmbFiltro.TabIndex = 24;
            this.cmbFiltro.Text = "Filtro";
            this.cmbFiltro.SelectedIndexChanged += new System.EventHandler(this.cmbFiltro_SelectedIndexChanged);
            // 
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1041, 675);
            this.Controls.Add(this.cmbFiltro);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBoxCadastrarCategoria);
            this.Controls.Add(this.label1);
            this.Name = "FrmUsuario";
            this.Text = "FrmUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxCadastrarCategoria.ResumeLayout(false);
            this.groupBoxCadastrarCategoria.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.GroupBox groupBoxCadastrarCategoria;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtDataAlteracao;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDataCriacao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedCpf;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbFiltro;
    }
}