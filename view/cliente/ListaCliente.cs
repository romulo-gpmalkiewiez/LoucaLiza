using LoucaLiza.controller;
using LoucaLiza.model.cliente;
using LoucaLiza.repository;
using LoucaLiza.utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace LoucaLiza.view
{
    public partial class ListaCliente : Form
    {
        private List<Cliente> _clientes;
        private ClienteFilter _filter = new ClienteFilter();
        private DataTable _dataTableCliente = new DataTable();
        private ClienteController _controller = new ClienteController();

        public ListaCliente()
        {
            InitializeComponent();

            LoadListaClientesByFilter();

            InitDataTableColumns();
            UpdateDataGrid();
            ConfigureDataTableViewClientes();
        }

        private void LoadListaClientesByFilter()
        {
            _clientes = _controller.GetAll(_filter);
        }

        private void InitDataTableColumns()
        {
            _dataTableCliente.Columns.Add("id", typeof(int));
            _dataTableCliente.Columns.Add("nome", typeof(string));
            _dataTableCliente.Columns.Add("cpf", typeof(string));
            _dataTableCliente.Columns.Add("cnh", typeof(string));
            _dataTableCliente.Columns.Add("email", typeof(string));
            _dataTableCliente.Columns.Add("dt_nascimento", typeof(DateTime));
            _dataTableCliente.Columns.Add("telefone", typeof(string));
            _dataTableCliente.Columns.Add("endereco", typeof(string));
        }

        private void ConfigureDataTableViewClientes()
        {
            dataGridCliente.DefaultCellStyle.Font = new Font("Arial", 9);
            //dataGridCliente.RowHeadersWidth = 25;

            dataGridCliente.Columns["id"].HeaderText = "ID";
            dataGridCliente.Columns["id"].Visible = false;

            dataGridCliente.Columns["nome"].HeaderText = "Nome";

            dataGridCliente.Columns["cpf"].HeaderText = "CPF";

            dataGridCliente.Columns["cnh"].HeaderText = "CNH";

            dataGridCliente.Columns["email"].HeaderText = "Email";

            dataGridCliente.Columns["dt_nascimento"].HeaderText = "Data Nascimento";

            dataGridCliente.Columns["telefone"].HeaderText = "Telefone";

            dataGridCliente.Columns["endereco"].HeaderText = "Endereço";
            dataGridCliente.Columns["endereco"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void UpdateDataGrid()
        {
            _dataTableCliente.Rows.Clear();

            foreach (Cliente cliente in _clientes)
            {
                _dataTableCliente.Rows.Add(new object[] {
                    cliente.Id,
                    cliente.Nome,
                    cliente.Cpf,
                    cliente.Cnh,
                    cliente.Email,
                    cliente.DataNascimento,
                    cliente.Telefone?.Numero,
                    String.Format("{0}, {1}, {2}", cliente.Endereco?.Logradouro, cliente.Endereco?.Numero, cliente.Endereco?.Complemento),
                });
            }

            dataGridCliente.DataSource = _dataTableCliente;
        }

        private void btnAddCliente_Click(object sender, EventArgs e)
        {
            FormUtils.OpenNewDialog(this, new CadastroCliente(null, HandleAfterSaveCliente));
        }

        private void HandleAfterSaveCliente(Cliente cliente)
        {
            LoadListaClientesByFilter();
            UpdateDataGrid();
        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            var selectedCliente = DataGridUtils.GetSelectedEntityById(dataGridCliente, _clientes);
            if (selectedCliente != null)
            {
                FormUtils.OpenNewDialog(this, new CadastroCliente(selectedCliente, HandleAfterSaveCliente));
            }
        }

        private void btnExcluirCliente_Click(object sender, EventArgs e)
        {
            var selectedCliente = GetSelectedCliente();
            if (selectedCliente != null && DialogUtils.ConfirmDelete() && _controller.Delete(selectedCliente))
            {
                UpdateDataGrid();
                MessageBox.Show("Cliente removido com sucesso!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private Cliente GetSelectedCliente()
        {
            return DataGridUtils.GetSelectedEntityById(dataGridCliente, _clientes);
        }

        private void ConvertScreenDataToClienteFilter()
        {
            _filter.Nome = textBoxNome.Text;
            _filter.Cpf = textBoxCPF.Text;
            _filter.Cnh = textBoxCNH.Text;
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            ConvertScreenDataToClienteFilter();
            _clientes = _controller.GetAll(_filter);
            UpdateDataGrid();
        }
    }
}
