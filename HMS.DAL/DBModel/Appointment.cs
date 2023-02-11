using System;
using System.Collections.Generic;
using System.Text;

namespace HMS.DAL.DBModel
{
    public class Appointment : BaseEntity
    {
        public int DoctorId { get; set; }
        public int AppointmentNumber { get; set; }
        public string PhoneNumber { get; set; }
        public string AppointmentType { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string Description { get; set; }
    }
}
