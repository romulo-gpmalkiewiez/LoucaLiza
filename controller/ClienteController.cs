using LoucaLiza.model.cliente;
using LoucaLiza.repository;

namespace LoucaLiza.controller
{
    class ClienteController : IController<Cliente>
    {
        private ClienteRepository repository = new ClienteRepository();

        public Cliente Save(Cliente cliente)
        {
            return repository.Save(cliente);    
        }
    }
}
