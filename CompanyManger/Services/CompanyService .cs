using CompanyManger.Core.Interfaces;
using CompanyManger.Core.Models;

namespace CompanyManger.Services
{
    public class CompanyService : ICompanyService
    {

        private readonly ICompanyRepository _companyRepository;

        public CompanyService(ICompanyRepository repository)
        {
            _companyRepository = repository;
        }
        public async Task<CompanyModel?> GetCompanyByIdAsync(int id)
        {
            return await _companyRepository.GetByIdAsync(id);
        }
        public async Task<IReadOnlyList<CompanyModel>> GetAllCompnysAsync()=> await _companyRepository.GetAllAsync();
        public async Task CreateCompanyAsync(CompanyModel company) => await _companyRepository.CreateAsync(company);
        public async Task UpdateCompanyAsync(CompanyModel company) => await _companyRepository.UpdateAsync(company);
        public async Task DeleteCompanyByIdAsync(int id) => await _companyRepository.DeleteByIdAsync(id);
    }
}
