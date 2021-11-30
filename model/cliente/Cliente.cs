using System;

namespace LoucaLiza.model.cliente
{
    public class Cliente
    {
        public int? Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Cnh { get; set; }
        public string Email { get; set; }
        public DateTime? DataNascimento { get; set; }
        public Telefone Telefone { get; set; }
        public Endereco Endereco { get; set; }

        public int Age()
        {
            int today = int.Parse(DateTime.Now.ToString("yyyyMMdd"));
            int birth = int.Parse(DataNascimento?.ToString("yyyyMMdd"));
            return (today - birth) / 10000;
        }

        public override string ToString()
        {
            return String.Format("{0} {1} {2}", Id, Nome, Cpf);
        }
    }
}
