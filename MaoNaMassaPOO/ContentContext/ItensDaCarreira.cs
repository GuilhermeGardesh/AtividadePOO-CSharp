namespace MaoNaMassaPOO.ContentContext
{
    public class ItensDaCarreira
    {
        public ItensDaCarreira(
            int ordem, 
            string titulo, 
            string descricao, 
            Curso curso)
        {
            if (curso == null)
                throw new System.Exception("o curso não pode ser nulo");

            Ordem = ordem;
            Titulo = titulo;
            Descricao = descricao;
            Curso = curso;
        }

        public int Ordem { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public Curso Curso { get; set; }
    }
}
