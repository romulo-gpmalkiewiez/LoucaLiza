using Loucaliza.model.veiculo;
using LoucaLiza.utils;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LoucaLiza.repository
{
    public class VeiculoRepository : AbstractRepository<Veiculo, VeiculoFilter>
    {
        public override List<Veiculo> FindAll()
        {
            return Application.Database.Veiculos.ToList();
        }

        public override List<Veiculo> FindAll(VeiculoFilter filter)
        {
            var veiculos = Application.Database.Veiculos.AsEnumerable();

            veiculos = AddRestriction(veiculos, filter.Marca, v => StringUtils.ContainIgnoreCase(v.Marca, filter.Marca));
            veiculos = AddRestriction(veiculos, filter.Modelo, v => StringUtils.ContainIgnoreCase(v.Modelo, filter.Modelo));
            veiculos = AddRestriction(veiculos, filter.Placa, v => StringUtils.ContainIgnoreCase(v.Placa, filter.Placa));
            veiculos = AddRestriction(veiculos, filter.Status, v => v.Locado == filter.Status);

            return veiculos.ToList(); ;
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
