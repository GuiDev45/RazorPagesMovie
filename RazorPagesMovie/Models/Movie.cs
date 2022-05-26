using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Models
{
    public class Movie
    {
        //O campo ID é necessário para o banco de dados para a chave primária.
        public int ID { get; set; }
        public string Title { get; set; } = string.Empty;

        //O usuário não precisa inserir informações de hora no campo de data.
        //Somente a data é exibida, não as informações de tempo.
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; } = string.Empty;
        public decimal Price { get; set; }
    }
}
