using Efenex.controller;
using Efenex.decorators;
using Efenex.model;
using Efenex.model.venda;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Efenex.view.vendas
{
    public partial class FormVendas : Form
    {
        VendasController vendasController = new VendasController();
        VendedoresController vendedoresController = new VendedoresController();
        ClientesController clientesController = new ClientesController();
        VeiculosController veiculosController = new VeiculosController();
        VeiculoDecorator veiculo => (VeiculoDecorator)lboxVeiculos.SelectedItem;
        Vendedor vendedor => (Vendedor)cboxVendedores.SelectedItem;
        Cliente cliente => (Cliente)cboxClientes.SelectedItem;
        public FormVendas()
        {
            InitializeComponent();
            LoadResources();
            FetchVeiculos();
            lboxVeiculos.DisplayMember = "Descricao";
            lboxVeiculos.ValueMember = "Descricao";
        }

        private void cboxVendedores_SelectedIndexChanged(object sender, EventArgs e) {}

        void LoadResources()
        {
            
            BindingSource vendedor = new BindingSource();
            vendedor.DataSource = vendedoresController.Index;
            cboxVendedores.DataSource = vendedor.DataSource;
            cboxVendedores.DisplayMember = "nome";
            cboxVendedores.ValueMember = "nome";

            BindingSource cliente = new BindingSource();
            cliente.DataSource = clientesController.Index;
            cboxClientes.DataSource = cliente.DataSource;
            cboxClientes.DisplayMember = "nome";
            cboxClientes.ValueMember = "nome";
            
        }

        void FetchVeiculos()
        {
            lboxVeiculos.DataSource = veiculosController.DecoratedIndex;
        }


        private void FormVendas_Load(object sender, EventArgs e) {}

        private void labelVendedores_Click(object sender, EventArgs e)
        {

        }

        private void btnVenda_Click(object sender, EventArgs e)
        {
            Venda venda = new Venda { cliente_id = cliente.Id, vendedor_id = vendedor.Id, veiculo_id=veiculo.Id };
            if (vendasController.Create(venda))
            {
                this.Close();
            } 
            else
            {
                MessageBox.Show("A Venda não pode ser concluida");
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
