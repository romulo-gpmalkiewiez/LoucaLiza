using LoucaLiza.model.cliente;
using LoucaLiza.utils;
using System.Windows.Forms;

namespace LoucaLiza.view
{
    public partial class LocalizadorCliente : Form
    {
        public LocalizadorCliente()
        {
            InitializeComponent();
        }

        private void btnAddCliente_Click(object sender, System.EventArgs e)
        {
            FormUtils.OpenNewDialog(this, new CadastroCliente(null, HandleAfterSaveCliente));
        }

        private void btnSelecionarCliente_Click(object sender, System.EventArgs e)
        {
            // onSelectCliente
            Close();
        }

        private void HandleAfterSaveCliente(Cliente cliente)
        {
            MessageBox.Show("CLIENTE SELECIONADO" + cliente.Nome);
        }
    }
}
