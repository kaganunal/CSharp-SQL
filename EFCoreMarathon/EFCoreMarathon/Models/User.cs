using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreMarathon.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        [MinLength(8)]
        public string Password { get; set; }
        public bool IsAdmin { get; set; }
        public ICollection<Album> Albums { get; set; }
    }
}
