using TechieThings.API.Models.Domain;

namespace TechieThings.API.Repositories.Interface
{
    public interface ICategoryRepository
    {
        Task<Category> CreateAsync(Category category);
    }
}
