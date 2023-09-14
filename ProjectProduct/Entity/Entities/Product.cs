using System.ComponentModel.DataAnnotations;

namespace EntityLayer
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        [StringLength(50)]
        public string ProductName { get; set; }
        public int Stock { get; set; }

        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }

    }
}