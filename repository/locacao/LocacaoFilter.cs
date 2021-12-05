using LoucaLiza.model.locacao;
using System;

namespace LoucaLiza.repository
{
    public class LocacaoFilter : IFilter<Locacao>
    {
        public string Cliente { get; set; }
        public string Documento { get; set; }
        public DateTime? DataDe { get; set; }
        public DateTime? DataAte { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public bool? Status { get; set; }
    }
}
