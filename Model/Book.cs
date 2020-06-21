using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookListWeb.Model
{
    public class Book
    {
        [Key]
        [Display(Order=0)]
        public int Id { get; set; }
        [Required (ErrorMessage ="Name is a required field")]
        [Display(Name = "Book Name", Order = 1), MaxLength(200)]
        public string Name { get; set; }
        [Display(Name = "Author's Name", Order = 2), MaxLength(100)]
        public string  Author { get; set; }
        [Display(Order = 3, Name="Created By")]
        public string CreatedBy { get; set; }
        [Required(ErrorMessage = "Created date is a required field")]
        [Display(Order = 5, Name="Created Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime CreatedDate { get; set; }
        [Display(Name = "Modified By")]
        public string ModifiedBy { get; set; }
        [Display(Name = "Modified Date", Order = 4)]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? ModifiedDate { get; set; }
        [Display(Name = "Year Published", Order = 6), StringLength(4)]
        public string Year { get; set; }
        [RegularExpression(@"^\d{10}(\d{3})?$", ErrorMessage = "ISBN must be contain either 10 or 13 digits only")]
        public string ISBN { get; set; }
        [Display(Name = "# Pages")]
        public int? PageCount { get; set; }
        [Column(TypeName = "varchar(20)")]
        public string Genre { get; set; }
        [Column(TypeName = "decimal(9, 2)")]
        [DataType(DataType.Currency)]
        public decimal? Price { get; set; }
        [Column(TypeName = "varchar(55)")]
        public string Publisher { get; set; }
        [Column(TypeName = "varchar(2000)")]
        public string Description { get; set; }
        [Column(TypeName = "varchar(200)"), Display(Name = "Subtitle")]
        public string SubTitle { get; set; }
        public byte[] Photo { get; set; }
        [Column(TypeName = "varchar(10)")]

        public string PhotoPath { get; set; }         
        public string Edition { get; set; }
        [Timestamp]
        public byte[] RowVersion { get; set; }
    }

    public class Extra
    {
        public int? PageCount { get; set; }
        [Column(TypeName = "varchar(20)")]
        public string Genre { get; set; }
        [Column(TypeName = "decimal(9, 2)")]
        public decimal? Price { get; set; }
        [Column(TypeName = "varchar(55)")]
        public string Publisher { get; set; }
        [Column(TypeName = "varchar(2000)")]
        public string Description { get; set; }
        [Column(TypeName = "varchar(200)")]
        public string SubTitle { get; set; }
        public byte[] Photo { get; set; }
        [Column(TypeName = "varchar(10)")]
        public string Edition { get; set; }
        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
    public class BookGenre
    {
        public int Id { get; set; }
        public string GenreName { get; set; }
    }
}
