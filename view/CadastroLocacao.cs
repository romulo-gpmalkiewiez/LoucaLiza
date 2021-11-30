using Loucaliza.model.veiculo;
using LoucaLiza.controller;
using LoucaLiza.model.cliente;
using LoucaLiza.model.locacao;
using LoucaLiza.utils;
using System;
using System.Windows.Forms;

namespace LoucaLiza.view
{
    public partial class CadastroLocacao : Form
    {
        private LocacaoController locacaoController = new LocacaoController();
        private Locacao _locacao;
        private Action<Locacao> _onSaveCallback;

        public CadastroLocacao(Locacao locacao, Action<Locacao> onSaveCallback)
        {
            InitializeComponent();

            _locacao = locacao ?? new Locacao();
            _onSaveCallback = onSaveCallback;

            InitFormTitle();
        }

        private void InitFormTitle()
        {
            labelTitle.Text = "Nova Locação";
        }

        private void btnLocalizaCliente_Click(object sender, EventArgs e)
        {
            FormUtils.OpenNewDialog(this, new LocalizadorCliente(HandleClienteSelected));
        }

        private void btnLocalizaVeiculo_Click(object sender, EventArgs e)
        {
            FormUtils.OpenNewDialog(this, new LocalizadorVeiculo(HandleVeiculoSelected));
        }

        private void HandleClienteSelected(Cliente cliente)
        {
            _locacao.Cliente = cliente;
            UpdateClienteTextBox();
        }

        private void HandleVeiculoSelected(Veiculo veiculo)
        {
            _locacao.Veiculo = veiculo;
        }

        private void UpdateClienteTextBox()
        {
            if (_locacao.Cliente != null)
            {
                var textValue = String.Format(
                    "{0}, {1} anos, CNH: {2}",
                    _locacao.Cliente.Nome,
                    _locacao.Cliente.Age(),
                    _locacao.Cliente.Cnh);

                textBoxCliente.Text = textValue;
            }
        }
    }
}
