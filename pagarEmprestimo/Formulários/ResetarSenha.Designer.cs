namespace PagarEmprestimo.Formulários
{
    partial class ResetarSenha
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
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.lb_codigo = new System.Windows.Forms.Label();
            this.txt_código = new System.Windows.Forms.TextBox();
            this.btn_resetar = new System.Windows.Forms.Button();
            this.btn_verificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label1.Location = new System.Drawing.Point(43, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Resetar senha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label2.Location = new System.Drawing.Point(44, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nome";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(46, 100);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(166, 20);
            this.txt_nome.TabIndex = 8;
            // 
            // lb_codigo
            // 
            this.lb_codigo.AutoSize = true;
            this.lb_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lb_codigo.Location = new System.Drawing.Point(46, 201);
            this.lb_codigo.Name = "lb_codigo";
            this.lb_codigo.Size = new System.Drawing.Size(235, 24);
            this.lb_codigo.TabIndex = 13;
            this.lb_codigo.Text = "Código recebido via e-mail";
            this.lb_codigo.Visible = false;
            // 
            // txt_código
            // 
            this.txt_código.Location = new System.Drawing.Point(48, 225);
            this.txt_código.Name = "txt_código";
            this.txt_código.Size = new System.Drawing.Size(166, 20);
            this.txt_código.TabIndex = 12;
            this.txt_código.Visible = false;
            // 
            // btn_resetar
            // 
            this.btn_resetar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btn_resetar.Location = new System.Drawing.Point(46, 140);
            this.btn_resetar.Name = "btn_resetar";
            this.btn_resetar.Size = new System.Drawing.Size(116, 31);
            this.btn_resetar.TabIndex = 14;
            this.btn_resetar.Text = "Resetar";
            this.btn_resetar.UseVisualStyleBackColor = true;
            this.btn_resetar.Click += new System.EventHandler(this.btn_resetar_Click);
            // 
            // btn_verificar
            // 
            this.btn_verificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btn_verificar.Location = new System.Drawing.Point(46, 272);
            this.btn_verificar.Name = "btn_verificar";
            this.btn_verificar.Size = new System.Drawing.Size(116, 31);
            this.btn_verificar.TabIndex = 15;
            this.btn_verificar.Text = "Verificar";
            this.btn_verificar.UseVisualStyleBackColor = true;
            this.btn_verificar.Visible = false;
            this.btn_verificar.Click += new System.EventHandler(this.btn_verificar_Click_1);
            // 
            // ResetarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 397);
            this.Controls.Add(this.btn_verificar);
            this.Controls.Add(this.btn_resetar);
            this.Controls.Add(this.lb_codigo);
            this.Controls.Add(this.txt_código);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.label1);
            this.Name = "ResetarSenha";
            this.Text = "ResetarSenha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label lb_codigo;
        private System.Windows.Forms.TextBox txt_código;
        private System.Windows.Forms.Button btn_resetar;
        private System.Windows.Forms.Button btn_verificar;
    }
}