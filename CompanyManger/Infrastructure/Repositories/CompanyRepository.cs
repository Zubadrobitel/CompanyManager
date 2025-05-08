using CompanyManger.Core.Interfaces;
using CompanyManger.Core.Models;
using CompanyManger.Infastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace CompanyManger.Infastructure.Repositories
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly DBContext _dbContext;

        public CompanyRepository(DBContext dBContext)
        {
            _dbContext = dBContext;
        }

        public async Task<CompanyModel?> GetByIdAsync(int id)
        {
            return await _dbContext.Companies.FindAsync(id);
        }

        public async Task<IReadOnlyList<CompanyModel>> GetAllAsync()
        {
            return await _dbContext.Companies.ToListAsync();
        }

        public async Task CreateAsync(CompanyModel company)
        {
            await _dbContext.Companies.AddAsync(company);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(CompanyModel company)
        {
            _dbContext.Companies.Update(company);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteByIdAsync(int id)
        {
            var company = await _dbContext.Companies.FindAsync(id);
            if(company != null)
            {
                _dbContext.Companies.Remove(company);
                await _dbContext.SaveChangesAsync();
            }
        }
    }
}
