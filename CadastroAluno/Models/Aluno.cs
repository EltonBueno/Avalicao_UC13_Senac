namespace CadastroAluno.Models
{
    public class Aluno
    {
        public Aluno(string nome, string turma, double media)
        {
            Nome = nome;
            Turma = turma;
            Media = media;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Turma { get; set; }
        public double Media { get; set; }

        public void AtualizarDados(string nome, string turma)
        {
            Nome = nome;
            Turma = turma;
        }

        public bool VerificaAprovacao() 
            => Media > 5;

        public void AtualizaMedia(double novaMedia)
        {
            Media = novaMedia;
        }
    }
}
