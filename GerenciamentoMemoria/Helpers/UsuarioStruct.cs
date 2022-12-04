namespace GerenciamentoMemoria
{
    public struct UsuarioStruct
    {
        public UsuarioStruct(string nome, string email, ClasseEndereco endereco)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Email = email;
            DataCadastro = DateTime.UtcNow;

        }
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTimeOffset DataCadastro { get; set; }
        //public ClasseEndereco Endereco { get; set; }
    }

}
