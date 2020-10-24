using Efenex.controller;
using Efenex.view.clientes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Efenex.view
{
    public partial class IndexClientes : Form
    {
        ClientesController ClientesController = new ClientesController();
        public IndexClientes()
        {
            InitializeComponent();
            ReloadResources();
        }

        private void BtnNewCliente_Click(object sender, EventArgs e)
        {
            FormCliente NovoClienteForm = new FormCliente();
            this.Hide();
            NovoClienteForm.Show();
            
        }

        private void listIndexClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEditCliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)listIndexClientes.SelectedItem;
            FormCliente NovoClienteForm = new FormCliente(cliente);
            this.Hide();
            NovoClienteForm.Show();
        }

        private void ReloadResources()
        {
            listIndexClientes.DataSource = ClientesController.Index;
            listIndexClientes.DisplayMember = "Nome";
            listIndexClientes.ValueMember = "Nome";
        }

        private void btnDestroyCliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)listIndexClientes.SelectedItem;
            if (ClientesController.Delete(cliente.Id))
            {
                MessageBox.Show("Cliente excluido com sucesso!");
            }
            else
            {
                MessageBox.Show("O cliente não pode ser excluido!");
            }
            ReloadResources();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IndexClientes_Load(object sender, EventArgs e)
        {

        }
    }
}
