using System.ComponentModel.DataAnnotations;
namespace Core.Entities;
public class Advert
{
    public long Id { get; set; }

    [Required(ErrorMessage = "AnimalId is required.")]
    public required long AnimalId { get; set; }
    public Animal? Animal { get; set; }

    [Required(ErrorMessage = "UserId is required.")]
    public required long UserId { get; set; }
    public User? User { get; set; }

    [Required(ErrorMessage = "CityId is required.")]
    public required long CityId { get; set; }
    public City? City { get; set; }

    [StringLength(500, ErrorMessage = "Comment cannot be longer than 500 characters.")]
    public string? Comment { get; set; }
}