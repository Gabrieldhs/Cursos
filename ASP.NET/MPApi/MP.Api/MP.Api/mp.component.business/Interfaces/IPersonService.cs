using mp.component.business.Dtos;
using static mp.component.business.Services.ResultService;

namespace mp.component.business.Interfaces
{
    public interface IPersonService
    {
        Task<ResultServices<PersonDTO>> CreateAsync(PersonDTO personDTO);
    }
}
