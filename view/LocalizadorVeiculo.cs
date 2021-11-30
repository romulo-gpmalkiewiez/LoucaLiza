using Loucaliza.model.veiculo;
using LoucaLiza.utils;
using System;
using System.Windows.Forms;

namespace LoucaLiza.view
{
    public partial class LocalizadorVeiculo : Form
    {
        private Action<Veiculo> _onSelectVeiculoCallback;

        public LocalizadorVeiculo(Action<Veiculo> onSelectVeiculoCallback)
        {
            InitializeComponent();

            _onSelectVeiculoCallback = onSelectVeiculoCallback;
        }

        private void btnAddVeiculo_Click(object sender, EventArgs e)
        {
            FormUtils.OpenNewDialog(this, new CadastroVeiculo(null, HandleAfterSaveVeiculo));
        }

        private void btnSelecionarVeiculo_Click(object sender, EventArgs e)
        {
            Close();
            // TODO: _onSelectVeiculoCallback(veiculo);
        }

        private void HandleAfterSaveVeiculo(Veiculo veiculo)
        {
            Close();
            _onSelectVeiculoCallback(veiculo);
        }
    }
}
