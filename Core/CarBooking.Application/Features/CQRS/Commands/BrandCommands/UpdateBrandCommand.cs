namespace CarBooking.Application.Features.CQRS.Commands.BrandCommands;
public class UpdateBrandCommand
{
    public int BrandID { get; set; }
    public string Name { get; set; }
}
