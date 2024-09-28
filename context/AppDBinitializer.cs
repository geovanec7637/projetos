using cadastrocli.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;

namespace cadastrocli.context
{
    public class AppDBinitializer
    {
        public static void Seed(IApplicationBuilder applicationbuilder)
        {
            using (var serviceScope = applicationbuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<principal>();
                context.Database.EnsureCreated();

                if (!context.clientes.Any())
                {
                    context.clientes.AddRange(new List<Cliente>()
                    {
                        new Cliente()
                        {
                            Nome = "Karlos",
                            Email = "karloseduardo@gmail.com",
                            Cpf = "56735627598",
                            Cidade = "São Paulo",
                            Rua = "Aristonides Nogueira",
                            Bairro = "Centro",  // Adicionando um valor para Bairro
                            Estado = "SP",
                            Telefone = "11987654321"  // Adicione um valor para Telefone
                        },
                        new Cliente()
                        {
                            Nome = "Geovane",
                            Email = "gevane@gmail.com",
                            Cpf = "79368937898",
                            Cidade = "Xiqui Xiqui",
                            Rua = "Rua Doutor Miguel Francisco",
                            Bairro = "Bairro Novo",  // Adicionando um valor para Bairro
                            Estado = "BA",
                            Telefone = "11976543210"  // Adicione um valor para Telefone
                        },
                        new Cliente()
                        {
                            Nome = "Rodolfo",
                            Email = "rodolfomadeiradelei@gmail.com",
                            Cpf = "24576489789",
                            Cidade = "Rocambole",
                            Rua = "Rodrigo Alfedro",
                            Bairro = "Bairro Velho",  // Adicionando um valor para Bairro
                            Estado = "BH",
                            Telefone = "11965432100"  // Adicione um valor para Telefone
                        }
                    });

                    context.SaveChanges();
                }
            }
        }
    }
}
