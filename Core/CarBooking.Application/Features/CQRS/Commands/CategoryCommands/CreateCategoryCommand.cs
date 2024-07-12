namespace CarBooking.Application.Features.CQRS.Commands.CategoryCommands;
public class CreateCategoryCommand
{
    public int CategoryID { get; set; }
    public string Name { get; set; }
}
