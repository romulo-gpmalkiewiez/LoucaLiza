using LoucaLiza.model.locacao;
using System;
using System.Collections.Generic;

namespace LoucaLiza.repository
{
    public class LocacaoRepository : IRepository<Locacao>
    {
        public void Delete(Locacao Entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Locacao> GetAll()
        {
            throw new NotImplementedException();
        }

        public Locacao GetById(int Id)
        {
            throw new NotImplementedException();
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
