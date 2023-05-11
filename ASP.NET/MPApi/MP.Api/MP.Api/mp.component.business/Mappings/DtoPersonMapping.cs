using AutoMapper;
using mp.component.business.Dtos;
using mp.component.domain.Entities;

namespace mp.component.business.Mappings
{
    public class DtoPersonMapping : Profile
    {
        public DtoPersonMapping()
        {
            CreateMap<PersonDTO, Person>();
        }
    }
}
