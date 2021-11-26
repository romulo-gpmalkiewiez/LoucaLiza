using System.Windows.Forms;

namespace LoucaLiza.view
{
    public partial class LocalizadorCliente : Form
    {
        private Form _sourceForm;

        public LocalizadorCliente(Form sourceForm)
        {
            InitializeComponent();

            _sourceForm = sourceForm;
        }
    }
}
