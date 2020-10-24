using Efenex.controller;
using Efenex.decorators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Efenex.view.veiculos
{
    public partial class IndexVeiculos : Form
    {
        VeiculosController veiculosController = new VeiculosController();
 
        public IndexVeiculos()
        {
            InitializeComponent();
            ReloadResources();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FormVeiculos NovoVeiculoForm = new FormVeiculos();
            this.Hide();
            NovoVeiculoForm.Show();
            ReloadResources();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FormVeiculos NovoVeiculoForm = new FormVeiculos(veiculo);
            this.Hide();
            NovoVeiculoForm.Show();
        }

        public void ReloadResources()
        {
            
            listVeiculos.DataSource = veiculosController.DecoratedIndex;
            listVeiculos.DisplayMember = "Descricao";
            listVeiculos.ValueMember = "Descricao";
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Veiculo veiculo = (Veiculo)listVeiculos.SelectedItem;
            if(veiculosController.Delete(veiculo.Id))
            {
                MessageBox.Show("Veiculo excluido com sucesso");
            }
            else
            {
                MessageBox.Show("Veiculo não pode ser deletado");
            }
            ReloadResources();
        }

        Veiculo veiculo
        {
            get 
            {
                var item = (VeiculoDecorator)listVeiculos.SelectedItem;
                return veiculosController.Index.Find(veiculo => veiculo.Id == item.Id);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listVeiculos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
