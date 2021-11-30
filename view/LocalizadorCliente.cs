using LoucaLiza.model.cliente;
using LoucaLiza.utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace LoucaLiza.view
{
    public partial class LocalizadorCliente : Form
    {
        private List<Cliente> _clientes;
        private DataTable _dataTableCliente = new DataTable();
        private Action<Cliente> _onSelectCallback;

        public LocalizadorCliente(Action<Cliente> onSelectClienteCallback)
        {
            InitializeComponent();

            _onSelectCallback = onSelectClienteCallback;

            LoadListaClientes();

            InitDataTableColumns();
            UpdateDataGrid();
            ConfigureDataTableViewClientes();
        }

        private void LoadListaClientes()
        {
            _clientes = Application.Database.Clientes;
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

            dataGridCliente.Columns["id"].HeaderText = "ID";
            dataGridCliente.Columns["id"].Visible = false;

            dataGridCliente.Columns["nome"].HeaderText = "Nome";

            dataGridCliente.Columns["cpf"].HeaderText = "CPF";

            dataGridCliente.Columns["cnh"].HeaderText = "CNH";

            dataGridCliente.Columns["email"].HeaderText = "Email";

            dataGridCliente.Columns["dt_nascimento"].HeaderText = "Data Nascimento";

            dataGridCliente.Columns["telefone"].HeaderText = "Telefone";

            dataGridCliente.Columns["endereco"].HeaderText = "Endereço";
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

        private void btnAddCliente_Click(object sender, System.EventArgs e)
        {
            FormUtils.OpenNewDialog(this, new CadastroCliente(null, HandleAfterSaveCliente));
        }

        private void btnSelecionarCliente_Click(object sender, EventArgs e)
        {
            var selectedCliente = GetSelectedCliente();
            if (selectedCliente != null)
            {
                Close();
                _onSelectCallback(selectedCliente);
            }
        }

        private Cliente GetSelectedCliente()
        {
            if (dataGridCliente.SelectedRows.Count > 0)
            {
                int selectedId = (int) dataGridCliente.SelectedRows[0].Cells["id"].Value;
                return _clientes.Find(c => c.Id == selectedId);
            }

            return null;
        }

        private void HandleAfterSaveCliente(Cliente cliente)
        {
            Close();
            _onSelectCallback(cliente);
        }
    }
}
