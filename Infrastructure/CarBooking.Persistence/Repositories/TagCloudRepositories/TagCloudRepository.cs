using CarBooking.Application.Interfaces.TagCloudInterfaces;
using CarBooking.Domain.Entities;
using CarBooking.Persistence.Context;

namespace CarBooking.Persistence.Repositories.TagCloudRepositories;
public class TagCloudRepository : ITagCloudRepository
{
    private readonly CarBookingContext _context;
    public TagCloudRepository(CarBookingContext context)
    {
        _context = context;
    }
    public List<TagCloud> GetTagCloudsByBlogID(int id)
    {
        var values = _context.TagClouds.Where(x => x.BlogID == id).ToList();
        return values;
    }
}
