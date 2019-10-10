using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using SGC.ApplicationCore.Entity;

namespace SGC.Infrastructure.Data
{
    public static class DbInitializer
    {
        public static void Initializer(ClienteContext context)
        {
            if (context.Clientes.Any())
                return;

            var clientes = new Cliente[]
            {
                new Cliente
                {
                    Nome = "Fulano da Silva",
                    CPF = "11111111111"
                },
                new Cliente
                {
                    Nome = "Beltrano da Silva",
                    CPF = "22222222222"
                }
            };

            context.AddRange(clientes);

            var contatos = new Contato[]
            {
                new Contato
                {
                    Nome = "Contato 1",
                    Telefone = "111111111",
                    Email = "emailcontato1@teste.com",
                    Cliente = clientes[0]
                },
                new Contato
                {
                    Nome = "Contato 2",
                    Telefone = "222222222",
                    Email = "emailcontato2@teste.com",
                    Cliente = clientes[1]
                }
            };

            context.AddRange(contatos);

            context.SaveChanges();
        }
    }
}
