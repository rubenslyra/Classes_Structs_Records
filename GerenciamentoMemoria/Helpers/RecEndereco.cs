namespace GerenciamentoMemoria
{

    // Note a forma como o parametro é passado, como se a classe fosse o próprio construtor.
    // Se uma instância da classe for criada, não será possível modificar o valor do parâmetro.
    // Dentro de uma DTO, o melhor é usar o record, pois ele é imutável. 

    public record RecEndereco(string Rua, int numero, string Bairro, string Cidade, string Estado, int CEP)
    {
        public int Telefone { get; set; }
    }
}