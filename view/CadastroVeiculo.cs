using Loucaliza.model.veiculo;
using LoucaLiza.controller;
using LoucaLiza.model.veiculo;
using LoucaLiza.utils;
using System;
using System.Windows.Forms;

namespace LoucaLiza.view
{
    public partial class CadastroVeiculo : Form
    {
        private VeiculoController veiculoController = new VeiculoController();
        private Veiculo _veiculo;
        private Action<Veiculo> _onAfterSaveCallback;

        public CadastroVeiculo(Veiculo veiculo, Action<Veiculo> onAfterSaveCallback)
        {
            InitializeComponent();

            _veiculo = veiculo ?? new Veiculo();
            _onAfterSaveCallback = onAfterSaveCallback;

            InitComboBoxes();
            InitFormTitle();
            InitScreenFields();
        }

        private void InitFormTitle()
        {
            labelTitle.Text = _veiculo != null && _veiculo.Id != null ? "Editar Veículo" : "Novo Veículo";
        }

        private void InitComboBoxes()
        {
            ComboBoxUtils.ConfigureComboBoxItems(comboBoxMarca, Marca.GetAvailable());
            ComboBoxUtils.ConfigureComboBoxItems(comboBoxCor, Cor.GetAvailable());
        }

        private void InitScreenFields()
        {
            comboBoxMarca.Text = _veiculo?.Marca;
            textBoxModelo.Text = _veiculo?.Modelo;
            textBoxChassi.Text = _veiculo?.Chassi;
            textBoxPlaca.Text = _veiculo?.Placa;
            comboBoxCor.Text = _veiculo?.Cor;
            textBoxAno.Text = _veiculo?.Ano.ToString();
            textBoxKm.Text = _veiculo?.Quilometragem.ToString();
            textBoxDiaria.Text = _veiculo?.ValorDiaria.ToString();
        }

        private Veiculo ConvertScreenDataToVeiculo()
        {
            _veiculo.Marca = comboBoxMarca.Text;
            _veiculo.Modelo = textBoxModelo.Text;
            _veiculo.Placa = textBoxPlaca.Text;
            _veiculo.Ano = int.Parse(textBoxAno.Text);
            _veiculo.Cor = comboBoxCor.Text;
            _veiculo.Quilometragem = int.Parse(textBoxKm.Text);
            _veiculo.ValorDiaria = double.Parse(textBoxDiaria.Text);
            _veiculo.Chassi = textBoxChassi.Text;

            return _veiculo;
        }

        private void btnSalvarVeiculo_Click(object sender, EventArgs e)
        {
            try
            {
                ConvertScreenDataToVeiculo();
                veiculoController.Save(_veiculo);

                MessageBox.Show("Veículo salvo com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();

                _onAfterSaveCallback(_veiculo);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Campos não preenchidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
