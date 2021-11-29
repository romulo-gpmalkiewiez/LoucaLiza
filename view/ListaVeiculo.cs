using LoucaLiza.utils;
using System.Windows.Forms;

namespace LoucaLiza.view
{
    public partial class ListaVeiculo : Form
    {
        public ListaVeiculo()
        {
            InitializeComponent();
        }

        private void btnAddVeiculo_Click(object sender, System.EventArgs e)
        {
            FormUtils.OpenNewDialog(this, new CadastroVeiculo());
        }
    }
}
