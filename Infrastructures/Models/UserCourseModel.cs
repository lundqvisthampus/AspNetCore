using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Infrastructures.Models;

[PrimaryKey(nameof(UserId), nameof(CourseId))]
public class UserCourseModel
{
    public string UserId { get; set; } = null!;

    public int CourseId { get; set; }

    public ApplicationUser User { get; set; } = null!;
    public CourseModel Course { get; set; } = null!;
}
