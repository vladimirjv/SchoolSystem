using System;
using System.Collections.Generic;

namespace SchoolSystem.Models
{
    public class School
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime FoundationYear { get; set; }
        public string Address { get; set; }
        public int Phone { get; set; }
        public List<SchoolUser> Users { get; set; }
    }
}