using Loucaliza.model.veiculo;
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
            FormUtils.OpenNewDialog(this, new CadastroVeiculo(null, HandleAfterSaveVeiculo));
        }

        private void HandleAfterSaveVeiculo(Veiculo veiculo)
        {
            MessageBox.Show("Handler After Save on LocalizadorVeiculo");
        }

        private void btnSelecionarVeiculo_Click(object sender, EventArgs e)
        {
            Close();
            // TODO: onSelectVeiculo(veiculo);
        }
    }
}
