using LoucaLiza.utils;
using System.Windows.Forms;

namespace LoucaLiza.view
{
    public partial class CadastroLocacao : Form
    {
        public CadastroLocacao()
        {
            InitializeComponent();
        }

        private void btnLocalizaCliente_Click(object sender, System.EventArgs e)
        {
            FormUtils.OpenNewWindow(this, new LocalizadorCliente());
        }
    }
}
