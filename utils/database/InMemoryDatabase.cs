using Loucaliza.model.veiculo;
using LoucaLiza.model.cliente;
using LoucaLiza.model.locacao;
using System.Collections.Generic;

namespace LoucaLiza.utils.database
{
    public class InMemoryDatabase
    {
        public List<Cliente> Clientes = new List<Cliente>();
        public List<Veiculo> Veiculos = new List<Veiculo>();
        public List<Locacao> Locacoes = new List<Locacao>();

        private int NextId = 1;

        public int GenerateId()
        {
            return NextId++;
        }
    }
}
