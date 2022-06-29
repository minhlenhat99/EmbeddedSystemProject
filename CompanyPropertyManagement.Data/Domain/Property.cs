using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace CompanyPropertyManagement.Data.Domain
{
    public class Property
    {
        public Guid Id { get; set; }
        public string Info { get; set; }
        public Guid CategoryId { get; set; }
        public Guid BuId { get; set; }
        // Navigation property
        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }
        [ForeignKey("BuId")]
        public virtual BU BU { get; set; }
    }
}
