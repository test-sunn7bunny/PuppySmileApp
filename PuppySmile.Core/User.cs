using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;

namespace PuppySmile.Core
{
    public class User
    {
        public User()
        {
            this.Admin = new HashSet<Admin>();
            this.ShelterStaffs = new HashSet<ShelterStaff>();
            this.Orders = new HashSet<Order>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        [Display(Name = "Email/Login")]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [StringLength(255, MinimumLength = 4)]
        [Required()]
        [MembershipPassword()]
        public string Password { get; set; }

        [Compare("Password")]
        [DataType(DataType.Password)]
        [StringLength(255, MinimumLength = 4)]
        [Required()]
        [MembershipPassword()]
        public string ConfirmPassword { get; set; }

        // Adding a Public Key to Oblast table
        public virtual ICollection<Admin> Admin { get; set; }

        // Adding a Public Key to Oblast table
        public virtual ICollection<ShelterStaff> ShelterStaffs { get; set; }

        // Adding a Public Key to Oblast table
        public virtual ICollection<Order> Orders { get; set; }
    }
}
