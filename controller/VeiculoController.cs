using Loucaliza.model.veiculo;
using LoucaLiza.repository;
using System.Collections.Generic;

namespace LoucaLiza.controller
{
    public class VeiculoController : IController<Veiculo>
    {
        private VeiculoRepository repository = new VeiculoRepository();

        public List<Veiculo> GetAll()
        {
            return repository.FindAll();
        }

        public List<Veiculo> GetAll(IFilter<Veiculo> filter)
        {
            return repository.FindAll((VeiculoFilter)filter);
        }

        public Veiculo Save(Veiculo veiculo)
        {
            return repository.Save(veiculo);
        }

        public bool Delete(Veiculo veiculo)
        {
            return repository.Delete(veiculo);
        }
    }
}
