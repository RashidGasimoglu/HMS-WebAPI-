using HMS.DAL.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace HMS.DAL.Dtos
{
    public class PrescriptionDto : BaseDto
    {
        public int DoctorId { get; set; }
        public int PatientId { get; set; }
        public int MedicineId { get; set; }
    }
}
