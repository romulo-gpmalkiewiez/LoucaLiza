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
            OpenNewWindow(new ListaCliente(this));
        }

        private void btnVeiculos_Click(object sender, EventArgs e)
        {
            OpenNewWindow(new ListaVeiculo(this));
        }

        private void OpenNewWindow(Form formToOpen)
        {
            FormUtils.Disable(this);
            formToOpen.Show();
        }
    }
}
