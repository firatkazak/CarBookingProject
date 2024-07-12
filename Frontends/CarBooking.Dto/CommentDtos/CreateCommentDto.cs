namespace CarBooking.Dto.CommentDtos;
public class CreateCommentDto
{
    public string Name { get; set; }
    public DateTime CreatedDate { get; set; }
    public string Description { get; set; }
    public int BlogID { get; set; }
    public string Email { get; set; }
}
