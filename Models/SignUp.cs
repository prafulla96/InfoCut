using System.ComponentModel.DataAnnotations;


namespace InfoCut.Models
{
    public class SignUp
    {
        [Key]
        [Required]
        public int id {get; set; }
        
        [Required]
        [StringLength(50, MinimumLength = 3)]
        [Display(Name = "Username")]
        public string Username { get; set;}
        
        [Required]
        [Phone]
        public string phonenumber { get; set;}
        
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email{get ; set;}
        
        [Required]
        [StringLength(100, MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]

        public string password{get ; set;}
    }
}
