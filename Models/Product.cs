using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Labguide5.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Image { get; set; }
        public float Price { get; set; }
        public float SalePrice { get; set; }
        public string Description { get; set; }

    }
}
