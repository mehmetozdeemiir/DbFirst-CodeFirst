using Lab3_CodeFirst_Library.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_CodeFirst_Library.Entities.Concrete
{
   public class Products : BaseEntity<int>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get ; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public int QuantityPerUnit { get; set; }
        [Required]
        public int UnitPrice { get; set; }
        [Required]
        public int UnitInStock { get; set; }
        [Required]
        public int UnitOnOrder { get; set; }
        [Required]
        public int RecorderLevel { get; set; }
        [Required]
        public bool Discontinued { get; set; }

        [ForeignKey("Suppliers")]
        public int SupplierId;
        public virtual Suppliers Supliers { get; set; }

        [ForeignKey("Categories")]
        public int CategoriyId;
        public virtual Categories Categories { get; set; }
        
        public virtual List<OrderDetails> OrderDetailss { get; set; }












    }
}
