using Loucaliza.model.veiculo;
using LoucaLiza.utils;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace LoucaLiza.view
{
    public partial class ListaVeiculo : Form
    {
        private List<Veiculo> _veiculos;
        private DataTable _dataTableVeiculo = new DataTable();

        public ListaVeiculo()
        {
            InitializeComponent();

            LoadListaVeiculos();

            InitDataTableColumns();
            UpdateDataGrid();
            ConfigureDataTableViewVeiculos();
        }

        private void LoadListaVeiculos()
        {
            _veiculos = Application.Database.Veiculos;
        }

        private void btnAddVeiculo_Click(object sender, System.EventArgs e)
        {
            FormUtils.OpenNewDialog(this, new CadastroVeiculo(null, HandleAfterSaveVeiculo));
        }

        private void HandleAfterSaveVeiculo(Veiculo veiculo)
        {
            UpdateDataGrid();
        }

        private void InitDataTableColumns()
        {
            _dataTableVeiculo.Columns.Add("id", typeof(int));
            _dataTableVeiculo.Columns.Add("marca", typeof(string));
            _dataTableVeiculo.Columns.Add("modelo", typeof(string));
            _dataTableVeiculo.Columns.Add("placa", typeof(string));
            _dataTableVeiculo.Columns.Add("ano", typeof(int));
            _dataTableVeiculo.Columns.Add("cor", typeof(string));
            _dataTableVeiculo.Columns.Add("quilometragem", typeof(int));
            _dataTableVeiculo.Columns.Add("valorDiario", typeof(double));
            _dataTableVeiculo.Columns.Add("chassi", typeof(string));
            _dataTableVeiculo.Columns.Add("status", typeof(string));
        }

        private void ConfigureDataTableViewVeiculos()
        {
            dataGridVeiculo.DefaultCellStyle.Font = new Font("Arial", 9);

            dataGridVeiculo.Columns["id"].HeaderText = "ID";
            dataGridVeiculo.Columns["id"].Visible = false;

            dataGridVeiculo.Columns["marca"].HeaderText = "Marca";

            dataGridVeiculo.Columns["modelo"].HeaderText = "Modelo";

            dataGridVeiculo.Columns["placa"].HeaderText = "Placa";

            dataGridVeiculo.Columns["ano"].HeaderText = "Ano";

            dataGridVeiculo.Columns["cor"].HeaderText = "Cor";

            dataGridVeiculo.Columns["quilometragem"].HeaderText = "Quilometragem";

            dataGridVeiculo.Columns["valorDiario"].HeaderText = "Valor Diário";

            dataGridVeiculo.Columns["chassi"].HeaderText = "Chassi";

            dataGridVeiculo.Columns["status"].HeaderText = "Status";
        }

        private void UpdateDataGrid()
        {
            _dataTableVeiculo.Rows.Clear();

            foreach (Veiculo veiculo in _veiculos)
            {
                _dataTableVeiculo.Rows.Add(new object[] {
                    veiculo.Id,
                    veiculo.Marca,
                    veiculo.Modelo,
                    veiculo.Placa,
                    veiculo.Ano,
                    veiculo.Cor,
                    veiculo.Quilometragem,
                    veiculo.ValorDiario,
                    veiculo.Chassi,
                    veiculo.Locado ? "Locado" : "Disponível",
                });
            }

            dataGridVeiculo.DataSource = _dataTableVeiculo;
        }
    }
}
