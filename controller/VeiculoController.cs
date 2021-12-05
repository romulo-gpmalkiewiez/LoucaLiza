using Loucaliza.model.veiculo;
using LoucaLiza.repository;
using System.Collections.Generic;

namespace LoucaLiza.controller
{
    public class VeiculoController : IController<Veiculo>
    {
        private VeiculoRepository repository = new VeiculoRepository();

        public Veiculo Save(Veiculo veiculo)
        {
            return repository.Save(veiculo);
        }

        public bool Delete(Veiculo veiculo)
        {
            return repository.Delete(veiculo);
        }

        public List<Veiculo> GetByFilter(IFilter<Veiculo> filter)
        {
            return repository.FindAll((VeiculoFilter) filter);
        }
    }
}
