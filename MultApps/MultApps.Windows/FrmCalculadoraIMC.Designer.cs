namespace MultApps.Windows
{
    partial class FrmCalculadoraIMC
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkMulher = new System.Windows.Forms.CheckBox();
            this.chkHomem = new System.Windows.Forms.CheckBox();
            this.chkCrianca = new System.Windows.Forms.CheckBox();
            this.chkAdulto = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FloralWhite;
            this.panel1.Controls.Add(this.chkMulher);
            this.panel1.Controls.Add(this.chkHomem);
            this.panel1.Controls.Add(this.chkCrianca);
            this.panel1.Controls.Add(this.chkAdulto);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 426);
            this.panel1.TabIndex = 0;
            // 
            // chkMulher
            // 
            this.chkMulher.AutoSize = true;
            this.chkMulher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMulher.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.chkMulher.Location = new System.Drawing.Point(514, 44);
            this.chkMulher.Name = "chkMulher";
            this.chkMulher.Size = new System.Drawing.Size(82, 24);
            this.chkMulher.TabIndex = 5;
            this.chkMulher.Text = "Mulher";
            this.chkMulher.UseVisualStyleBackColor = true;
            // 
            // chkHomem
            // 
            this.chkHomem.AutoSize = true;
            this.chkHomem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHomem.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.chkHomem.Location = new System.Drawing.Point(393, 44);
            this.chkHomem.Name = "chkHomem";
            this.chkHomem.Size = new System.Drawing.Size(89, 24);
            this.chkHomem.TabIndex = 4;
            this.chkHomem.Text = "Homem";
            this.chkHomem.UseVisualStyleBackColor = true;
            // 
            // chkCrianca
            // 
            this.chkCrianca.AutoSize = true;
            this.chkCrianca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCrianca.ForeColor = System.Drawing.Color.DarkGray;
            this.chkCrianca.Location = new System.Drawing.Point(143, 44);
            this.chkCrianca.Name = "chkCrianca";
            this.chkCrianca.Size = new System.Drawing.Size(89, 24);
            this.chkCrianca.TabIndex = 3;
            this.chkCrianca.Text = "Criança";
            this.chkCrianca.UseVisualStyleBackColor = true;
            this.chkCrianca.CheckedChanged += new System.EventHandler(this.chkCrianca_CheckedChanged);
            // 
            // chkAdulto
            // 
            this.chkAdulto.AutoSize = true;
            this.chkAdulto.Checked = true;
            this.chkAdulto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAdulto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAdulto.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.chkAdulto.Location = new System.Drawing.Point(22, 44);
            this.chkAdulto.Name = "chkAdulto";
            this.chkAdulto.Size = new System.Drawing.Size(80, 24);
            this.chkAdulto.TabIndex = 2;
            this.chkAdulto.Text = "Adulto";
            this.chkAdulto.UseVisualStyleBackColor = true;
            this.chkAdulto.CheckedChanged += new System.EventHandler(this.chkAdulto_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(390, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sexo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecione:";
            // 
            // FrmCalculadoraIMC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "FrmCalculadoraIMC";
            this.Text = "FrmCalculadoraIMC";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkAdulto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkMulher;
        private System.Windows.Forms.CheckBox chkHomem;
        private System.Windows.Forms.CheckBox chkCrianca;
    }
}