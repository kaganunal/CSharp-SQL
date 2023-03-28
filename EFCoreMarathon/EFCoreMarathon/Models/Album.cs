using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreMarathon.Models
{
    public class Album
    {
        [Key]
        public int AlbumId { get; set; }
        public string Title { get; set; } 
        public string Artist { get; set; }
        public DateTime ReleaseDate { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public bool IsOnSale { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }

    }
}
