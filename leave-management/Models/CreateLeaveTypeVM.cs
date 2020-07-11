using System.ComponentModel.DataAnnotations;

namespace leave_management.Models
{
    public class CreateLeaveTypeVM
    {
        [Required]
        public string Name { get; set; }
    }
}