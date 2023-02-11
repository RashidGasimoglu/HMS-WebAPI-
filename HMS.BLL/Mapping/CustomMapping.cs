using AutoMapper;
using HMS.DAL.DBModel;
using HMS.DAL.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace HMS.BLL.Mapping
{
    public class CustomMapping : Profile
    {
        public CustomMapping()
        {
            CreateMap<Appointment, AppointmentDto>().ReverseMap();
            CreateMap<Doctor, DoctorDto>().ReverseMap();
            CreateMap<Hospital, HospitalDto>().ReverseMap();
            CreateMap<Medicine, MedicineDto>().ReverseMap();
            CreateMap<Nurse, NurseDto>().ReverseMap();
            CreateMap<Patient, PatientDto>().ReverseMap();
            CreateMap<Prescription, PrescriptionDto>().ReverseMap();
        }
    }
}
