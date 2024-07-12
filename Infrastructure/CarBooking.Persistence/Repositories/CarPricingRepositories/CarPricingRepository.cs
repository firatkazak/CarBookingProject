using CarBooking.Application.Interfaces.CarPricingInterfaces;
using CarBooking.Application.ViewModels;
using CarBooking.Domain.Entities;
using CarBooking.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace CarBooking.Persistence.Repositories.CarPricingRepositories;
public class CarPricingRepository : ICarPricingRepository
{
    private readonly CarBookingContext _context;

    public CarPricingRepository(CarBookingContext context)
    {
        _context = context;
    }

    public List<CarPricing> GetCarPricingWithCars()
    {
        var values = _context.CarPricings
            .Include(x => x.Car)
            .ThenInclude(y => y.Brand)
            .Include(z => z.Pricing)
            .Include(z => z.PricingID == 1)
            .ToList();
        return values;
    }

    public List<CarPricing> GetCarPricingWithTimePeriod()
    {
        throw new NotImplementedException();
    }

    public List<CarPricingViewModel> GetCarPricingWithTimePeriodVM()
    {
        List<CarPricingViewModel> values = new List<CarPricingViewModel>();
        using (var command = _context.Database.GetDbConnection().CreateCommand())
        {
            command.CommandText = "Select * From (Select Model,Name,CoverImageUrl,PricingID,Amount From CarPricings Inner Join Cars On Cars.CarID=CarPricings.CarId Inner Join Brands On Brands.BrandID=Cars.BrandID) As SourceTable Pivot (Sum(Amount) For PricingID In ([2],[3],[4])) as PivotTable;";
            command.CommandType = System.Data.CommandType.Text;
            _context.Database.OpenConnection();
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    CarPricingViewModel carPricingViewModel = new CarPricingViewModel()
                    {
                        Brand = reader["Name"].ToString(),
                        Model = reader["Model"].ToString(),
                        CoverImageUrl = reader["CoverImageUrl"].ToString(),
                        Amounts = new List<decimal>
                            {
                                Convert.ToDecimal(reader["2"]),
                                Convert.ToDecimal(reader["3"]),
                                Convert.ToDecimal(reader["4"])
                            }
                    };
                    values.Add(carPricingViewModel);
                }
            }
            _context.Database.CloseConnection();
            return values;
        }
    }
}
