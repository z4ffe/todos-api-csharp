using System.ComponentModel.DataAnnotations;

namespace todos_api_cp.Models


{
    public class Users
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Password { get; set; }

        public string? City { get; set; }

        public int? Age { get; set; }

        [Required]
        public required DateTime CreatedAt { get; set; }

        public ICollection<Todos>? Todos { get; set; } = new List<Todos>();
    }
}



