using Loucaliza.model.veiculo;
using LoucaLiza.repository;
using System.Collections.Generic;

namespace LoucaLiza.controller
{
    public class VeiculoController : IController<Veiculo>
    {
        private readonly VeiculoRepository _repository = new VeiculoRepository();

        public List<Veiculo> GetAll()
        {
            return _repository.FindAll();
        }

        public List<Veiculo> GetAll(IFilter<Veiculo> filter)
        {
            return _repository.FindAll((VeiculoFilter) filter);
        }

        public Veiculo Save(Veiculo veiculo)
        {
            return _repository.Save(veiculo);
        }

        public bool Delete(Veiculo veiculo)
        {
            return _repository.Delete(veiculo);
        }
    }
}
