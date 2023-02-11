using HMS.DAL.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace HMS.DAL.Dtos
{
    public class MedicineDto : BaseDto
    {
        public string Name { get; set; }
        public string Place { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
    }
}
