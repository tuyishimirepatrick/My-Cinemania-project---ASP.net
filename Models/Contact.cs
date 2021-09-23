using System.ComponentModel.DataAnnotations;

namespace CineMania.Models
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }
        
        
        [Required(ErrorMessage = "Name field must not be null")]
        public string Name { get; set; }
        
        
        [Required(ErrorMessage = "Email field must not be null")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        
        
        [Required(ErrorMessage = "Subject field must not be null")]
        public string Subject { get; set; }
        
        [Required(ErrorMessage = "This field can't be null!")]
        [MaxLength(13, ErrorMessage = "Phone number must not exceed 13")]
        public string Phone { get; set; }
        
        [Required(ErrorMessage = "Message field must not be null")]
        [MaxLength(1000, ErrorMessage = "message character must not exceed 1000 character")]
        public string Message { get; set; }
    }
}