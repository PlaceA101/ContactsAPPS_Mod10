using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp_placean.Models
{

    public class Contact
    {
        private static readonly string[] AvailablePhotos = new[]
       {
            "avatar.png",
            "avatarr.png",
            "avatarrr.png",
            "avatarrrr.png"
        };

        private static readonly Random Randomizer = new();

        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Description { get; set; }
        public string Photo { get; set; } = AvailablePhotos[Randomizer.Next(AvailablePhotos.Length)];
    }
}
