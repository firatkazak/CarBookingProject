namespace CarBooking.Dto.RentACarDtos;
public class FilterRentACarDto
{
    public int carID { get; set; }
    public string Brand { get; set; }
    public string Model { get; set; }
    public decimal Amount { get; set; }
    public string CoverImageUrl { get; set; }
}
