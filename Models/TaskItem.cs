using System.ComponentModel.DataAnnotations;

namespace TaskManagerSystem.Models
{
    public class TaskItem
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string Description { get; set; }

        public string Status { get; set; } = "Pending";

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        // VERY IMPORTANT (link with logged-in user)
        public string UserId { get; set; }
    }
}