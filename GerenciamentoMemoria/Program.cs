using System;

namespace GerenciamentoMemoria
{
    class Program
    {
        static void Main(string[] args)
        {
            var record = new RecEndereco("Rua 1", 123, "Cidade 1", "Bairro 1", "Estado 1", 45002654);
            record.Telefone = 123456789;

            var pessoa = new ClasseUsuario(1, "João");

            var usuario = new UsuarioStruct();
            usuario.Id = Guid.NewGuid();
            usuario.Nome = "João";
            usuario.Email = "joao@email.com";
            usuario.DataCadastro = DateTimeOffset.Now;


            Console.WriteLine($"Dados obtidos na classe {record}");


            Console.WriteLine($$"""
                                ---------------------------------
                                Dados obtidos na struct {{usuario}}
                                ---------------------------------
                                Id: {{usuario.Id}}
                                Nome: {{usuario.Nome}}
                                Email: {{usuario.Email}}
                                Data de Cadastro: {{usuario.DataCadastro}}
                            """);

            Console.WriteLine("Gerenciamento de Memória - C#");
            Console.ReadKey();
        }
        // Observe a diferença de comportamento entre Struct e Classe em relação ao uso de memória.
    }
}
