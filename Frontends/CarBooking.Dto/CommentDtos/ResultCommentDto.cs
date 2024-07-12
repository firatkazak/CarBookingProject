namespace CarBooking.Dto.CommentDtos;
public class ResultCommentDto
{
    public int CommentID { get; set; }
    public string Name { get; set; }
    public DateTime CreatedDate { get; set; }
    public string Description { get; set; }
    public int BlogID { get; set; }
}
