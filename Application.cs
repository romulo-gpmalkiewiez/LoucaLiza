using LoucaLiza.repository;
using LoucaLiza.utils;
using LoucaLiza.utils.database;
using System;

namespace LoucaLiza
{
    static class Application
    {
        public static readonly InMemoryDatabase Database = new InMemoryDatabase();

        [STAThread]
        static void Main()
        {
            InitDefaultModels();

            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            System.Windows.Forms.Application.Run(new ListaLocacao());
        }

        static void InitDefaultModels()
        {
            new ClienteRepository().Save(ModelUtils.ClienteRomulo());
            new VeiculoRepository().Save(ModelUtils.Mustang());
            new LocacaoRepository().Save(ModelUtils.RomuloAlugaMustang());
        }
    }
}
