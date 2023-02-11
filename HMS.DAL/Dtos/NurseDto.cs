using System;
using System.Collections.Generic;
using System.Text;

namespace HMS.DAL.Dtos
{
    public class NurseDto : PersonDto
    {
        public int DutyHour { get; set; }
    }
}
