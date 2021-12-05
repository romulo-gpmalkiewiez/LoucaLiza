using Loucaliza.model.veiculo;
using LoucaLiza.model.cliente;
using LoucaLiza.model.locacao;
using System;

namespace LoucaLiza.utils
{
    class ModelUtils
    {
        public static Cliente ClienteRomulo()
        {
            Cliente cliente = new Cliente();
            cliente.Nome = "Romulo";
            cliente.Cpf = "06812293903";
            cliente.Email = "romulogoelzer@gmail.com";
            cliente.Cnh = "123456789";
            cliente.DataNascimento = DateTime.Parse("21/09/1993");
            cliente.Endereco = new Endereco();
            cliente.Endereco.Logradouro = "Rua Petunia";
            cliente.Endereco.Numero = "157";
            cliente.Telefone = new Telefone();
            cliente.Telefone.Numero = "47997446416";

            return cliente;
        }

        public static Veiculo Mustang()
        {
            Veiculo veiculo = new Veiculo();
            veiculo.Cor = "Preta";
            veiculo.Marca = "Ford";
            veiculo.Modelo = "Mustang 5.0 V8 TI-VCT GT PREMIUM SELECTSHIFT";
            veiculo.Placa = "MUS74NG";
            veiculo.Renavam = "12664593490";
            veiculo.Quilometragem = 9000;
            veiculo.Ano = 2018;
            veiculo.ValorDiaria = 4480.5;

            return veiculo;
        }

        public static Locacao Alugar(Cliente cliente, Veiculo veiculo)
        {
            Locacao locacao = new Locacao();
            locacao.DataLocacao = DateTime.Now;
            locacao.Cliente = cliente;
            locacao.Veiculo = veiculo;
            locacao.ValorDiaria = locacao.Veiculo.ValorDiaria;
            locacao.Dias = 1;

            return locacao;
        }
    }
}
