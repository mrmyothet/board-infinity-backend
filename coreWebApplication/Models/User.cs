using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace coreWebApplication.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required(ErrorMessage = "Please, Enter User name...")]
        [Display(Name = "UserName")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Please, Enter Password...")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Pwd { get; set; }

        [Required(ErrorMessage = "Please, Enter the Confirm Password...")]
        [DataType(DataType.Password)]
        [Display(Name ="Confirm Password")]
        [Compare("Pwd")]
        public string ConfirmPwd { get; set; }

        [Required(ErrorMessage ="Please, Enter Email...")]
        [Display(Name ="Email")]
        public string  Email { get; set; }

        [Required(ErrorMessage ="Select the Gender...")]
        [Display(Name ="Gender")]
        [MaxLength(1)]
        public string Gender { get; set; }

        [Required(ErrorMessage ="Select the Marital Status...")]
        [Display(Name ="Marital Status")]
        public string MaritalStatus { get; set; }
    }

    /*
    create table UserRegistration    
    (    
    UserId int not null primary key identity(1,1),    
    Username nvarchar(150),    
    Pwd nvarchar(100),    
    Confirmpwd nvarchar(100),    
    Email nvarchar(150),    
    Gender char,    
    MaritalStatus nvarchar(100)    
    );  
     */
}
