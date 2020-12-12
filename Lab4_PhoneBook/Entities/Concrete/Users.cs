using Lab4_PhoneBook.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_PhoneBook.Entities.Concrete
{
    public class Users : BaseEntity<int>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get ; set ; }
        [Required]
        public string NameSurname { get; set; }//kolon ismi
        [Required]
        public string PhoneNumber { get; set; }


    }
}
