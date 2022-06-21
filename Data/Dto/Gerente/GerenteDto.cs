namespace FilmesAPI.Data.Dto
{
    public class CreateGerenteDto
    {
        public string Nome { get; set; }
    }

    public class ReadGerenteDto
    {
        public int Id { get; set; }
        public string  Nome { get; set; }
        public object Cinemas { get; set; }
    }
}
