using System;

namespace Loucaliza.model.veiculo
{
    public class Veiculo
    {
        public int? Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public int Ano { get; set; }
        public Cor Cor { get; set; }
        public string Chassi { get; set; }
        public int Quilometragem { get; set; }
        public double ValorDiario { get; set; }
        public bool Locado { get; set; }

        public override string ToString()
        {
            return String.Format("{0} - {1} {2}", Id, Marca, Modelo);
        }
    }
}
