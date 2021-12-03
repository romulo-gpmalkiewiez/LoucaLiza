using LoucaLiza.controller;
using LoucaLiza.model.locacao;
using LoucaLiza.model.veiculo;
using LoucaLiza.repository;
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
        private LocacaoFilter _filter = new LocacaoFilter();
        private DataTable _dataTableLocacao = new DataTable();
        private LocacaoController _controller = new LocacaoController();

        public ListaLocacao()
        {
            InitializeComponent();

            LoadListaLocacoes();

            InitComboBoxes();
            InitDataTableColumns();
            UpdateDataGrid();
            ConfigureDataTableViewLocacoes();
        }

        private void LoadListaLocacoes()
        {
            _locacoes = Application.Database.Locacoes;
        }
        private void InitComboBoxes()
        {
            ComboBoxUtils.ConfigureComboBoxItems(comboBoxMarca, Marca.GetAvailable());
            ComboBoxUtils.ConfigureComboBoxItems(comboBoxStatus, Status.GetAvailable());
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
            dataGridLocacao.Rows[dataGridLocacao.Rows.Count - 1].Selected = true;
        }

        private void btnExcluirLocacao_Click(object sender, EventArgs e)
        {
            var selectedCliente = GetSelectedCliente();
            if (selectedCliente != null && DialogUtils.ConfirmDelete() && _controller.Delete(selectedCliente))
            {
                UpdateDataGrid();
                MessageBox.Show("Locação removida com sucesso!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private Locacao GetSelectedCliente()
        {
            return DataGridUtils.GetSelectedEntityById(dataGridLocacao, _locacoes);
        }

        private void ConvertScreenDataToFilter()
        {
            _filter.Cliente = textBoxCliente.Text;
            _filter.Documento = textBoxDocumento.Text;
            _filter.Marca = comboBoxMarca.Text;
            _filter.Modelo = textBoxModelo.Text;
            _filter.Placa = textBoxPlaca.Text;
            _filter.Status = Status.Parse(textBoxPlaca.Text);

            if (!string.IsNullOrEmpty(textBoxDataInicial.Text) && textBoxDataInicial.Text != textBoxDataInicial.PlaceHolderText)
            {
                _filter.DataDe = DateTime.Parse(textBoxDataInicial.Text);
            }
            if (!string.IsNullOrEmpty(textBoxDataFinal.Text) && textBoxDataFinal.Text != textBoxDataFinal.PlaceHolderText)
            {
                _filter.DataAte = DateTime.Parse(textBoxDataFinal.Text);
            }
        }

        private void btnBuscaLocacao_Click(object sender, EventArgs e)
        {
            ConvertScreenDataToFilter();
            _locacoes = _controller.GetByFilter(_filter);
            UpdateDataGrid();
        }
    }
}
