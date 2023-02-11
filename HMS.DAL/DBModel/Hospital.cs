using System;
using System.Collections.Generic;
using System.Text;

namespace HMS.DAL.DBModel
{
    public class Hospital : BaseEntity
    {
        public string Name { get; set; }
        public string Place { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
    }
}
