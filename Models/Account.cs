﻿using System.ComponentModel.DataAnnotations;

namespace Labguide5.Models
{
    public class Account
    {
        [Key]
        public int Id { get; set; } 
        public string FullName { get; set; }
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
