namespace Sistema_de_Emprestimo
{
    partial class RegistrarEmprestimo
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_credor = new System.Windows.Forms.TextBox();
            this.txt_devedor = new System.Windows.Forms.TextBox();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.dtp_data = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_registrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label1.Location = new System.Drawing.Point(172, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registrar Empréstimo";
            // 
            // txt_credor
            // 
            this.txt_credor.Location = new System.Drawing.Point(39, 100);
            this.txt_credor.Name = "txt_credor";
            this.txt_credor.Size = new System.Drawing.Size(166, 20);
            this.txt_credor.TabIndex = 1;
            // 
            // txt_devedor
            // 
            this.txt_devedor.Location = new System.Drawing.Point(39, 161);
            this.txt_devedor.Name = "txt_devedor";
            this.txt_devedor.Size = new System.Drawing.Size(166, 20);
            this.txt_devedor.TabIndex = 2;
            // 
            // txt_valor
            // 
            this.txt_valor.Location = new System.Drawing.Point(39, 218);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(95, 20);
            this.txt_valor.TabIndex = 3;
            // 
            // dtp_data
            // 
            this.dtp_data.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_data.Location = new System.Drawing.Point(315, 103);
            this.dtp_data.Name = "dtp_data";
            this.dtp_data.Size = new System.Drawing.Size(106, 20);
            this.dtp_data.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label2.Location = new System.Drawing.Point(37, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome do credor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label3.Location = new System.Drawing.Point(35, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nome do devedor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label4.Location = new System.Drawing.Point(37, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Valor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label5.Location = new System.Drawing.Point(311, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Data de empréstimo";
            // 
            // txt_senha
            // 
            this.txt_senha.Location = new System.Drawing.Point(315, 164);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.Size = new System.Drawing.Size(95, 20);
            this.txt_senha.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label6.Location = new System.Drawing.Point(311, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "Senha do devedor";
            // 
            // btn_registrar
            // 
            this.btn_registrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btn_registrar.Location = new System.Drawing.Point(315, 206);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(142, 39);
            this.btn_registrar.TabIndex = 11;
            this.btn_registrar.Text = "Registrar";
            this.btn_registrar.UseVisualStyleBackColor = true;
            this.btn_registrar.Click += new System.EventHandler(this.btn_registrar_Click);
            // 
            // RegistrarEmprestimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 291);
            this.Controls.Add(this.btn_registrar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtp_data);
            this.Controls.Add(this.txt_valor);
            this.Controls.Add(this.txt_devedor);
            this.Controls.Add(this.txt_credor);
            this.Controls.Add(this.label1);
            this.Name = "RegistrarEmprestimo";
            this.Text = "RegistrarEmprestimo";
            this.Load += new System.EventHandler(this.RegistrarEmprestimo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_credor;
        private System.Windows.Forms.TextBox txt_devedor;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.DateTimePicker dtp_data;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_registrar;
    }
}