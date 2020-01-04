using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AddressBookDemo.DataMapping.Entities
{
    public class Phone
    {
        [Key]
        public int Id { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }


    }
}
