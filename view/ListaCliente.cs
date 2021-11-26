using LoucaLiza.utils;
using System.Windows.Forms;

namespace LoucaLiza.view
{
    public partial class ListaCliente : Form
    {
        private Form _sourceForm;
        public ListaCliente(Form sourceForm)
        {
            InitializeComponent();
            _sourceForm = sourceForm;
        }
    }
}
