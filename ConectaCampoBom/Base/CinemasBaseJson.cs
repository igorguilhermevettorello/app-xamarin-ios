namespace ConectaCampoBom.Base
{

    public class CinemasBaseJson
    {
        public string status { get; set; }
        public string msg { get; set; }
        public Dados dados { get; set; }
    }

    public class Dados
    {
        public Cinema cinema { get; set; }
        public Filmes[] filmes { get; set; }
    }

    public class Cinema
    {
        public string id { get; set; }
        public string descricao { get; set; }
    }

    public class Filmes
    {
        public Filme Filme { get; set; }
    }

    public class Filme
    {
        public string id { get; set; }
        public string cartaz { get; set; }
        public string descricao { get; set; }
        public string ativo { get; set; }
        public string titulo { get; set; }
    }

}
