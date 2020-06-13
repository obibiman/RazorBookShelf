using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookListWeb.Model
{
    public class Book : Commonbase
    {
        [Key]
        [Display(Order=0)]
        public int Id { get; set; }
        [Required (ErrorMessage ="Name is a required field")]
        [Display(Name = "Book Name", Order = 1), MaxLength(200)]
        public string Name { get; set; }
        [Display(Name = "Author's Name", Order = 2), MaxLength(100)]
        public string  Author { get; set; }
        [Display(Name = "Publication Year"), MaxLength(4), DataType(DataType.Text), Column(TypeName = "varchar(4)")]
        public string Year { get; set; }
        [RegularExpression(@"^\d{10}(\d{3})?$", ErrorMessage = "ISBN must be contain either 10 or 13 digits only")]
        public string ISBN { get; set; }
        [Display(Name = "# Pages")]
        public int? PageCount { get; set; }
        [Column(TypeName = "varchar(20)"), DataType(DataType.Text)]
        public string Genre { get; set; }
        [Column(TypeName = "decimal(9, 2)")]
        [DataType(DataType.Currency)]
        public decimal? Price { get; set; }
        [Column(TypeName = "varchar(55)"), DataType(DataType.Text)]
        public string Publisher { get; set; }
        [Column(TypeName = "varchar(2000)")]
        public string Description { get; set; }
        [Column(TypeName = "varchar(200)"), Display(Name = "Subtitle")]
        public string SubTitle { get; set; }
        public byte[] Photo { get; set; }
        [Column(TypeName = "varchar(15)"), Display(Name = "Edition")]
        public string Edition { get; set; }
        public ICollection<BookAuthor> BookAuthors { get; set; }
    }
}