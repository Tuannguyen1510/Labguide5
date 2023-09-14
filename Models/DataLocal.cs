namespace Labguide5.Models
{
    public class DataLocal
    {
        public static List<Account> accounts = new List<Account>
        {
            new Account()
            {
                    Id = 1,
                    FullName = "Ronaldo",
                    Email="ronaldo@gmail.com",
                    Phone = "0987656432",
                    Address = "Bồ Đào Nha",
                    Avatar = "images/avatar/bg-1.png",
                    Birthday = new DateTime(1986/4/7),
                    Gender ="Nam",
                    Password="Ronaldo",
                    Facebook="https://facebook.com",
            },
              new Account()
            {
                    Id = 2,
                    FullName = "Ronaldo",
                    Email="ronaldo@gmail.com",
                    Phone = "0987656432",
                    Address = "Bồ Đào Nha",
                    Avatar = "images/avatar/bg-1.png",
                    Birthday = new DateTime(1986/4/7),
                    Gender ="Nam",
                    Password="Ronaldo",
                    Facebook="https://facebook.com",
            },
              new Account()
            {
                    Id = 3,
                    FullName = "Ronaldo",
                    Email="ronaldo@gmail.com",
                    Phone = "0987656432",
                    Address = "Bồ Đào Nha",
                    Avatar = "images/avatar/bg-1.png",
                    Birthday = new DateTime(1986/4/7),
                    Gender ="Nam",
                    Password="Ronaldo",
                    Facebook="https://facebook.com",
            },
        };

        public static List<Product> products = new List<Product>
        {
            new Product()
            {
                    Id = 1,
                    Name = "Ronaldo",
                    Image = "images/avatar/bg-1.png",
                    Price = 10000,
                    SalePrice=5000,
                    Description="Ronaldo"
            },
               new Product()
            {
                    Id = 2,
                    Name = "Ronaldo",
                    Image = "images/avatar/bg-1.png",
                    Price = 10000,
                    SalePrice=5000,
                    Description="Ronaldo"
            },
               new Product()
            {
                    Id = 3,
                    Name = "Ronaldo",
                    Image = "images/avatar/bg-1.png",
                    Price = 10000,
                    SalePrice=5000,
                    Description="Ronaldo"
            },

        };

        public static List<Account> GetAccounts()
        {
            return accounts;
        }
        public static List<Product> GetProduct()
        {
            return products;
        }
        public static Product? GetProductById(int id)
        {
            var p = GetProduct().FirstOrDefault(p => p.Id == id);
            return p;
        }


    }
}
