using System.ComponentModel.DataAnnotations;

namespace Labguide5.Models
{
    public class Account
    {
        [Key]
        public int Id { get; set; }
        [
           Display(Name= "Họ và tên"),
           Required(ErrorMessage ="Họ không đc bỏ trống"),
           MinLength(6,ErrorMessage ="Họ tên ít nhất là 6 ký tự"),
           MaxLength(20, ErrorMessage = "Họ tên tối đa là 20 ký tự"),
        ]
        public string FullName { get; set; }
        [
     Display(Name = "Địa chỉ Email"),
     Required(ErrorMessage = "Địa chỉ Email Không đc để trống"),
     EmailAddress(ErrorMessage ="Đại chỉ email không đúng định dạng")
        ]
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Avatar { get; set; }
        public DateTime Birthday { get; set; }
        public string Gender { get; set; }
        public string Password { get; set; }
        public string Facebook { get; set; }


    }
}
