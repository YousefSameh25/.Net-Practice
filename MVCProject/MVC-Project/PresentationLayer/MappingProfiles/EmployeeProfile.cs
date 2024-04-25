using AutoMapper;
using DataAccessLayer.Models;
using PresentationLayer.Models;

namespace PresentationLayer.MappingProfiles
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {
                                                   // ReverseMap -> Enable the reversed mapping.
            CreateMap<EmployeeViewModel, Employee>().ReverseMap(); // Simple mapping
            //.ForMember(d => d.Name , O => O.MapFrom(S => S.Name)); // To customize the mapping.
        }
    }
}
