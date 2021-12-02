﻿using Loucaliza.model.veiculo;
using LoucaLiza.controller;
using LoucaLiza.model.veiculo;
using LoucaLiza.utils;
using System;
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
        private VeiculoController _controller = new VeiculoController();
        public ListaVeiculo()
        {
            InitializeComponent();

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
            _dataTableVeiculo.Columns.Add("valorDiario", typeof(string));
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
                    String.Format("R$ {0:0.00}", veiculo.ValorDiaria),
                    veiculo.Chassi,
                    veiculo.Locado ? "Locado" : "Disponível",
                });
            }

            dataGridVeiculo.DataSource = _dataTableVeiculo;
        }

        private void btnAddVeiculo_Click(object sender, EventArgs e)
        {
            FormUtils.OpenNewDialog(this, new CadastroVeiculo(null, HandleAfterSaveVeiculo));
        }

        private void btnEditarVeiculo_Click(object sender, EventArgs e)
        {
            var selectedVeiculo = GetSelectedVeiculo();
            if (selectedVeiculo != null)
            {
                FormUtils.OpenNewDialog(this, new CadastroVeiculo(selectedVeiculo, HandleAfterSaveVeiculo));
            }
        }

        private void btnExcluirVeiculo_Click(object sender, EventArgs e)
        {
            var selectedVeiculo = GetSelectedVeiculo();
            if (selectedVeiculo != null && DialogUtils.ConfirmDelete() && _controller.Delete(selectedVeiculo))
            {
                UpdateDataGrid();
                MessageBox.Show("Veículo removido com sucesso!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private Veiculo GetSelectedVeiculo()
        {
            return DataGridUtils.GetSelectedEntityById(dataGridVeiculo, _veiculos);
        }
    }
}
