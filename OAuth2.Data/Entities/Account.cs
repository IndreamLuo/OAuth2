using System.ComponentModel.DataAnnotations;

namespace OAuth2.Data.Entities
{
    public class Account
    {
        [Key]
        public int AccountId { get; set; }

        public User User { get; set; }
    }
}