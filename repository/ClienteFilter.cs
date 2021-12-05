using LoucaLiza.model.cliente;

namespace LoucaLiza.repository
{
    public class ClienteFilter : IFilter<Cliente>
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Cnh { get; set; }
    }
}
