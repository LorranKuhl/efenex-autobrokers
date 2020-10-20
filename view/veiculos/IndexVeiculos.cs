﻿using Efenex.controller;
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
        VeiculosController VeiculosController = new VeiculosController();
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
            Veiculo veiculo = (Veiculo)listVeiculos.SelectedItem;
            FormVeiculos NovoVeiculoForm = new FormVeiculos(veiculo);
            this.Hide();
            NovoVeiculoForm.Show();
        }

        public void ReloadResources()
        {
            listVeiculos.DataSource = VeiculosController.Index;
            listVeiculos.DisplayMember = "Descricao";
            listVeiculos.ValueMember = "Descricao";
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Veiculo veiculo = (Veiculo)listVeiculos.SelectedItem;
            if(VeiculosController.Delete(veiculo.Id))
            {
                MessageBox.Show("Veiculo excluido com sucesso");
            }
            else
            {
                MessageBox.Show("Veiculo não pode ser deletado");
            }
            ReloadResources();
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
