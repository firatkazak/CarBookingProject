using System.Linq.Expressions;

namespace CarBooking.Application.Interfaces;
public interface IRepository<T> where T : class
{
	Task CreateAsync(T entity);//Verilen veriyi ekleyecek.
	Task UpdateAsync(T entity);//Verilen veriyi güncelleyecek.
	Task RemoveAsync(T entity);//Verilen veriyi silecek.
	Task<T> GetByIdAsync(int id);//Verilen veriyi Id'ye göre getirecek.
	Task<List<T>> GetAllAsync();//Verilerin hepsini Listeleyecek.
	Task<T?> GetByFilterAsync(Expression<Func<T, bool>> filter);//
}
