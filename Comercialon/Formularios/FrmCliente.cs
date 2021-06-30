using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Comercialon.Classes;

namespace Comercialon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btnInserir_Click(object sender, EventArgs e)
        {
            // essa linha a seguir remove pontos e traços do cpf
            mskCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            Cliente cliente = new Cliente(
              txtNome.Text,
              mskCpf.Text,
              txtEmail.Text,
              txtTelefone.Text
          );
            cliente.Inserir();
            Endereco endereco = new Endereco
                (txtLogradouro.Text, txtNumero.Text, txtComplemento.Text
                , txtCep.Text, txtBairro.Text, txtCidade.Text, cmbTipo.Text,
                txtEstado.Text, txtUf.Text);
            endereco.Inserir(cliente.Id);
            txtID.Text = cliente.Id.ToString();
            MessageBox.Show("Cliente " + cliente.Id + " inserido.");
            LimpaCampos();
            btnListar_Click(sender, e);

        }
        private void LimpaCampos() 
        {
            txtID.Clear();
            txtNome.Clear();
            mskCpf.Clear();
            txtEmail.Clear();
            txtTelefone.Clear();
        }
        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            string email = txtEmail.Text;

            Regex rg = new Regex(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
         @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
         @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");

            if (rg.IsMatch(email))
            {
                btnInserir.Enabled = true;
            }
            else
            {
                btnInserir.Enabled = false;
                txtEmail.Focus();
            }
        }

        private void txtCep_TextChanged(object sender, EventArgs e)
        {
            if (txtCep.Text.Length == 8)
            {

                var cep = Cep.Obter(txtCep.Text);
                txtBairro.Text = cep.Bairro;
                txtCidade.Text = cep.Localidade;
                txtLogradouro.Text = cep.Logradouro;
                txtUf.Text = cep.Uf;
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text=="...")
            {
                txtID.ReadOnly = false;
                txtID.Focus();
                BloquearControles();
                button1.Text = "Buscar";
            }
            else
            {
                txtID.ReadOnly = true;
                txtNome.Focus();
                DesbloquearControles();
                button1.Text = "...";
                Cliente cliente = new Cliente();
                cliente.BuscarPorId(int.Parse(txtID.Text));
                if (cliente.Id>0)
                {
                    txtNome.Text = cliente.Nome;
                    txtEmail.Text = cliente.Email;
                    txtTelefone.Text = cliente.Telefone;
                    mskCpf.Text = cliente.Cpf;
                    mskCpf.Enabled = false;
                    chkAtivo.Checked = cliente.Ativo;
                    chkAtivo.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Cliente não encontrado!");
                }
               
            }
        }

        private void DesbloquearControles()
        {
            txtNome.Enabled = true;
            txtEmail.Enabled = true;
            txtTelefone.Enabled = true;
            mskCpf.Enabled = true;
        }

        private void BloquearControles()
        {
            txtNome.Enabled = false;
            txtEmail.Enabled = false;
            txtTelefone.Enabled = false;
            mskCpf.Enabled = false;
        }

        private void btnEditarAlterar_Click(object sender, EventArgs e)
        {
            
            Cliente cliente = new Cliente();
            cliente.Id = int.Parse(txtID.Text);
            cliente.Nome = txtNome.Text;
            cliente.Telefone = txtTelefone.Text;
            cliente.Email = txtEmail.Text;
            cliente.Ativo = chkAtivo.Checked;
            if (cliente.Alterar())
            {
                MessageBox.Show("Cliente alterado com sucesso!");
                LimpaCampos();
                btnListar_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Falha ao alterar o cliente!");
            }

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            dgvClientes.Rows.Clear();
            var lista = Cliente.ListarTodos();
            foreach (var item in lista)
            {
                dgvClientes.Rows.Add();
                dgvClientes.Rows[dgvClientes.Rows.Count-1].Cells[0].Value = item.Id;
                dgvClientes.Rows[dgvClientes.Rows.Count - 1].Cells[1].Value = item.Nome;
                dgvClientes.Rows[dgvClientes.Rows.Count - 1].Cells[2].Value = item.Cpf;
                dgvClientes.Rows[dgvClientes.Rows.Count - 1].Cells[3].Value = item.Email;
                dgvClientes.Rows[dgvClientes.Rows.Count - 1].Cells[4].Value = item.Telefone;
                dgvClientes.Rows[dgvClientes.Rows.Count - 1].Cells[5].Value = item.Ativo;
  

            }
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
