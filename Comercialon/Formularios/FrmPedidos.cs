using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Comercialon.Classes;

namespace Comercialon.Formularios
{
    public partial class FrmPedidos : Form
    {
        public FrmPedidos()
        {
            InitializeComponent();
        }

        private void FrmPedidos_Load(object sender, EventArgs e)
        {
            var clientes = Cliente.ListarTodos();
            cmbClientes.DataSource = clientes;
            cmbClientes.DisplayMember = "Nome";
            cmbClientes.ValueMember = "Id";

        }

        private void cmbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIdUsuario.Text = cmbClientes.SelectedValue.ToString();
        }
    }
}
