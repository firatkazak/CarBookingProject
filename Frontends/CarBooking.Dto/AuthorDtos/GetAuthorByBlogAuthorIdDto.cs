namespace CarBooking.Dto.AuthorDtos;
public class GetAuthorByBlogAuthorIdDto
{
    public int BlogID { get; set; }
    public string AuthorName { get; set; }
    public string AuthorDescription { get; set; }
    public string AuthorImageUrl { get; set; }
    public int AuthorID { get; set; }
}
