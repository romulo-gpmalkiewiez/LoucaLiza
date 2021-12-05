using Loucaliza.model.veiculo;
using System;
using System.Collections.Generic;

namespace LoucaLiza.repository
{
    public class VeiculoRepository : AbstractRepository<Veiculo, VeiculoFilter>
    {
        public override List<Veiculo> FindAll()
        {
            throw new NotImplementedException();
        }

        public override List<Veiculo> FindAll(VeiculoFilter filter)
        {
            throw new NotImplementedException();
        }

        public override bool Delete(Veiculo veiculo)
        {
            return Application.Database.Veiculos.Remove(veiculo);
        }

        public override Veiculo Save(Veiculo veiculo)
        {
            if (veiculo == null)
            {
                return null;
            }

            if (veiculo.Id == null)
            {
                veiculo.Id = Application.Database.GenerateId();
                Application.Database.Veiculos.Add(veiculo);
            }
            else
            {
                Application.Database.Veiculos[Application.Database.Veiculos.IndexOf(veiculo)] = veiculo;
            }

            return veiculo;
        }
    }
}
