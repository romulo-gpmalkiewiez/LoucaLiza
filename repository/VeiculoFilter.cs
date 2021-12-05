using Loucaliza.model.veiculo;

namespace LoucaLiza.repository
{
    public class VeiculoFilter : IFilter<Veiculo>
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public bool? Status { get; set; }
    }
}
