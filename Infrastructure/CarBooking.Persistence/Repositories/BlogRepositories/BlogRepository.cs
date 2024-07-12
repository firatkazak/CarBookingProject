using CarBooking.Application.Interfaces.BlogInterfaces;
using CarBooking.Domain.Entities;
using CarBooking.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace CarBooking.Persistence.Repositories.BlogRepositories;
public class BlogRepository : IBlogRepository
{
    private readonly CarBookingContext _context;

    public BlogRepository(CarBookingContext context)
    {
        _context = context;
    }

    public List<Blog> GetAllBlogsWithAuthors()
    {
        var values = _context.Blogs.Include(x => x.Author).ToList();
        return values;
    }

    public List<Blog> GetBlogByAuthorId(int id)
    {
        var values = _context.Blogs.Include(x => x.Author).Where(y => y.BlogID == id).ToList();
        return values;
    }

    public List<Blog> GetLast3BlogsWithAuthors()
    {
        var values = _context.Blogs.Include(_x => _x.Author).OrderByDescending(x => x.AuthorID).Take(3).ToList();
        return values;
    }
}
