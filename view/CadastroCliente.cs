using LoucaLiza.model.cliente;
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
    public partial class CadastroCliente : Form
    {
        private Cliente _cliente;
        private Action<Cliente> _onSaveCallback;

        public CadastroCliente(Cliente cliente, Action<Cliente> onSaveCallback)
        {
            InitializeComponent();

            _cliente = cliente != null ? cliente : new Cliente();
            _onSaveCallback = onSaveCallback;

            InitFormTitle();
            InitScreenFields();
        }

        private void InitScreenFields()
        {
            // dados gerais
            textBoxDataNascimento.Text = _cliente.DataNascimento == null ? "" : _cliente.DataNascimento.ToString("dd/mm/yyyy");
            textBoxNome.Text = _cliente?.Nome ?? textBoxNome.Text;
            textBoxCPF.Text = _cliente?.Cpf ?? textBoxCPF.Text;

            // endereço
            if (_cliente.Endereco != null)
            {
                textBoxLogradouro.Text = _cliente.Endereco.Logradouro;
                textBoxBairro.Text = _cliente.Endereco.Bairro;
                textBoxEstado.Text = _cliente.Endereco.Estado;
                textBoxCidade.Text = _cliente.Endereco.Cidade;
                textBoxNumero.Text = _cliente.Endereco.Numero;
                textBoxCEP.Text = _cliente.Endereco.Cep;
            }

            // telefone
            if (_cliente.Endereco != null)
            {
                textBoxTelefone.Text = _cliente.Telefone.Numero;
            }
        }

        private void InitFormTitle()
        {
            labelTitle.Text = _cliente != null && _cliente.Id != null ? "Editar Cliente" : "Novo Cliente";
        }

        private Cliente ConvertScreenDataToCliente()
        {
            Endereco endereco = new Endereco();
            endereco.Logradouro = textBoxLogradouro.Text;
            endereco.Bairro = textBoxBairro.Text;
            endereco.Estado = textBoxEstado.Text;
            endereco.Cidade = textBoxCidade.Text;
            endereco.Numero = textBoxNumero.Text;
            endereco.Cep = textBoxCEP.Text;

            Telefone telefone = new Telefone();
            telefone.Numero = textBoxTelefone.Text;

            Cliente cliente = new Cliente();
            cliente.DataNascimento = DateTime.Parse(textBoxDataNascimento.Text);
            cliente.Nome = textBoxNome.Text;
            cliente.Cpf = textBoxCPF.Text;
            cliente.Endereco = endereco;
            cliente.Telefone = telefone;

            return cliente;
        }

        private void btnSalvarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                ConvertScreenDataToCliente();
                // _cliente.Save();  // -- Save() deve validar... try

                MessageBox.Show("Cliente salvo com sucesso!");
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
