using CodePulse.API.Data;
using CodePulse.API.Models.Domain;
using CodePulse.API.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
namespace CodePulse.API.Repositories.Implementation
{
    public class CategoryRepository(ApplicationDbContext dbContext) : ICategoryRepository
    {
        public async Task<Category> CreateAsync(Category category)
        {
            await dbContext.Categories.AddAsync(category);
            await dbContext.SaveChangesAsync();

            return category;
        }
        

        async Task<IEnumerable<Category>> ICategoryRepository.GetAllAsync()
        {
             return await dbContext.Categories.ToListAsync();
        }
    }
}
