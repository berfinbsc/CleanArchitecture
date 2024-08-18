using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Core.Entities;

public class User
{
    public long Id { get; set; }

    [Required(ErrorMessage = "Name is required.")]
    [StringLength(50, ErrorMessage = "Name cannot be longer than 50 characters.")]
    public required string Name { get; set; }

    [Required(ErrorMessage = "Surname is required.")]
    [StringLength(50, ErrorMessage = "Surname cannot be longer than 50 characters.")]
    public required string Surname { get; set; }

    [Required(ErrorMessage = "Email is required.")]
    [EmailAddress(ErrorMessage = "Invalid email address.")]
    [StringLength(100, ErrorMessage = "Email cannot be longer than 100 characters.")]
    public required string Email { get; set; }

    [Required(ErrorMessage = "Password is required.")]
    [StringLength(100, MinimumLength = 6, ErrorMessage = "Password must be at least 6 characters long and cannot be longer than 100 characters.")]
    public required string Password { get; set; }

    public ICollection<Advert>? Adverts { get; set; }
    public ICollection<Animal>? Animals { get; set; }
}