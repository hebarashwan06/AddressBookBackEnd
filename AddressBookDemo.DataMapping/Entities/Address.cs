using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AddressBookDemo.DataMapping.Entities
{
    public class Address
    {
        [Key]
        public int Id { get; set; }

        [StringLength(250)]
        public string Name { get; set; }

        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }

    }
}
