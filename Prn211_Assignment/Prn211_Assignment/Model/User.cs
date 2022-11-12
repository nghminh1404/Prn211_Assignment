using System;
using System.Collections.Generic;

namespace Prn211_Assignment.Models
{
    public partial class User
    {
        public User()
        {
            Bills = new HashSet<Bill>();
        }

        public int Id { get; set; }
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Phonenumber { get; set; } = null!;
        public bool? Status { get; set; }
        public int? RoleId { get; set; }

        public virtual Role? Role { get; set; }

        public virtual ICollection<Bill> Bills { get; set; }
    }
}
