using LoucaLiza.controller;
using LoucaLiza.model.cliente;
using LoucaLiza.utils;
using System;
using System.Windows.Forms;

namespace LoucaLiza.view
{
    public partial class CadastroCliente : Form
    {
        private ClienteController clienteController = new ClienteController();
        private Cliente _cliente;
        private Action<Cliente> _onSaveCallback;

        public CadastroCliente(Cliente cliente, Action<Cliente> onSaveCallback)
        {
            InitializeComponent();

            _cliente = cliente ?? new Cliente();
            _onSaveCallback = onSaveCallback;

            InitFormTitle();
            InitScreenFields();
        }

        private void InitFormTitle()
        {
            labelTitle.Text = _cliente != null && _cliente.Id != null ? "Editar Cliente" : "Novo Cliente";
        }

        private void InitScreenFields()
        {
            // dados gerais
            textBoxDataNascimento.Text = _cliente.DataNascimento == null ? textBoxDataNascimento.Text : _cliente.DataNascimento?.ToString("dd/MM/yyyy");
            textBoxNome.Text = _cliente?.Nome ?? "";
            textBoxCPF.Text = _cliente?.Cpf ?? textBoxCPF.Text;
            textBoxCNH.Text = _cliente?.Cnh ?? textBoxCNH.Text;
            textBoxEmail.Text = _cliente?.Email ?? textBoxEmail.Text;

            // endereço
            textBoxLogradouro.Text = _cliente?.Endereco?.Logradouro ?? textBoxLogradouro.Text;
            textBoxComplemento.Text = _cliente?.Endereco?.Complemento ?? textBoxComplemento.Text;
            textBoxBairro.Text = _cliente?.Endereco?.Bairro ?? textBoxBairro.Text;
            textBoxEstado.Text = _cliente?.Endereco?.Estado ?? textBoxEstado.Text;
            textBoxCidade.Text = _cliente?.Endereco?.Cidade ?? textBoxCidade.Text;
            textBoxNumero.Text = _cliente?.Endereco?.Numero ?? textBoxNumero.Text;
            textBoxCEP.Text = _cliente?.Endereco?.Cep ?? textBoxCEP.Text;

            // telefone
            textBoxTelefone.Text = _cliente?.Telefone?.Numero ?? textBoxTelefone.Text;
        }

        private Cliente ConvertScreenDataToCliente()
        {
            _cliente.DataNascimento = DateTime.Parse(textBoxDataNascimento.Text);
            _cliente.Email = textBoxEmail.Text;
            _cliente.Nome = textBoxNome.Text;
            _cliente.Cpf = textBoxCPF.Text;
            _cliente.Cnh = textBoxCNH.Text;

            _cliente.Telefone = new Telefone();
            _cliente.Telefone.Numero = textBoxTelefone.Text;

            _cliente.Endereco = new Endereco();
            _cliente.Endereco.Logradouro = textBoxLogradouro.Text;
            _cliente.Endereco.Complemento = textBoxComplemento.Text;
            _cliente.Endereco.Bairro = textBoxBairro.Text;
            _cliente.Endereco.Estado = textBoxEstado.Text;
            _cliente.Endereco.Cidade = textBoxCidade.Text;
            _cliente.Endereco.Numero = textBoxNumero.Text;
            _cliente.Endereco.Cep = textBoxCEP.Text;

            return _cliente;
        }

        private void btnSalvarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                ConvertScreenDataToCliente();
                clienteController.Save(_cliente);

                MessageBox.Show("Cliente salvo com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();

                _onSaveCallback(_cliente);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Campos não preenchidos.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
