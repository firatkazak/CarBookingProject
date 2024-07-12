namespace CarBooking.Application.Features.Mediator.Results.AuthorResults;
public class GetAuthorByIdQueryResult
{
    public int AuthorID { get; set; }
    public string Name { get; set; }
    public string ImageUrl { get; set; }
    public string Description { get; set; }
}
