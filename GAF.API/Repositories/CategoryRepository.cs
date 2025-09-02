using GAF.API.Models;

namespace GAF.API.Repositories.Interfaces;
public class CategoryRepository : ICategoryRepository
{
    public Task<Category> CreateAsync(Category category)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteAsync(int id, string userId)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Category>> GetAllByuserIdAsync(string userId)
    {
        throw new NotImplementedException();
    }

    public Task<Category> GetBydAsync(int id, string userId)
    {
        throw new NotImplementedException();
    }

    public Task<Category> GetByNameAsync(string name, string userId)
    {
        throw new NotImplementedException();
    }

    public Task<bool> HasTransactionAsync(int id, string userId)
    {
        throw new NotImplementedException();
    }

    public Task<Category> UpdateAsync(Category category)
    {
        throw new NotImplementedException();
    }
}

