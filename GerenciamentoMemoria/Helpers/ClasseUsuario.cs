namespace GerenciamentoMemoria
{
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
}