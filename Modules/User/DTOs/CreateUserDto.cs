using System.ComponentModel.DataAnnotations;
using Models;

namespace DTO.User;

public class CreateUserDto
{
    [Required]
    public required string Name { get; set; }

    [Required]
    [EmailAddress]
    public required string Email { get; set; }

    [Required]
    [MinLength(8)]
    public required string Password { get; set; }

    [Required]
    [EnumDataType(typeof(UserRole))]
    public required UserRole Role { get; set; }

}