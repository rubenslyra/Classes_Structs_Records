namespace GerenciamentoMemoria
{
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
}