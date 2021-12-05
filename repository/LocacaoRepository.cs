using LoucaLiza.model.locacao;
using System;
using System.Collections.Generic;
using System.Linq;
using LoucaLiza.utils;

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

            locacoes = AddRestriction(locacoes, filter.Cliente, loc => StringUtils.ContainIgnoreCase(loc.Cliente.Nome, filter.Cliente));
            locacoes = AddRestriction(locacoes, filter.Documento, loc => StringUtils.ContainIgnoreCase(loc.Cliente.Cpf, filter.Documento) || StringUtils.ContainIgnoreCase(loc.Cliente.Cnh, filter.Documento));
            locacoes = AddRestriction(locacoes, filter.DataDe, loc => loc.DataLocacao?.Date >= filter.DataDe?.Date);
            locacoes = AddRestriction(locacoes, filter.DataAte, loc => loc.DataLocacao?.Date <= filter.DataAte?.Date);
            locacoes = AddRestriction(locacoes, filter.Marca, loc => StringUtils.ContainIgnoreCase(loc.Veiculo.Marca, filter.Marca));
            locacoes = AddRestriction(locacoes, filter.Modelo, loc => StringUtils.ContainIgnoreCase(loc.Veiculo.Modelo, filter.Modelo));
            locacoes = AddRestriction(locacoes, filter.Placa, loc => StringUtils.ContainIgnoreCase(loc.Veiculo.Placa, filter.Placa));
            locacoes = AddRestriction(locacoes, filter.Status, loc => loc.Veiculo.Locado == filter.Status);

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
