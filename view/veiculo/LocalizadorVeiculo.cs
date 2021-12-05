using Loucaliza.model.veiculo;
using LoucaLiza.controller;
using LoucaLiza.model.veiculo;
using LoucaLiza.repository;
using LoucaLiza.utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace LoucaLiza.view
{
    public partial class LocalizadorVeiculo : Form
    {
        private List<Veiculo> _veiculos;
        private VeiculoFilter _filter = new VeiculoFilter();
        private DataTable _dataTableVeiculo = new DataTable();
        private Action<Veiculo> _onSelectCallback;
        private VeiculoController _controller = new VeiculoController();

        public LocalizadorVeiculo(Action<Veiculo> onSelectVeiculoCallback)
        {
            InitializeComponent();

            _onSelectCallback = onSelectVeiculoCallback;

            LoadListaVeiculos();

            InitComboBoxes();
            InitDataTableColumns();
            UpdateDataGrid();
            ConfigureDataTableViewVeiculos();
        }

        private void LoadListaVeiculos()
        {
            _veiculos = Application.Database.Veiculos;
        }

        private void InitComboBoxes()
        {
            ComboBoxUtils.ConfigureComboBoxItems(comboBoxMarca, Marca.GetAvailable());
            ComboBoxUtils.ConfigureComboBoxItems(comboBoxStatus, Status.GetAvailable());
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
                    veiculo.ValorDiaria,
                    veiculo.Chassi,
                    veiculo.Locado ? Status.LOCADO : Status.DISPONIVEL,
                });
            }

            dataGridVeiculo.DataSource = _dataTableVeiculo;
        }

        private void btnAddVeiculo_Click(object sender, EventArgs e)
        {
            FormUtils.OpenNewDialog(this, new CadastroVeiculo(null, HandleAfterSaveVeiculo));
        }

        private void btnSelecionarVeiculo_Click(object sender, EventArgs e)
        {
            var selectedVeiculo = GetSelectedVeiculo();
            if (selectedVeiculo != null)
            {
                Close();
                _onSelectCallback(selectedVeiculo);
            }
        }

        private void dataGridVeiculo_DoubleClick(object sender, EventArgs e)
        {
            btnSelecionarVeiculo_Click(sender, e);
        }

        private Veiculo GetSelectedVeiculo()
        {
            if (dataGridVeiculo.SelectedRows.Count > 0)
            {
                int selectedId = (int) dataGridVeiculo.SelectedRows[0].Cells["id"].Value;
                return _veiculos.Find(c => c.Id == selectedId);
            }

            return null;
        }

        private void HandleAfterSaveVeiculo(Veiculo veiculo)
        {
            Close();
            _onSelectCallback(veiculo);
        }

        private void ConvertScreenDataToVeiculoFilter()
        {
            _filter.Marca = comboBoxMarca.Text;
            _filter.Modelo = textBoxModelo.Text;
            _filter.Placa = textBoxPlaca.Text;
            _filter.Status = Status.Parse(textBoxPlaca.Text);
        }

        private void btnBuscarVeiculo_Click(object sender, EventArgs e)
        {
            ConvertScreenDataToVeiculoFilter();
            _veiculos = _controller.GetByFilter(_filter);
            UpdateDataGrid();
        }
    }
}
