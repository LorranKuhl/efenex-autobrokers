namespace Efenex
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnClientes = new System.Windows.Forms.Button();
            this.BtnVeiculos = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnVendas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnClientes
            // 
            this.BtnClientes.Location = new System.Drawing.Point(562, 293);
            this.BtnClientes.Name = "BtnClientes";
            this.BtnClientes.Size = new System.Drawing.Size(91, 29);
            this.BtnClientes.TabIndex = 0;
            this.BtnClientes.Text = "Clientes";
            this.BtnClientes.UseVisualStyleBackColor = true;
            this.BtnClientes.Click += new System.EventHandler(this.BtnClientes_Click);
            // 
            // BtnVeiculos
            // 
            this.BtnVeiculos.Location = new System.Drawing.Point(269, 71);
            this.BtnVeiculos.Name = "BtnVeiculos";
            this.BtnVeiculos.Size = new System.Drawing.Size(75, 23);
            this.BtnVeiculos.TabIndex = 1;
            this.BtnVeiculos.Text = "Veiculos";
            this.BtnVeiculos.UseVisualStyleBackColor = true;
            this.BtnVeiculos.Click += new System.EventHandler(this.BtnVeiculos_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(156, 304);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(81, 41);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnVendas
            // 
            this.btnVendas.Location = new System.Drawing.Point(546, 71);
            this.btnVendas.Name = "btnVendas";
            this.btnVendas.Size = new System.Drawing.Size(88, 29);
            this.btnVendas.TabIndex = 3;
            this.btnVendas.Text = "Vendas";
            this.btnVendas.UseVisualStyleBackColor = true;
            this.btnVendas.Click += new System.EventHandler(this.btnVendas_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVendas);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.BtnVeiculos);
            this.Controls.Add(this.BtnClientes);
            this.Name = "Main";
            this.Text = "Efenex AutoBrokers";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnClientes;
        private System.Windows.Forms.Button BtnVeiculos;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnVendas;
    }
}

