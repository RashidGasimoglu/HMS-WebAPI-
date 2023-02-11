using System;
using System.Collections.Generic;
using System.Text;

namespace HMS.DAL.DBModel
{
    public class Medicine : BaseEntity
    {
        public string Name { get; set; }
        public string Company { get; set; }
        public string Composition { get; set; }
        public int Price { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
    }
}
