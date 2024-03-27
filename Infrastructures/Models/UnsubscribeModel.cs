using System.ComponentModel.DataAnnotations;

namespace Infrastructures.Models;

public class UnsubscribeModel
{
    [Required]
    public string Email { get; set; } = null!;
}
