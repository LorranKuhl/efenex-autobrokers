namespace Efenex.view
{
    partial class IndexClientes
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
            this.BtnNewCliente = new System.Windows.Forms.Button();
            this.listIndexClientes = new System.Windows.Forms.ListBox();
            this.btnEditCliente = new System.Windows.Forms.Button();
            this.btnDestroyCliente = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnNewCliente
            // 
            this.BtnNewCliente.Location = new System.Drawing.Point(111, 201);
            this.BtnNewCliente.Name = "BtnNewCliente";
            this.BtnNewCliente.Size = new System.Drawing.Size(118, 23);
            this.BtnNewCliente.TabIndex = 0;
            this.BtnNewCliente.Text = "Novo Cliente";
            this.BtnNewCliente.UseVisualStyleBackColor = true;
            this.BtnNewCliente.Click += new System.EventHandler(this.BtnNewCliente_Click);
            // 
            // listIndexClientes
            // 
            this.listIndexClientes.FormattingEnabled = true;
            this.listIndexClientes.ItemHeight = 15;
            this.listIndexClientes.Location = new System.Drawing.Point(328, 61);
            this.listIndexClientes.Name = "listIndexClientes";
            this.listIndexClientes.Size = new System.Drawing.Size(397, 289);
            this.listIndexClientes.TabIndex = 1;
            this.listIndexClientes.SelectedIndexChanged += new System.EventHandler(this.listIndexClientes_SelectedIndexChanged);
            // 
            // btnEditCliente
            // 
            this.btnEditCliente.Location = new System.Drawing.Point(111, 251);
            this.btnEditCliente.Name = "btnEditCliente";
            this.btnEditCliente.Size = new System.Drawing.Size(118, 23);
            this.btnEditCliente.TabIndex = 2;
            this.btnEditCliente.Text = "Editar Cliente";
            this.btnEditCliente.UseVisualStyleBackColor = true;
            this.btnEditCliente.Click += new System.EventHandler(this.btnEditCliente_Click);
            // 
            // btnDestroyCliente
            // 
            this.btnDestroyCliente.Location = new System.Drawing.Point(111, 296);
            this.btnDestroyCliente.Name = "btnDestroyCliente";
            this.btnDestroyCliente.Size = new System.Drawing.Size(118, 23);
            this.btnDestroyCliente.TabIndex = 3;
            this.btnDestroyCliente.Text = "Excluir Cliente";
            this.btnDestroyCliente.UseVisualStyleBackColor = true;
            this.btnDestroyCliente.Click += new System.EventHandler(this.btnDestroyCliente_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 426);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 41);
            this.button1.TabIndex = 2;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // IndexClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 501);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDestroyCliente);
            this.Controls.Add(this.btnEditCliente);
            this.Controls.Add(this.listIndexClientes);
            this.Controls.Add(this.BtnNewCliente);
            this.Name = "IndexClientes";
            this.Text = "Efenex - Clientes";
            this.Load += new System.EventHandler(this.IndexClientes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnNewCliente;
        private System.Windows.Forms.ListBox listIndexClientes;
        private System.Windows.Forms.Button btnEditCliente;
        private System.Windows.Forms.Button btnDestroyCliente;
        private System.Windows.Forms.Button button1;
    }
}