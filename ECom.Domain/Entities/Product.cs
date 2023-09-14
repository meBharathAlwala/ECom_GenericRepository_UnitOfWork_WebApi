using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECom.Domain.Entities
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string? ProductName { get; set; }
        public string? ProductDescription { get; set; }
        public string? ProductType { get; set; }

    }
}
