using System;

namespace BookListWeb.Model
{
    public interface IAuditable
    {
        string ModifiedBy { get; set; }
        DateTime? ModifiedDate { get; set; }
        string CreatedBy { get; set; }
        DateTime CreatedDate { get; set; }
        byte[] RowVersion { get; set; }
    }
}
