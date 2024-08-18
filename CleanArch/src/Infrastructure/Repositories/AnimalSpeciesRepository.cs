using Core.Entities;
using Core.Repositories;
using Microsoft.EntityFrameworkCore;
using Infrastructure.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class AnimalSpeciesRepository : IRepository<AnimalSpecies>
    {
        private readonly ApplicationDbContext _context;

        public AnimalSpeciesRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<AnimalSpecies> GetAsync(int id)
        {
            return await _context.AnimalSpecies.FindAsync(id);
        }

        public async Task<IEnumerable<AnimalSpecies>> GetAllAsync()
        {
            return await _context.AnimalSpecies.ToListAsync();
        }

        public async Task<AnimalSpecies> AddAsync(AnimalSpecies entity)
        {
            await _context.AnimalSpecies.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<AnimalSpecies> UpdateAsync(AnimalSpecies entity)
        {
            _context.AnimalSpecies.Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<AnimalSpecies> DeleteAsync(int id)
        {
            var entity = await _context.AnimalSpecies.FindAsync(id);
            if (entity == null)
            {
                return null;
            }

            _context.AnimalSpecies.Remove(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}