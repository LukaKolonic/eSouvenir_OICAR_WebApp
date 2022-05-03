using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eSouvenirWebApp.Models
{
    public class User
    {
        //komentar 
        public int IDUser { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public byte[] Pass { get; set; }

        public bool IsAdmin { get; set; }

        public ICollection<QRCode> QRCodes { get; set; }

        public User(string username, string email, byte[] pass, bool isAdmin)
        {
            Username = username;
            Email = email;
            Pass = pass;
            IsAdmin = isAdmin;
        }
    }
}
