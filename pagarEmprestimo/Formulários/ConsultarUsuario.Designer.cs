namespace Sistema_de_Emprestimo
{
    partial class ConsultarUsuario
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
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.lsb_usuario = new System.Windows.Forms.ListBox();
            this.lb_nomeUsuario = new System.Windows.Forms.Label();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label1.Location = new System.Drawing.Point(294, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Consultar Usuário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label2.Location = new System.Drawing.Point(33, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nome do usuário";
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(35, 101);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(166, 20);
            this.txt_usuario.TabIndex = 6;
            // 
            // lsb_usuario
            // 
            this.lsb_usuario.FormattingEnabled = true;
            this.lsb_usuario.Location = new System.Drawing.Point(277, 138);
            this.lsb_usuario.Name = "lsb_usuario";
            this.lsb_usuario.Size = new System.Drawing.Size(500, 290);
            this.lsb_usuario.TabIndex = 8;
            this.lsb_usuario.Visible = false;
            // 
            // lb_nomeUsuario
            // 
            this.lb_nomeUsuario.AutoSize = true;
            this.lb_nomeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lb_nomeUsuario.Location = new System.Drawing.Point(273, 101);
            this.lb_nomeUsuario.Name = "lb_nomeUsuario";
            this.lb_nomeUsuario.Size = new System.Drawing.Size(0, 24);
            this.lb_nomeUsuario.TabIndex = 9;
            this.lb_nomeUsuario.Visible = false;
            // 
            // btn_consultar
            // 
            this.btn_consultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btn_consultar.Location = new System.Drawing.Point(37, 138);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(142, 39);
            this.btn_consultar.TabIndex = 12;
            this.btn_consultar.Text = "Consultar";
            this.btn_consultar.UseVisualStyleBackColor = true;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // ConsultarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_consultar);
            this.Controls.Add(this.lb_nomeUsuario);
            this.Controls.Add(this.lsb_usuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.label1);
            this.Name = "ConsultarUsuario";
            this.Text = "Consultar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.ListBox lsb_usuario;
        private System.Windows.Forms.Label lb_nomeUsuario;
        private System.Windows.Forms.Button btn_consultar;
    }
}