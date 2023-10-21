using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace SocialNetwork.Data.Entity
{
    public class User
    {
        
        public Guid Id { get; set; }
        public String Login { get; set; } = null!;
        public String? FirstName { get; set; }
        public String? LastName { get; set; }
        public String Password { get; set; } = null!;
        public String Email { get; set; } = null!;
        public bool EmailConfirmed { get; set; } = false;

       

    }
}
