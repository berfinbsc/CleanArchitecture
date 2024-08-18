using System.ComponentModel.DataAnnotations;
namespace Core.Entities;
public class City
{
    public long Id { get; set; }

    [Required(ErrorMessage = "cityName is required.")]
    [StringLength(100, ErrorMessage = "cityName cannot be longer than 100 characters.")]
    public required string cityName { get; set; }

    [StringLength(200, ErrorMessage = "Coordinate cannot be longer than 200 characters.")]
    public string? Coordinate { get; set; }

    public ICollection<Advert>? Adverts { get; set; }
}