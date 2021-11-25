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

        private void CadastroLocacao_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormUtils.Enable(_sourceForm);
        }
    }
}
