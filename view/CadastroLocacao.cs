using LoucaLiza.utils;
using System.Windows.Forms;

namespace LoucaLiza.view
{
    public partial class CadastroLocacao : Form
    {
        private Form _sourceForm;

        public CadastroLocacao(Form sourceForm)
        {
            InitializeComponent();
            _sourceForm = sourceForm;
        }

        private void btnLocalizaCliente_Click(object sender, System.EventArgs e)
        {
            FormUtils.OpenNewWindow(this, new LocalizadorCliente(this));
        }
    }
}
