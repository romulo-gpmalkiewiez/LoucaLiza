using LoucaLiza.utils;
using LoucaLiza.view;
using System;
using System.Windows.Forms;

namespace LoucaLiza
{
    public partial class ListaLocacao : Form
    {
        public ListaLocacao()
        {
            InitializeComponent();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FormUtils.OpenNewWindow(this, new ListaCliente(this));
        }

        private void btnVeiculos_Click(object sender, EventArgs e)
        {
            FormUtils.OpenNewWindow(this, new ListaVeiculo(this));
        }

        private void btnAddLocacao_Click(object sender, EventArgs e)
        {
            FormUtils.OpenNewWindow(this, new CadastroLocacao(this));
        }
    }
}
