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
        public static List<Account> GetAccounts()
        {
            return accounts;
        }
        public static Account? GetAccountById(int id)
        {
            var account = GetAccounts().FirstOrDefault(p => p.Id == id);
            return account;
        }


    }
}
