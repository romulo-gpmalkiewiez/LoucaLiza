using LoucaLiza.model.locacao;
using LoucaLiza.repository;

namespace LoucaLiza.controller
{
    public class LocacaoController : IController<Locacao>
    {
        private LocacaoRepository repository = new LocacaoRepository();

        public Locacao Save(Locacao locacao)
        {
            return repository.Save(locacao);
        }
    }
}
