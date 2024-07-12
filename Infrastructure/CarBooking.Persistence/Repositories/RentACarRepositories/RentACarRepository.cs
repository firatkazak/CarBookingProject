using CarBooking.Application.Interfaces.RentACarInterfaces;
using CarBooking.Domain.Entities;
using CarBooking.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace CarBooking.Persistence.Repositories.RentACarRepositories;
public class RentACarRepository : IRentACarRepository
{
    private readonly CarBookingContext _context;

    public RentACarRepository(CarBookingContext context)
    {
        _context = context;
    }

    public async Task<List<RentACar>> GetByFilterAsync(Expression<Func<RentACar, bool>> filter)
    {
        var values = await _context.RentACars.Where(filter).Include(x => x.Car).ThenInclude(y => y.Brand).ToListAsync();
        return values;
    }
}
