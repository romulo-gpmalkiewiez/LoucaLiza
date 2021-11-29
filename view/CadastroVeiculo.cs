using Loucaliza.model.veiculo;
using LoucaLiza.controller;
using LoucaLiza.utils;
using System;
using System.Windows.Forms;

namespace LoucaLiza.view
{
    public partial class CadastroVeiculo : Form
    {
        private VeiculoController veiculoController = new VeiculoController();
        private Veiculo _veiculo;
        private Action<Veiculo> _onSaveCallback;

        public CadastroVeiculo(Veiculo veiculo, Action<Veiculo> onSaveCallback)
        {
            InitializeComponent();

            _veiculo = veiculo ?? new Veiculo();
            _onSaveCallback = onSaveCallback;

            InitFormTitle();
            InitScreenFields();
        }

        private void InitFormTitle()
        {
            labelTitle.Text = _veiculo != null && _veiculo.Id != null ? "Editar Cliente" : "Novo Cliente";
        }

        private void InitScreenFields()
        {
            comboBoxMarca.Text = _veiculo?.Marca ?? comboBoxMarca.Text;
            textBoxModelo.Text = _veiculo?.Modelo?? textBoxModelo.Text;
            textBoxChassi.Text = _veiculo?.Chassi ?? textBoxChassi.Text;
            textBoxPlaca.Text = _veiculo?.Placa?? textBoxPlaca.Text;
            comboBoxCor.Text = _veiculo?.Cor.ToString();
            textBoxAno.Text = _veiculo?.Ano.ToString();
            textBoxKm.Text = _veiculo?.Quilometragem.ToString() ?? textBoxKm.Text;
            textBoxDiaria.Text = _veiculo?.ValorDiario.ToString() ?? textBoxDiaria.Text;
        }

        private Veiculo ConvertScreenDataToVeiculo()
        {
            _veiculo.Marca = comboBoxMarca.Text;
            _veiculo.Modelo = textBoxModelo.Text;
            _veiculo.Placa = textBoxPlaca.Text;
            _veiculo.Ano = int.Parse(textBoxAno.Text);
            _veiculo.Cor = (Cor)Enum.Parse(typeof(Cor), comboBoxMarca.Text);
            _veiculo.Quilometragem = int.Parse(textBoxKm.Text);
            _veiculo.ValorDiario = double.Parse(textBoxDiaria.Text);
            _veiculo.Chassi = textBoxChassi.Text;

            return _veiculo;
        }

        private void btnSalvarVeiculo_Click(object sender, EventArgs e)
        {
            try
            {
                _veiculo = ModelUtils.Mustang();

                // ConvertScreenDataToVeiculo();
                veiculoController.Save(_veiculo);

                MessageBox.Show("Veículo salvo com sucesso!");
                Close();

                _onSaveCallback(_veiculo);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Campos não preenchidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
