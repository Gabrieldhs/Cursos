using Microsoft.EntityFrameworkCore;
using mp.component.domain.Entities;
using mp.component.domain.Repositories;
using mp.component.infra.data.SqlContext;

namespace mp.component.infra.data.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private readonly Context _context;

        public PersonRepository(Context context)
        {
            _context = context;
        }

        public async Task<Person> CreateAsync(Person person)
        {
            _context.Add(person);
            await _context.SaveChangesAsync();
            return person;
        }

        public async Task DeleteAsync(Person person)
        {
            _context.Remove(person);
            await _context.SaveChangesAsync();
            
        }

        public async Task<Person> GetByIdAsync(int id)
        {
            return await _context.People.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<ICollection<Person>> GetPeopleAsync()
        {
            return await _context.People.ToListAsync();
        }

        public async Task UpdateAsync(Person person)
        {
            _context.Update(person);
            await _context.SaveChangesAsync();
        }
    }
}
