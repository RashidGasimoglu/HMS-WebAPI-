using System;
using System.Collections.Generic;
using System.Text;

namespace HMS.DAL.DBModel
{
    public class Person : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
    }
}
