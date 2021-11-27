﻿using LoucaLiza.model.cliente;
using LoucaLiza.utils;
using System.Windows.Forms;

namespace LoucaLiza.view
{
    public partial class ListaCliente : Form
    {
        public ListaCliente()
        {
            InitializeComponent();
        }

        private void btnAddCliente_Click(object sender, System.EventArgs e)
        {
            FormUtils.OpenNewWindow(this, new CadastroCliente(null, HandleAfterSaveCliente));
        }

        private void HandleAfterSaveCliente(Cliente cliente)
        {
            MessageBox.Show("Handle after save cliente " + cliente.Nome);
        }
    }
}
