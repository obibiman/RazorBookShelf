using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookListWeb.Model
{
    public class BookGenre : Commonbase
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Genre"), MaxLength(20), DataType(DataType.Text), Column(TypeName = "varchar(20)")]
        public string Genre { get; set; }
    }
}
