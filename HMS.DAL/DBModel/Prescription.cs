using System;
using System.Collections.Generic;
using System.Text;

namespace HMS.DAL.DBModel
{
    public class Prescription : BaseEntity
    {
        public int DoctorId { get; set; }
        public int PatientId { get; set; }
        public int MedicineId { get; set; }
    }
}
