using CompanyManger.Core.Models;

namespace CompanyManger.Core.Interfaces
{
    public interface ICompanyRepository
    {
        Task<CompanyModel?> GetByIdAsync(int id);
        Task<IReadOnlyList<CompanyModel>> GetAllAsync();
        Task CreateAsync(CompanyModel company);
        Task UpdateAsync(CompanyModel company);
        Task DeleteByIdAsync(int id);
    }
}