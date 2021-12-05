using LoucaLiza.model.locacao;
using LoucaLiza.repository;
using System.Collections.Generic;

namespace LoucaLiza.controller
{
    public class LocacaoController : IController<Locacao>
    {
        private readonly LocacaoRepository _repository = new LocacaoRepository();

        public List<Locacao> GetAll()
        {
            return _repository.FindAll();
        }

        public List<Locacao> GetAll(IFilter<Locacao> filter)
        {
            return _repository.FindAll((LocacaoFilter) filter);
        }

        public Locacao Save(Locacao locacao)
        {
            if (locacao.Veiculo.Locado)
            {
                throw new BusinessException("Este veículo foi alugado por outro cliente!");
            }

            locacao.Veiculo.Locado = true;
            locacao.ValorDiaria = locacao.Veiculo.ValorDiaria;

            return _repository.Save(locacao);
        }

        public bool Delete(Locacao locacao)
        {
            return _repository.Delete(locacao);
        }
    }
}
