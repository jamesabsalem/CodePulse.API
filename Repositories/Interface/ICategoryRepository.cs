using CodePulse.API.Models.Domain;

namespace CodePulse.API.Repositories.Interface
{
    public interface ICategoryRepository
    {
        public Task<Category> CreateAsync(Category category);
        public Task<IEnumerable<Category>> GetAllAsync();
    }
}