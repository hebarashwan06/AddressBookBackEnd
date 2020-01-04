using AddressBookDemo.DataMapping.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookDemo.DataMapping.ViewModels
{
    public class EmployeeVM
    {
        public Employee Employee { get; set; }
        public Department Department { get; set; }
        public Job Job { get; set; }
        public List<Address> Addresses { get; set; }
        public List<Phone> Phones { get; set; }
    }
}
