namespace GerenciamentoMemoria
{


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



}