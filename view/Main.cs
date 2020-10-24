using Efenex.view;
using Efenex.view.veiculos;
using Efenex.view.vendas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Efenex
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            IndexClientes Index = new IndexClientes();
            Index.Show();
        }

        private void BtnVeiculos_Click(object sender, EventArgs e)
        {
            IndexVeiculos Index = new IndexVeiculos();
            Index.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            IndexVendas Vendas = new IndexVendas();
            Vendas.Show();
        }
    }
}
