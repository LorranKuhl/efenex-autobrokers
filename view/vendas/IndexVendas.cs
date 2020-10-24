using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Efenex.view.vendas
{
    public partial class IndexVendas : Form
    {
        public IndexVendas()
        {
            InitializeComponent();
        }

        private void btnNewVenda_Click(object sender, EventArgs e)
        {
            FormVendas formVendas = new FormVendas();
            this.Hide();
            formVendas.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
