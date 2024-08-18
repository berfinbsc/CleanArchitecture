using Core.Entities;
using Core.Repositories;
using Microsoft.EntityFrameworkCore;
using Infrastructure.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class AnimalTypeRepository : IRepository<AnimalType>
    {
        private readonly ApplicationDbContext _context;

        public AnimalTypeRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<AnimalType> GetAsync(int id)
        {
            return await _context.AnimalTypes.FindAsync(id);
        }

        public async Task<IEnumerable<AnimalType>> GetAllAsync()
        {
            return await _context.AnimalTypes.ToListAsync();
        }

        public async Task<AnimalType> AddAsync(AnimalType entity)
        {
            await _context.AnimalTypes.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<AnimalType> UpdateAsync(AnimalType entity)
        {
            _context.AnimalTypes.Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<AnimalType> DeleteAsync(int id)
        {
            var entity = await _context.AnimalTypes.FindAsync(id);
            if (entity == null)
            {
                return null;
            }

            _context.AnimalTypes.Remove(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}