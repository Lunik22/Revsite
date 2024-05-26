using Microsoft.AspNetCore.Identity;
using Revsite.Models.Enum;
using System.ComponentModel.DataAnnotations;
namespace Revsite.Models
{
    public class UserModel
    {
        [Key]
        public Guid uid { get; set; } = Guid.NewGuid();
        public string uname { get; set; }
        public string pass { get; set; }
        public string? email { get; set; }
        public UserRole Role { get; set; }
    }
}
