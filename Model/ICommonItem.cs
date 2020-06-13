using System;
using System.ComponentModel.DataAnnotations;

namespace BookListWeb.Model
{
    public interface ICommonItem
    {
        string ModifiedBy { get; set; }
        DateTime? ModifiedDate { get; set; }
        string CreatedBy { get; set; }
        DateTime CreatedDate { get; set; }
        [Timestamp]

        byte[] RowVersion { get; set; }
    }
}
