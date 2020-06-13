using System;
using System.ComponentModel.DataAnnotations;

namespace BookListWeb.Model
{
    public abstract class Commonbase
    {
        public string CreatedBy { get; set; }
        [Required(ErrorMessage = "Created date is a required field")]
        [Display(Order = 5, Name = "Created Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime CreatedDate { get; set; }
        [Display(Name = "Modified By")]
        public string ModifiedBy { get; set; }
        [Display(Name = "Modified Date", Order = 4)]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? ModifiedDate { get; set; }
        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}
