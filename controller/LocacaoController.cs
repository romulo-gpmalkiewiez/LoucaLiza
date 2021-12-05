using LoucaLiza.model.locacao;
using LoucaLiza.repository;
using System.Collections.Generic;

namespace LoucaLiza.controller
{
    public class LocacaoController : IController<Locacao>
    {
        private LocacaoRepository repository = new LocacaoRepository();

        public List<Locacao> GetAll()
        {
            return repository.FindAll();
        }

        public List<Locacao> GetAll(IFilter<Locacao> filter)
        {
            return repository.FindAll((LocacaoFilter)filter);
        }

        public Locacao Save(Locacao locacao)
        {
            locacao.ValorDiaria = locacao.Veiculo.ValorDiaria;
            return repository.Save(locacao);
        }

        public bool Delete(Locacao locacao)
        {
            return repository.Delete(locacao);
        }
    }
}
