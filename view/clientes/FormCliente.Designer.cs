namespace Efenex.view.clientes
{
    partial class FormCliente
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
            this.txtBoxNome = new System.Windows.Forms.TextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.txtBoxCpf = new System.Windows.Forms.TextBox();
            this.txtBoxRg = new System.Windows.Forms.TextBox();
            this.labelCpf = new System.Windows.Forms.Label();
            this.labelRg = new System.Windows.Forms.Label();
            this.txtBoxDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.labelDataNascimento = new System.Windows.Forms.Label();
            this.btnSaveCliente = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxNome
            // 
            this.txtBoxNome.Location = new System.Drawing.Point(85, 91);
            this.txtBoxNome.Name = "txtBoxNome";
            this.txtBoxNome.Size = new System.Drawing.Size(100, 23);
            this.txtBoxNome.TabIndex = 0;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(119, 73);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(40, 15);
            this.labelNome.TabIndex = 1;
            this.labelNome.Text = "Nome";
            // 
            // txtBoxCpf
            // 
            this.txtBoxCpf.Location = new System.Drawing.Point(325, 90);
            this.txtBoxCpf.Name = "txtBoxCpf";
            this.txtBoxCpf.Size = new System.Drawing.Size(100, 23);
            this.txtBoxCpf.TabIndex = 2;
            // 
            // txtBoxRg
            // 
            this.txtBoxRg.Location = new System.Drawing.Point(593, 90);
            this.txtBoxRg.Name = "txtBoxRg";
            this.txtBoxRg.Size = new System.Drawing.Size(100, 23);
            this.txtBoxRg.TabIndex = 3;
            // 
            // labelCpf
            // 
            this.labelCpf.AutoSize = true;
            this.labelCpf.Location = new System.Drawing.Point(351, 64);
            this.labelCpf.Name = "labelCpf";
            this.labelCpf.Size = new System.Drawing.Size(28, 15);
            this.labelCpf.TabIndex = 4;
            this.labelCpf.Text = "CPF";
            // 
            // labelRg
            // 
            this.labelRg.AutoSize = true;
            this.labelRg.Location = new System.Drawing.Point(618, 61);
            this.labelRg.Name = "labelRg";
            this.labelRg.Size = new System.Drawing.Size(22, 15);
            this.labelRg.TabIndex = 5;
            this.labelRg.Text = "RG";
            // 
            // txtBoxDataNascimento
            // 
            this.txtBoxDataNascimento.Location = new System.Drawing.Point(290, 213);
            this.txtBoxDataNascimento.Name = "txtBoxDataNascimento";
            this.txtBoxDataNascimento.Size = new System.Drawing.Size(200, 23);
            this.txtBoxDataNascimento.TabIndex = 7;
            this.txtBoxDataNascimento.ValueChanged += new System.EventHandler(this.txtBoxDataNascimento_ValueChanged);
            // 
            // labelDataNascimento
            // 
            this.labelDataNascimento.AutoSize = true;
            this.labelDataNascimento.Location = new System.Drawing.Point(325, 195);
            this.labelDataNascimento.Name = "labelDataNascimento";
            this.labelDataNascimento.Size = new System.Drawing.Size(114, 15);
            this.labelDataNascimento.TabIndex = 8;
            this.labelDataNascimento.Text = "Data de Nascimento";
            // 
            // btnSaveCliente
            // 
            this.btnSaveCliente.Location = new System.Drawing.Point(315, 338);
            this.btnSaveCliente.Name = "btnSaveCliente";
            this.btnSaveCliente.Size = new System.Drawing.Size(75, 23);
            this.btnSaveCliente.TabIndex = 9;
            this.btnSaveCliente.Text = "Salvar";
            this.btnSaveCliente.UseVisualStyleBackColor = true;
            this.btnSaveCliente.Click += new System.EventHandler(this.btnSaveCliente_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(45, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 41);
            this.button1.TabIndex = 2;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // FormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSaveCliente);
            this.Controls.Add(this.labelDataNascimento);
            this.Controls.Add(this.txtBoxDataNascimento);
            this.Controls.Add(this.labelRg);
            this.Controls.Add(this.labelCpf);
            this.Controls.Add(this.txtBoxRg);
            this.Controls.Add(this.txtBoxCpf);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.txtBoxNome);
            this.Name = "FormCliente";
            this.Text = "Cadastro - Novo Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxNome;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.TextBox txtBoxCpf;
        private System.Windows.Forms.TextBox txtBoxRg;
        private System.Windows.Forms.Label labelCpf;
        private System.Windows.Forms.Label labelRg;
        private System.Windows.Forms.DateTimePicker txtBoxDataNascimento;
        private System.Windows.Forms.Label labelDataNascimento;
        private System.Windows.Forms.Button btnSaveCliente;
        private System.Windows.Forms.Button button1;
    }
}