using LoucaLiza.model.cliente;
using System.Collections.Generic;

namespace LoucaLiza.repository
{
    public class ClienteRepository : IRepository<Cliente>
    {
        public bool Delete(Cliente cliente)
        {
            return Application.Database.Clientes.Remove(cliente);
        }

        public List<Cliente> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Cliente GetById(int Id)
        {
            throw new System.NotImplementedException();
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
