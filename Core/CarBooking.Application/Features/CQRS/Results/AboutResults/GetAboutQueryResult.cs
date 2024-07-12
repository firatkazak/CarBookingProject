namespace CarBooking.Application.Features.CQRS.Results.AboutResults;
public class GetAboutQueryResult
{
    public int AboutID { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }
}
