
namespace GAF.API.Models;
public interface ITransactionRepository
{
    Task<IEnumerable<Transaction> GetAllByUserIdAsync(string userId);
    Task<Transaction> GetByIdAsync(int id, string userId);
    Task<IEnumerable<Transaction>> GetByDateRangeAsync(string userId, DateTime startDate, DateTime endDate);
    Task<IEnumerable<Transaction> 

}
