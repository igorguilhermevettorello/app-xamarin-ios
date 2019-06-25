namespace ConectaCampoBom.Base
{

    public class NoticiasBaseJson
    {
        public string status { get; set; }
        public string msg { get; set; }
        public Dado[] dados { get; set; }
    }

    public class Dado
    {
        public string id { get; set; }
        public string titulo { get; set; }
        public string imagem { get; set; }
        public string reportagem { get; set; }
        public string data_hora { get; set; }
    }

}
