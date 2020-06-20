using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookListWeb.Model
{
    public class Author : Commonbase
    {
        [Key]
        [Display(Order = 0)]
        public int Id { get; set; }
        [Required(ErrorMessage = "First Name is a required field")]
        [Display(Name = "First Name", Order = 1), MaxLength(200), DataType(DataType.Text), Column(TypeName = "varchar(200)")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last Name is a required field")]
        [Display(Name = "Last Name", Order = 2), MaxLength(200), DataType(DataType.Text), Column(TypeName = "varchar(200)")]
        public string LastName { get; set; }
        [Display(Name = "Middle Name", Order = 3), MaxLength(100), DataType(DataType.Text), Column(TypeName = "varchar(100)")]
        public string MiddleName { get; set; }
        public ICollection<BookAuthor> BookAuthors { get; set; }
        [NotMapped, Display(Name = "Full Name")]
        public string FullName
        {
            get { return FirstName + " " + MiddleName ?? " " + LastName; }
        }
    }
}


