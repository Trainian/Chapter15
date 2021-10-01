using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Packt.Shared
{
    public class Category
    {
        public int CategoryID { get; set; }
        
        [Required]
        [StringLength(15)]
        public string CategoryName { get; set; }
        public string Description { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}