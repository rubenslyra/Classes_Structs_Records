using System;

namespace GerenciamentoMemoria
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gerenciamento de Memória - C#");
        }

        public struct Endereco
        {
            public string Rua;
            public string Cidade;
            public string Estado;
            public string CEP;

            // Nesse caso, a variável Endereco é um tipo de valor, e não um tipo de referência.
        }

        static void Teste()
        {
            int[] numeros = new int[100000000];
        }
    }
}
