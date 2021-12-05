using LoucaLiza.model.cliente;
using LoucaLiza.repository;
using System.Collections.Generic;

namespace LoucaLiza.controller
{
    class ClienteController : IController<Cliente>
    {
        private readonly ClienteRepository _repository = new ClienteRepository();

        public List<Cliente> GetAll()
        {
            return _repository.FindAll();
        }

        public List<Cliente> GetAll(IFilter<Cliente> filter)
        {
            return _repository.FindAll((ClienteFilter) filter);
        }

        public Cliente Save(Cliente cliente)
        {
            return _repository.Save(cliente);    
        }

        public bool Delete(Cliente entity)
        {
            return _repository.Delete(entity);
        }
    }
}
