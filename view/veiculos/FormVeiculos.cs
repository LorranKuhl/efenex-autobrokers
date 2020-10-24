using Efenex.controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Efenex.view.veiculos
{
    public partial class FormVeiculos : Form
    {
        private Veiculo veiculo;
        private VeiculosController veiculocontroller = new VeiculosController();
        public FormVeiculos(Veiculo veiculo = null)
        {
            InitializeComponent();
            if(veiculo != null)
            {
                this.veiculo = veiculo;
                txtMarca.Text = veiculo.Marca;
                txtAno.Text = veiculo.Ano.ToString();
                txtModelo.Text = veiculo.Modelo;
                txtPlaca.Text = veiculo.Placa;
                txtTipo.Text = veiculo.Tipo;
                txtValor.Text = veiculo.Valor.ToString();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (veiculo == null)
            {
                Veiculo veiculo = new Veiculo();
                veiculo.Marca = txtMarca.Text;
                veiculo.Ano = int.Parse(txtAno.Text);
                veiculo.Modelo = txtModelo.Text;
                veiculo.Placa = txtPlaca.Text;
                veiculo.Tipo = txtTipo.Text;
                veiculo.Valor = int.Parse(txtValor.Text);

                if(veiculocontroller.Create(veiculo))
                {
                    MessageBox.Show("Veiculo cadastrado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Erro no cadastro do veiculo");
                }
            }
            else
            {
                veiculo.Marca = txtMarca.Text;
                veiculo.Ano = int.Parse(txtAno.Text);
                veiculo.Modelo = txtModelo.Text;
                veiculo.Placa = txtPlaca.Text;
                veiculo.Tipo = txtTipo.Text;
                veiculo.Valor = int.Parse(txtValor.Text);

                if(veiculocontroller.Update(veiculo.Id,veiculo))
                {
                    MessageBox.Show("Veiculo atualizado");
                }
                else
                {
                    MessageBox.Show("Erro ao atualizar veiculo");
                }
            }
            IndexVeiculos Index = new IndexVeiculos();
            this.Hide();
            Index.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
