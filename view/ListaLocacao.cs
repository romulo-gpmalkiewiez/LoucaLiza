using LoucaLiza.model.locacao;
using LoucaLiza.utils;
using LoucaLiza.view;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace LoucaLiza
{
    public partial class ListaLocacao : Form
    {
        private List<Locacao> _locacoes;
        private DataTable _dataTableLocacao = new DataTable();

        public ListaLocacao()
        {
            InitializeComponent();

            LoadListaLocacoes();

            InitDataTableColumns();
            UpdateDataGrid();
            ConfigureDataTableViewLocacoes();
        }

        private void LoadListaLocacoes()
        {
            _locacoes = Application.Database.Locacoes;
        }

        private void InitDataTableColumns()
        {
            _dataTableLocacao.Columns.Add("id", typeof(int));
            _dataTableLocacao.Columns.Add("dataLocacao", typeof(DateTime));
            _dataTableLocacao.Columns.Add("cliente", typeof(string));
            _dataTableLocacao.Columns.Add("cnh", typeof(string));
            _dataTableLocacao.Columns.Add("veiculo", typeof(string));
            _dataTableLocacao.Columns.Add("placa", typeof(string));
            _dataTableLocacao.Columns.Add("dias", typeof(int));
            _dataTableLocacao.Columns.Add("diaria", typeof(string));
            _dataTableLocacao.Columns.Add("total", typeof(string));
        }

        private void ConfigureDataTableViewLocacoes()
        {
            dataGridLocacao.DefaultCellStyle.Font = new Font("Arial", 9);

            dataGridLocacao.Columns["id"].HeaderText = "ID";
            dataGridLocacao.Columns["id"].Visible = false;

            dataGridLocacao.Columns["dataLocacao"].HeaderText = "Locação";

            dataGridLocacao.Columns["cliente"].HeaderText = "Cliente";

            dataGridLocacao.Columns["cnh"].HeaderText = "CNH";

            dataGridLocacao.Columns["veiculo"].HeaderText = "Veículo";
            
            dataGridLocacao.Columns["placa"].HeaderText = "Placa";

            dataGridLocacao.Columns["dias"].HeaderText = "Dias";

            dataGridLocacao.Columns["diaria"].HeaderText = "Diária";

            dataGridLocacao.Columns["total"].HeaderText = "Total";
        }

        private void UpdateDataGrid()
        {
            _dataTableLocacao.Rows.Clear();

            foreach (Locacao locacao in _locacoes)
            {
                _dataTableLocacao.Rows.Add(new object[] {
                    locacao.Id,
                    locacao.DataLocacao,
                    locacao.Cliente.Nome,
                    locacao.Cliente.Cnh,
                    String.Format("{0} {1}", locacao.Veiculo.Marca, locacao.Veiculo.Modelo),
                    locacao.Veiculo.Placa,
                    locacao.Dias,
                    String.Format("R$ {0:0.00}", locacao.ValorDiaria),
                    String.Format("R$ {0:0.00}", locacao.Dias * locacao.ValorDiaria)
                });
            }

            dataGridLocacao.DataSource = _dataTableLocacao;
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FormUtils.OpenNewWindow(this, new ListaCliente());
        }

        private void btnVeiculos_Click(object sender, EventArgs e)
        {
            FormUtils.OpenNewWindow(this, new ListaVeiculo());
        }

        private void btnAddLocacao_Click(object sender, EventArgs e)
        {
            FormUtils.OpenNewDialog(this, new CadastroLocacao(null, HandleAfterSaveLocacao));
        }

        private void HandleAfterSaveLocacao(Locacao locacao)
        {
            UpdateDataGrid();
        }
    }
}
