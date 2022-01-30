using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioStarlab.Models
{
    [Table("Contacts")]
    public class Contact
    {
        public int Id { get; set; }
        [StringLength(100), Required]
        public string FullName { get; set; }
        [StringLength(100), Required]
        public string Email { get; set; }
        [StringLength(100), Required]
        public string Message { get; set; }
        [StringLength(100), Required]
        public string PhoneNumber { get; set; }
    }
}
