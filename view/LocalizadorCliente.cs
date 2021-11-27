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
            FormUtils.OpenNewWindow(this, new CadastroCliente());
        }

        private void btnSelecionarCliente_Click(object sender, System.EventArgs e)
        {
            // onSelectCliente
            Close();
        }
    }
}
