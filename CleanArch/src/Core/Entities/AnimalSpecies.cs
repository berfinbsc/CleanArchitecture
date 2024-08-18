using System.ComponentModel.DataAnnotations;
namespace Core.Entities;

public class AnimalSpecies
{
    public long Id { get; set; }

    [Required(ErrorMessage = "Species is required.")]
    [StringLength(50, ErrorMessage = "Species cannot be longer than 50 characters.")]
    public required string Species { get; set; }

    [Required(ErrorMessage = "TypeId is required.")]
    public required long TypeId { get; set; }
    public AnimalType? Type { get; set; }

    public ICollection<Animal>? Animals { get; set; }
}