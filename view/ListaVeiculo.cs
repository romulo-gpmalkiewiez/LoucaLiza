﻿using LoucaLiza.utils;
using System.Windows.Forms;

namespace LoucaLiza.view
{
    public partial class ListaVeiculo : Form
    {
        private Form _sourceForm;
        public ListaVeiculo(Form sourceForm)
        {
            InitializeComponent();
            _sourceForm = sourceForm;
        }
    }
}
