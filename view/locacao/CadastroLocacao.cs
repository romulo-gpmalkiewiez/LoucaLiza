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
            InitFormValues();
        }

        private void InitFormTitle()
        {
            labelTitle.Text = "Nova Locação";
        }

        private void InitFormValues()
        {
            textBoxDataLocacao.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
        }

        private void HandleClienteSelected(Cliente cliente)
        {
            _locacao.Cliente = cliente;
            UpdateTextBoxCliente();
        }

        private void HandleVeiculoSelected(Veiculo veiculo)
        {
            _locacao.Veiculo = veiculo;
            UpdateTextBoxVeiculo();
            UpdateLabelSubtotal();
            UpdateTextBoxDataDevolucao();
        }

        private void UpdateTextBoxCliente()
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

        private void UpdateTextBoxVeiculo()
        {
            if (_locacao.Veiculo != null)
            {
                var textValue = String.Format(
                    "{0} {1} - {2}",
                    _locacao.Veiculo.Marca,
                    _locacao.Veiculo.Modelo,
                    String.Format("R$ {0:0.00}", _locacao.Veiculo.ValorDiaria));

                textBoxVeiculo.Text = textValue;
            }
        }

        private void UpdateTextBoxDataDevolucao()
        {
            var diasLocacao = GetDiasLocacao();

            if (diasLocacao > 0)
            {
                var devolucao = GetDataLocacao().AddDays(diasLocacao);
                textBoxDevolucao.Text = devolucao.ToString("dd/MM/yyyy HH:mm");
            }
        }

        private void UpdateLabelSubtotal()
        {
            if (_locacao.Veiculo != null)
            {
                double valorDIaria = _locacao.Veiculo.ValorDiaria ?? 0;
                double diasLocacao = GetDiasLocacao();

                double subtotalValue = valorDIaria * diasLocacao;

                labelSubtotalValor.Text = String.Format("R$ {0:0.00}", subtotalValue);
            }
        }

        private DateTime GetDataLocacao()
        {
            try
            {
                return DateTime.Parse(textBoxDataLocacao.Text);
            }
            catch (Exception)
            {
                return DateTime.Now;
            } 
        }

        private int GetDiasLocacao()
        {
            try
            {
                return int.Parse(textBoxDias.Text);
            }
            catch (Exception)
            {
                return 0;
            }
        }

        private void textBoxDias_KeyUp(object sender, KeyEventArgs e)
        {
            UpdateLabelSubtotal();
            UpdateTextBoxDataDevolucao();
        }

        private Locacao ConvertScreenDataToLocacao()
        {
            _locacao.DataLocacao = GetDataLocacao();
            _locacao.Dias = GetDiasLocacao();

            return _locacao;
        }

        private void btnSalvarLocacao_Click(object sender, EventArgs e)
        {
            try
            {
                ConvertScreenDataToLocacao();
                locacaoController.Save(_locacao);

                MessageBox.Show("Locação realizada com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();

                _onSaveCallback(_locacao);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Campos não preenchidos.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLocalizaVeiculo_Click(object sender, EventArgs e)
        {
            FormUtils.OpenNewDialog(this, new LocalizadorVeiculo(HandleVeiculoSelected));
        }

        private void textBoxVeiculo_DoubleClick(object sender, EventArgs e)
        {
            FormUtils.OpenNewDialog(this, new LocalizadorVeiculo(HandleVeiculoSelected));
        }

        private void textBoxVeiculo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnLocalizaCliente_Click(object sender, EventArgs e)
        {
            FormUtils.OpenNewDialog(this, new LocalizadorCliente(HandleClienteSelected));
        }

        private void textBoxCliente_DoubleClick(object sender, EventArgs e)
        {
            FormUtils.OpenNewDialog(this, new LocalizadorCliente(HandleClienteSelected));
        }

        private void textBoxCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
