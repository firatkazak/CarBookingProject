using CarBooking.Domain.Entities;

namespace CarBooking.Application.Interfaces.TagCloudInterfaces;
public interface ITagCloudRepository
{
    List<TagCloud> GetTagCloudsByBlogID(int id);
}
