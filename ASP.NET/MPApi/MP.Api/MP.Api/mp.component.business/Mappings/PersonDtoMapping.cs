using AutoMapper;
using mp.component.business.Dtos;
using mp.component.domain.Entities;

namespace mp.component.business.Mappings;

public class PersonDtoMapping : Profile
{
    public PersonDtoMapping()
    {
        CreateMap<Person, PersonDTO>();
    }
}
