using LoucaLiza.model.cliente;
using System.Collections.Generic;

namespace LoucaLiza.repository
{
    public class ClienteRepository : IRepository<Cliente, ClienteFilter>
    {
        public List<Cliente> GetAll(ClienteFilter filter)
        {
            throw new System.NotImplementedException();
        }

        public bool Delete(Cliente cliente)
        {
            return Application.Database.Clientes.Remove(cliente);
        }

        public Cliente Save(Cliente cliente)
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
