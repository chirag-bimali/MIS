using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace MIS.API.Models
{
    public class AppRole 
    {
        [Key]
        public Guid Id { get; set; }
        public string RoleCode { get; set; } = null!;
        public string RoleName { get; set; } = null!;

        // Navigation properties
        public ICollection<AppUserRole> UserRoles { get; set; } = new List<AppUserRole>();
    }
}
