using CarBooking.Domain.Entities;

namespace CarBooking.Application.Interfaces.BlogInterfaces;
public interface IBlogRepository
{
    public List<Blog> GetLast3BlogsWithAuthors();
    public List<Blog> GetAllBlogsWithAuthors();
    public List<Blog> GetBlogByAuthorId(int id);
}
