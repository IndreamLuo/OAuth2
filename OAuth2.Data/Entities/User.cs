using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OAuth2.Data.Entities
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        public string Email { get; set; }

        public List<Account> Accounts { get; set; }
    }
}