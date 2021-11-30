using LoucaLiza.model.cliente;
using LoucaLiza.utils;
using System;
using System.Windows.Forms;

namespace LoucaLiza.view
{
    public partial class LocalizadorCliente : Form
    {
        private Action<Cliente> _onSelectClienteCallback;

        public LocalizadorCliente(Action<Cliente> onSelectClienteCallback)
        {
            InitializeComponent();
            _onSelectClienteCallback = onSelectClienteCallback;
        }

        private void btnAddCliente_Click(object sender, System.EventArgs e)
        {
            FormUtils.OpenNewDialog(this, new CadastroCliente(null, HandleAfterSaveCliente));
        }

        private void btnSelecionarCliente_Click(object sender, EventArgs e)
        {
            Close();
            // _onSelectClienteCallback(getGridSelectedCliente);
        }

        private void HandleAfterSaveCliente(Cliente cliente)
        {
            Close();
            _onSelectClienteCallback(cliente);
        }
    }
}
