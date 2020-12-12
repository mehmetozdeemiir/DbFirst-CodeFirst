using Lab3_CodeFirst_Library.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_CodeFirst_Library.Entities.Abstract
{
    public abstract class BaseEntity<T>
    {
        public abstract T Id { get; set; }
        private DateTime _createDate;
        public DateTime CreateDate
        {
            get { return _createDate; }

        }
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