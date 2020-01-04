using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AddressBookDemo.DataMapping.Entities
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [StringLength(100)]
        public string FullName { get; set; }

        public DateTime BirthDate { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public string Password { get; set; }
        public string PhotoUrl { get; set; }
        public int Age { get; set; }


        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }


        public int JobId { get; set; }
        public virtual Job Job { get; set; }

        public virtual ICollection<Address> addresses { get; set; }
        public virtual ICollection<Phone> Phones { get; set; }
    }
}
