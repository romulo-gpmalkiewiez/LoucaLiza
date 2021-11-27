using LoucaLiza.utils;
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
    public partial class LocalizadorVeiculo : Form
    {
        public LocalizadorVeiculo()
        {
            InitializeComponent();
        }

        private void btnAddVeiculo_Click(object sender, EventArgs e)
        {
            FormUtils.OpenNewWindow(this, new CadastroVeiculo());
        }

        private void btnSelecionarVeiculo_Click(object sender, EventArgs e)
        {
            // TODO: onSelectVeiculo(veiculo);
            Close();
        }
    }
}
