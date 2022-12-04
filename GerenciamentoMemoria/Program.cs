using System;

namespace GerenciamentoMemoria
{
    class Program
    {
        static void Main(string[] args)
        {
            var record = new RecEndereco("Rua 1", 123, "Cidade 1", "Bairro 1", "Estado 1", 45002654);
            record.Telefone = 123456789;
            Console.WriteLine($"Dados obtidos na classe {record}");
            Console.WriteLine("Gerenciamento de Memória - C#");
            Console.ReadKey();
        }

        /// <summary>Caso de uso: STRUCT</summary>
        /// <remarks>Structs são tipos de valor, ou seja, são armazenados na pilha de execução.</remarks>
        /// <remarks>Structs são mais rápidos que classes, pois são armazenados na pilha de execução.</remarks>
        /// <remarks>Structs não podem ser herdadas.</remarks>
        /// <remarks>Structs não podem ter construtores sem parâmetros.</remarks>
        /// <remarks>Structs não podem ter membros:
        ///         destrutores, estáticos, abstratos, virtuais, protegidos, internos, protegidos internos, privados, protegidos privados.</remarks>

        public struct StructEndereco
        {

            // Nesse caso, a variável Endereco é um tipo de valor, e não um tipo de referência.
            public string Rua;
            public string Cidade;
            public string Estado;
            public string CEP;


            //  inicialização de variáveis de instância em um construtor
            public StructEndereco(string rua, string cidade, string estado, string cep)
            {
                Rua = rua;
                Cidade = cidade;
                Estado = estado;
                CEP = cep;
            }

        }

        /// <summary>Caso de uso: CLASSE</summary>
        /// <remarks>Classes são tipos de referência, ou seja, são armazenados na pilha de execução.</remarks>

        public class ClasseEndereco
        {

            // Nesse caso, a variável Endereco é um tipo de valor, e não um tipo de referência.
            public string Rua;
            public string Cidade;
            public string Estado;
            public string CEP;


            //  inicialização de variáveis de instância em um construtor
            public ClasseEndereco(string rua, string cidade, string estado, string cep)
            {
                Rua = rua;
                Cidade = cidade;
                Estado = estado;
                CEP = cep;
            }

        }



        public struct UsuarioStruct
        {
            public UsuarioStruct(string nome, string email, DateTime datanasc, ClasseEndereco endereco)
            {
                Nome = nome;
                Email = email;
                DataNascimento = datanasc;
                DataCadastro = DateTime.UtcNow;
                Endereco = endereco;
            }
            public int Id { get; set; }
            public string Nome { get; set; }
            public string Email { get; set; }
            public DateTime DataNascimento { get; set; }

            public DateTime DataCadastro { get; set; }
            public ClasseEndereco Endereco { get; set; }
        }


        public class ClasseUsuario
        {
            public int Id { get; set; }
            public string Nome { get; set; }

            //  inicialização de variáveis de instância em um construtor
            public ClasseUsuario(int id, string nome)
            {
                Id = id;
                Nome = nome;
            }
        }

        // Note a forma como o parametro é passado, como se a classe fosse o próprio construtor.
        // Se uma instância da classe for criada, não será possível modificar o valor do parâmetro.
        public record RecEndereco(string Rua, int numero, string Bairro, string Cidade, string Estado, int CEP)
        {
            public int Telefone { get; set; }
        }

        // Dentro de uma DTO, o melhor é usar o record, pois ele é imutável. 



        // Observe a diferença de comportamento entre Struct e Classe em relação ao uso de memória.
    }
}
