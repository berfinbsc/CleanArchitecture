using System.ComponentModel.DataAnnotations;
namespace Core.Entities;

public class Animal
{
    public long Id { get; set; }

    [Required(ErrorMessage = "animal name is required.")]
    [StringLength(50, ErrorMessage = "animal name cannot be longer than 50 characters.")]
    public required string Name { get; set; }

    [Required(ErrorMessage = "animal age is required.")]
    [Range(0, 100, ErrorMessage = "animal age must be between 0 and 100.")]
    public required int requiredAge { get; set; }

    [Required(ErrorMessage = "animal type id  is required.")]
    public required long TypeId { get; set; }
    public AnimalType? Type { get; set; }

    [Required(ErrorMessage = "animal species id  is required.")]
    public required long SpeciesId { get; set; }
    public AnimalSpecies? Species { get; set; }

    [Required(ErrorMessage = "Vaccines status is required.")]
    public bool Vaccines { get; set; }

    [Required(ErrorMessage = "Animal gender is required.")]
    [StringLength(10, ErrorMessage = "Animal gender cannot be longer than 10 characters.")]
    public required string Gender { get; set; }
}