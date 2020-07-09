using System;

namespace Breath_API.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public User()
        {
            Created = DateTime.Now;
            Updated = DateTime.Now;
        }
    }
}