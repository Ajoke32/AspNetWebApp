using System.ComponentModel.DataAnnotations;

namespace GreetingWebApp.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="This field is required")]
        public string? Name { get; set; }
    }
}
