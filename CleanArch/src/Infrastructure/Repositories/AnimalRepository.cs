
using Core.Entities;
using Core.Repositories;
using Microsoft.EntityFrameworkCore;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
    public class AnimalRepository : IRepository<Animal>

    {
        private readonly ApplicationDbContext _context;
        public AnimalRepository(ApplicationDbContext context)
        {
            _context=context;
        }

        public async Task<Animal> AddAsync(Animal entity)
        {
            await _context.Animals.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;

        }


        public async Task<Animal> DeleteAsync(int id)
        {

            var entity = await _context.Animals.FindAsync(id);
            if(entity==null){
                return null;
            }
            _context.Animals.Remove(entity);
            await _context.SaveChangesAsync();
            return entity;

        }

        public async Task<IEnumerable<Animal>> GetAllAsync()
        {
            return await _context.Animals.ToListAsync();
        }

        public async Task<Animal>GetAsync(int id)
        {
            return await _context.Animals.FindAsync(id);
        }

        public async Task<Animal> UpdateAsync(Animal entity)
        {
            _context.Animals.Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}