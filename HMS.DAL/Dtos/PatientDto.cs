using System;
using System.Collections.Generic;
using System.Text;

namespace HMS.DAL.Dtos
{
    public class PatientDto : PersonDto
    {
        public string BloodType { get; set; }
    }
}
