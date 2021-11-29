using Loucaliza.model.veiculo;
using LoucaLiza.controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            _veiculo = veiculo != null ? veiculo : new Veiculo();
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
            // dados gerais
            comboBoxMarca.Text = _veiculo?.Marca ?? comboBoxMarca.Text;
            textBoxModelo.Text = _veiculo?.Modelo?? textBoxModelo.Text;
            textBoxChassi.Text = _veiculo?.Chassi ?? textBoxChassi.Text;
            textBoxPlaca.Text = _veiculo?.Placa?? textBoxPlaca.Text;
            // TODO: verificar: comboBoxCor.Text = _veiculo?.Cor?.ToString() ?? "";
            textBoxAno.Text = _veiculo?.Ano.ToString();
            // textBoxKm.Text = _veiculo?.Quilometragem ?? textBoxKm.Text;
            textBoxDiaria.Text = _veiculo?.ValorDiario.ToString() ?? textBoxDiaria.Text;
        }
    }
}
