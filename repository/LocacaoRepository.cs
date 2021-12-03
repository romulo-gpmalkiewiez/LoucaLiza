using LoucaLiza.model.locacao;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LoucaLiza.repository
{
    public class LocacaoRepository : IRepository<Locacao, LocacaoFilter>
    {
        private IEnumerable<Locacao> AddRestriction<T>(IEnumerable<Locacao> list, T obj, Func<Locacao, bool> predicate)
        {
            if (obj == null)
            {
                return list;
            }

            if (obj is string && string.IsNullOrEmpty(obj.ToString()))
            {
                return list;
            }

            return list.Where(predicate);
        }

        public List<Locacao> GetAll(LocacaoFilter filter)
        {
            IEnumerable<Locacao> locacoes = Application.Database.Locacoes.AsEnumerable();

            locacoes = AddRestriction(locacoes, filter.Cliente, l => l.Cliente.Nome.Contains(filter.Cliente));
            locacoes = AddRestriction(locacoes, filter.Documento, l => l.Cliente.Cpf.Contains(filter.Documento) || l.Cliente.Cnh.Contains(filter.Documento));
            locacoes = AddRestriction(locacoes, filter.DataDe, l => l.DataLocacao > filter.DataDe);
            locacoes = AddRestriction(locacoes, filter.DataAte, l => l.DataLocacao < filter.DataAte);
            locacoes = AddRestriction(locacoes, filter.Marca, l => l.Veiculo.Marca.Contains(filter.Marca));
            locacoes = AddRestriction(locacoes, filter.Modelo, l => l.Veiculo.Modelo.Contains(filter.Modelo));
            locacoes = AddRestriction(locacoes, filter.Placa, l => l.Veiculo.Placa.Contains(filter.Placa));
            locacoes = AddRestriction(locacoes, filter.Status, l => l.Veiculo.Locado == filter.Status);

            return locacoes.ToList();
        }

        public bool Delete(Locacao locacao)
        {
            return Application.Database.Locacoes.Remove(locacao);
        }

        public Locacao Save(Locacao locacao)
        {
            if (locacao == null)
            {
                return null;
            }

            if (locacao.Id == null)
            {
                locacao.Id = Application.Database.GenerateId();
                Application.Database.Locacoes.Add(locacao);
            }
            else
            {
                Application.Database.Locacoes[Application.Database.Locacoes.IndexOf(locacao)] = locacao;
            }

            return locacao;
        }
    }
}
