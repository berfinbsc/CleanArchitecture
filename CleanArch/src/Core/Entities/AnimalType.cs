using System.ComponentModel.DataAnnotations;
namespace Core.Entities;

public class AnimalType
{
    public long Id { get; set; }

    [Required(ErrorMessage = "animal type is required.")]
    [StringLength(80, ErrorMessage = "animal type cannot be longer than 80 characters.")]
    public required string Type { get; set; }
    
    public ICollection<Animal>? Animals { get; set; }
    public ICollection<AnimalSpecies>? Species { get; set; }
}