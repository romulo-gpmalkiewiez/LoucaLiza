using LoucaLiza.model.cliente;
using LoucaLiza.utils;
using System.Collections.Generic;
using System.Linq;

namespace LoucaLiza.repository
{
    public class ClienteRepository : AbstractRepository<Cliente, ClienteFilter>
    {
        public override List<Cliente> FindAll()
        {
            return Application.Database.Clientes;
        }

        public override List<Cliente> FindAll(ClienteFilter filter)
        {
            var clientes = Application.Database.Clientes.AsEnumerable();

            clientes = AddRestriction(clientes, filter.Nome, c => StringUtils.ContainIgnoreCase(c.Nome, filter.Nome));
            clientes = AddRestriction(clientes, filter.Cpf, c => StringUtils.ContainIgnoreCase(c.Cpf, filter.Cpf));
            clientes = AddRestriction(clientes, filter.Cnh, c => StringUtils.ContainIgnoreCase(c.Cnh, filter.Cnh));

            return clientes.ToList();
        }

        public override bool Delete(Cliente cliente)
        {
            return Application.Database.Clientes.Remove(cliente);
        }

        public override Cliente Save(Cliente cliente)
        {
            if (cliente == null)
            {
                return null;
            }

            if (cliente.Id == null)
            {
                cliente.Id = Application.Database.GenerateId();
                Application.Database.Clientes.Add(cliente);
            }
            else
            {
                Application.Database.Clientes[Application.Database.Clientes.IndexOf(cliente)] = cliente;
            }

            return cliente;
        }
    }
}
