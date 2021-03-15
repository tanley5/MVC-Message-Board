using System.ComponentModel.DataAnnotations;

namespace MessageBoard.Models
{
    public class Message
    {
        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter your message")]
        public string TheMessage { get; set; }
    }
}