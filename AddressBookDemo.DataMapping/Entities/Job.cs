﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AddressBookDemo.DataMapping.Entities
{
    public class Job
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        public string Title { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }

    }
}
