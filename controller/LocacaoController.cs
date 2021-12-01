using LoucaLiza.model.locacao;
using LoucaLiza.repository;

namespace LoucaLiza.controller
{
    public class LocacaoController : IController<Locacao>
    {
        private LocacaoRepository repository = new LocacaoRepository();

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
