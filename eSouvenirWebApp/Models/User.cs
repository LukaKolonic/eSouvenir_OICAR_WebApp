using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eSouvenirWebApp.Models
{
    public class User
    {
        //Komentar
        public int IDUser { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public byte[] Password { get; set; }
        public string Pass { get; set; }

        public bool IsAdmin { get; set; }
        public bool IsDeleted { get; set; }

        public int NbrOfVisitedCities { get; set; }
        public int NbrOfPictures { get; set; }
        public int NbrOfQRCodes { get; set; }

        public ICollection<QRCode> QRCodes { get; set; }

        public User(string username, string email, string pass, bool isAdmin, bool isDeleted)
        {
            Username = username;
            Email = email;
            Pass = pass;
            IsAdmin = isAdmin;
            IsDeleted = isDeleted; 
        }



        public override string ToString()
        {
            return Username;
        }
    }
}
