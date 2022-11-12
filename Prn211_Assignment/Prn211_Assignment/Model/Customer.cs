using System;
using System.Collections.Generic;

namespace Prn211_Assignment.Models
{
    public partial class Customer
    {
        public int Id { get; set; }
        public string Fullname { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Phonenumber { get; set; } = null!;
    }
}
