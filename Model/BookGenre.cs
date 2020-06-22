using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookListWeb.Model
{
    public class BookGenre
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Genre"), MaxLength(30), DataType(DataType.Text), Column(TypeName = "varchar(30)")]
        public string GenreName { get; set; }
    }
}
