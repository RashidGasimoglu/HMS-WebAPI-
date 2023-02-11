using System;
using System.Collections.Generic;
using System.Text;

namespace HMS.DAL.Dtos
{
    public class DoctorDto : PersonDto
    {
        public string SpecialityField { get; set; }
    }
}
