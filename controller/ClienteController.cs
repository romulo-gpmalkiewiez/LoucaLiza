using LoucaLiza.model.cliente;
using LoucaLiza.repository;
using System.Collections.Generic;

namespace LoucaLiza.controller
{
    class ClienteController : IController<Cliente>
    {
        private ClienteRepository repository = new ClienteRepository();

        public Cliente Save(Cliente cliente)
        {
            return repository.Save(cliente);    
        }

        public bool Delete(Cliente entity)
        {
            return repository.Delete(entity);
        }

        public List<Cliente> GetByFilter(IFilter<Cliente> filter)
        {
            return repository.FindAll((ClienteFilter) filter);
        }
    }
}
