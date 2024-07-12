using CarBooking.Domain.Entities;
using System.Linq.Expressions;

namespace CarBooking.Application.Interfaces.RentACarInterfaces;
public interface IRentACarRepository
{
    Task<List<RentACar>> GetByFilterAsync(Expression<Func<RentACar, bool>> filter);
}
