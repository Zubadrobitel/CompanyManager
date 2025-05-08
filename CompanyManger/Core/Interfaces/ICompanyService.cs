using CompanyManger.Core.Models;

namespace CompanyManger.Core.Interfaces
{
    public interface ICompanyService
    {
        Task<CompanyModel?> GetCompanyByIdAsync(int id);
        Task<IReadOnlyList<CompanyModel>> GetAllCompnysAsync();
        Task CreateCompanyAsync(CompanyModel company);
        Task UpdateCompanyAsync(CompanyModel company);
        Task DeleteCompanyByIdAsync(int id);
    }
}
