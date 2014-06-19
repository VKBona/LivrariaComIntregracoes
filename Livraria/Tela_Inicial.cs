using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Livraria
{
    public partial class FormTelaInicial : Form
    {
        public FormTelaInicial()
        {
            InitializeComponent();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            FormCliente cliente = new FormCliente();
            cliente.Show();
        }

        private void btnLivros_Click(object sender, EventArgs e)
        {
            FormLivro cliente = new FormLivro();
            cliente.Show();
        }

        private void btnExecutarVenda_Click(object sender, EventArgs e)
        {
            FormVenda venda = new FormVenda();
            venda.Show();
        }

    }
}
