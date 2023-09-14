using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Labguide5.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [
        Display(Name = "Họ và tên"),
        Required(ErrorMessage = "Họ không đc bỏ trống"),
        MinLength(6, ErrorMessage = "Họ tên ít nhất là 6 ký tự"),
        MaxLength(150, ErrorMessage = "Họ tên tối đa là 20 ký tự"),
        ]

        public string Name { get; set; }
        [Display(Name = "Ảnh")]
        public string Image { get; set; }
        [Display(Name = "Giá")]
        [Required(ErrorMessage ="Giá không đc bỏ trống")]
        [Range(100000, float.MaxValue, ErrorMessage = "Giá phải lớn hơn 100,000.")]

        public float Price { get; set; }
        [Display(Name = "Giá Sale")]
        [Required(ErrorMessage = "Giá Sale không đc bỏ trống")]
        [Range(0, double.MaxValue, ErrorMessage = "Giá không đc âm ")]

        public float SalePrice { get; set; }
        [Display(Name = "Mô tả")]
        [Required(ErrorMessage = "Mô tả không đc bỏ trống")]
        public string Description { get; set; }

    }
}
