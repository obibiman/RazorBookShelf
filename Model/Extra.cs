using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookListWeb.Model
{
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
}
