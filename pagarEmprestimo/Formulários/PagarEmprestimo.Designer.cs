namespace Sistema_de_Emprestimo
{
    partial class PagarEmprestimo
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
            this.txt_credor = new System.Windows.Forms.TextBox();
            this.txt_devedor = new System.Windows.Forms.TextBox();
            this.lb_credor = new System.Windows.Forms.Label();
            this.lb_devedor = new System.Windows.Forms.Label();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_quitar = new System.Windows.Forms.Button();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.lb_senhaCredor = new System.Windows.Forms.Label();
            this.lsb_emprestimos = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_credor
            // 
            this.txt_credor.Location = new System.Drawing.Point(38, 97);
            this.txt_credor.Name = "txt_credor";
            this.txt_credor.Size = new System.Drawing.Size(179, 20);
            this.txt_credor.TabIndex = 0;
            this.txt_credor.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_devedor
            // 
            this.txt_devedor.Location = new System.Drawing.Point(38, 160);
            this.txt_devedor.Name = "txt_devedor";
            this.txt_devedor.Size = new System.Drawing.Size(179, 20);
            this.txt_devedor.TabIndex = 1;
            this.txt_devedor.TextChanged += new System.EventHandler(this.txt_devedor_TextChanged);
            // 
            // lb_credor
            // 
            this.lb_credor.AutoSize = true;
            this.lb_credor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lb_credor.Location = new System.Drawing.Point(34, 61);
            this.lb_credor.Name = "lb_credor";
            this.lb_credor.Size = new System.Drawing.Size(68, 24);
            this.lb_credor.TabIndex = 2;
            this.lb_credor.Text = "Credor";
            // 
            // lb_devedor
            // 
            this.lb_devedor.AutoSize = true;
            this.lb_devedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lb_devedor.Location = new System.Drawing.Point(34, 133);
            this.lb_devedor.Name = "lb_devedor";
            this.lb_devedor.Size = new System.Drawing.Size(82, 24);
            this.lb_devedor.TabIndex = 3;
            this.lb_devedor.Text = "Devedor";
            // 
            // btn_buscar
            // 
            this.btn_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btn_buscar.Location = new System.Drawing.Point(38, 217);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(107, 44);
            this.btn_buscar.TabIndex = 4;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // btn_quitar
            // 
            this.btn_quitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btn_quitar.Location = new System.Drawing.Point(307, 411);
            this.btn_quitar.Name = "btn_quitar";
            this.btn_quitar.Size = new System.Drawing.Size(98, 31);
            this.btn_quitar.TabIndex = 6;
            this.btn_quitar.Text = "Quitar";
            this.btn_quitar.UseVisualStyleBackColor = true;
            this.btn_quitar.Visible = false;
            this.btn_quitar.Click += new System.EventHandler(this.btn_quitar_Click);
            // 
            // txt_senha
            // 
            this.txt_senha.Location = new System.Drawing.Point(585, 415);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.Size = new System.Drawing.Size(179, 20);
            this.txt_senha.TabIndex = 7;
            this.txt_senha.Visible = false;
            // 
            // lb_senhaCredor
            // 
            this.lb_senhaCredor.AutoSize = true;
            this.lb_senhaCredor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lb_senhaCredor.Location = new System.Drawing.Point(447, 415);
            this.lb_senhaCredor.Name = "lb_senhaCredor";
            this.lb_senhaCredor.Size = new System.Drawing.Size(132, 20);
            this.lb_senhaCredor.TabIndex = 8;
            this.lb_senhaCredor.Text = "Senha do credor";
            this.lb_senhaCredor.Visible = false;
            this.lb_senhaCredor.Click += new System.EventHandler(this.label1_Click);
            // 
            // lsb_emprestimos
            // 
            this.lsb_emprestimos.FormattingEnabled = true;
            this.lsb_emprestimos.Location = new System.Drawing.Point(307, 49);
            this.lsb_emprestimos.Name = "lsb_emprestimos";
            this.lsb_emprestimos.Size = new System.Drawing.Size(457, 355);
            this.lsb_emprestimos.TabIndex = 9;
            this.lsb_emprestimos.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label1.Location = new System.Drawing.Point(34, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "Pagar Empréstimo";
            // 
            // PagarEmprestimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lsb_emprestimos);
            this.Controls.Add(this.lb_senhaCredor);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.btn_quitar);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.lb_devedor);
            this.Controls.Add(this.lb_credor);
            this.Controls.Add(this.txt_devedor);
            this.Controls.Add(this.txt_credor);
            this.Name = "PagarEmprestimo";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_credor;
        private System.Windows.Forms.TextBox txt_devedor;
        private System.Windows.Forms.Label lb_credor;
        private System.Windows.Forms.Label lb_devedor;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_quitar;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.Label lb_senhaCredor;
        private System.Windows.Forms.ListBox lsb_emprestimos;
        private System.Windows.Forms.Label label1;
    }
}

