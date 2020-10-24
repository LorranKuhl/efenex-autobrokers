using Efenex.controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Efenex.view.clientes
{
    public partial class FormCliente : Form
    {
        private Cliente cliente;
        private ClientesController clientesController = new ClientesController();
        IndexClientes Index = new IndexClientes();
        public FormCliente(Cliente cliente = null)
        {
            InitializeComponent();
            if(cliente != null)
            {
                this.cliente = cliente;
                txtBoxNome.Text = cliente.Nome;
                txtBoxCpf.Text = cliente.Cpf;
                txtBoxRg.Text = cliente.Rg;
                //txtBoxDataNascimento.Value = cliente.DataNascimento;
            }
        }

        private void btnSaveCliente_Click(object sender, EventArgs e)
        {
            if (cliente == null)
            {
                Cliente cliente = new Cliente();
                cliente.Nome = txtBoxNome.Text;
                cliente.Cpf = txtBoxCpf.Text;
                cliente.Rg = txtBoxRg.Text;
                cliente.DataNascimento = txtBoxDataNascimento.Value.ToString();

                if (clientesController.Create(cliente))
                {
                    MessageBox.Show("Cliente cadastrado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro ao cadastrar o cliente.");
                }
            }
            else
            {
                cliente.Nome = txtBoxNome.Text;
                cliente.Cpf = txtBoxCpf.Text;
                cliente.Rg = txtBoxRg.Text;
                cliente.DataNascimento = txtBoxDataNascimento.Value.ToString();

                if (clientesController.Update(cliente.Id,cliente))
                {
                    MessageBox.Show("Cliente atualizado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro ao atualizar o cliente.");
                }
            }
            this.Hide();
            IndexClientes indexCliente = new IndexClientes();
            indexCliente.Show();
        }

        private void txtBoxDataNascimento_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Index.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
