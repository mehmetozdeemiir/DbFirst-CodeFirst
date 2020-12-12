using Lab4_PhoneBook.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_PhoneBook.Entities.Abstract
{
   public abstract class BaseEntity<T>
    {

        public abstract int Id { get; set; }

        public DateTime? CreateDate { get; set; }
        public DateTime? ModifiedDate { get; set; }  
        public DateTime? PassivedDate { get; set; }
                                                   
        private Status _status = Status.Active;
        public Status Status
        {
            get { return _status; }
            set { _status = value; }
        }

    }
}
