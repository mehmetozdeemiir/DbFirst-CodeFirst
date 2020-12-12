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
    public class Employees : BaseEntity<int>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
         public override int Id { get ; set ; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Firstname { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string TitleOfCourtesy { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }
        [Required]
        public DateTime HireDate { get; set; }
        [Required]
        public string Adres { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string  Rgion { get; set; }
        [Required]
        public int PostalCode { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public string HomePhone { get; set; }
        [Required]
        public string Extension { get; set; }
        [Required]
        public string Photo { get; set; }
        [Required]
        public string Notes { get; set; }
        [Required]
        public string ReportsTo { get; set; }
        public virtual List<Orders> Orderss { get; set; }





    }
}
