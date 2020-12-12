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
    public class Orders : BaseEntity<int>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get ; set ; }
        [Required]
        public DateTime OrderDate { get; set; }
        [Required]
        public DateTime RequiredDate { get; set; }
        [Required]
        public DateTime ShippedDate { get; set; }
        [Required]
        public string ShipVia { get; set; }
        [Required]
        public string Freight { get; set; }
        [Required]
        public string ShipName { get; set; }
        [Required]
        public string ShipAdress { get; set; }
        [Required]
        public string ShipCity { get; set; }
        [Required]
        public string Region { get; set; }
        [Required]
        public int ShipPostalCode { get; set; }
        [Required]
        public string ShipCountry { get; set; }
        [ForeignKey("Employees")]
        public int EmployeeId { get; set; }
        public virtual Employees Employees { get; set; }
        [ForeignKey("Customers")]
        public int CustomerId { get; set; }
        public virtual Customers Customers { get; set; }
        [ForeignKey("Shippers")]
        public int ShippersId { get; set; }
        public virtual Shippers Shippers { get; set; }

        public virtual List<OrderDetails> Orderdetailss { get; set; }
    }
}
