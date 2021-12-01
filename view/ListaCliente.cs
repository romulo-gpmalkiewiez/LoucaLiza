using LoucaLiza.model.cliente;
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
        private DataTable _dataTableCliente = new DataTable();

        public ListaCliente()
        {
            InitializeComponent();

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
            //dataGridCliente.RowHeadersWidth = 25;

            dataGridCliente.Columns["id"].HeaderText = "ID";
            dataGridCliente.Columns["id"].Visible = false;

            dataGridCliente.Columns["nome"].HeaderText = "Nome";
            //dataGridCliente.Columns["nome"].Width = 120;

            dataGridCliente.Columns["cpf"].HeaderText = "CPF";
            //dataGridCliente.Columns["cpf"].Width = 60;

            dataGridCliente.Columns["cnh"].HeaderText = "CNH";
            //dataGridCliente.Columns["cnh"].Width = 60;

            dataGridCliente.Columns["email"].HeaderText = "Email";
            //dataGridCliente.Columns["email"].Width = 80;

            dataGridCliente.Columns["dt_nascimento"].HeaderText = "Data Nascimento";
            //dataGridCliente.Columns["dt_nascimento"].Width = 80;

            dataGridCliente.Columns["telefone"].HeaderText = "Telefone";
            //dataGridCliente.Columns["telefone"].Width = 60;

            dataGridCliente.Columns["endereco"].HeaderText = "Endereço";
            //dataGridCliente.Columns["endereco"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


            //dataGridViewLancamentos.Columns["nome_categoria"].HeaderText = "Categoria";
            //dataGridViewLancamentos.Columns["nome_categoria"].Width = 130;

            //dataGridViewLancamentos.Columns["valor"].HeaderText = "Valor (R$)";
            //dataGridViewLancamentos.Columns["valor"].Width = 150;
            //dataGridViewLancamentos.Columns["valor"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dataGridViewLancamentos.Columns["valor"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //dataGridViewLancamentos.Columns["descricao"].HeaderText = "Descrição";
            //dataGridViewLancamentos.Columns["descricao"].Width = 200;

            //dataGridViewLancamentos.Columns["observacao"].HeaderText = "Observação";
            //dataGridViewLancamentos.Columns["observacao"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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

        private void HandleAfterSaveCliente(Cliente cliente)
        {
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
    }
}
