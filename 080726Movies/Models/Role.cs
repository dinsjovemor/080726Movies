using System;
using System.Collections.Generic;
using System.Text;

namespace _080726Movies.Models
{
    public class Role
    {
        //Properties of the Role class:
        public string RoleTitle { get; set; } // Title of the role (e.g., Director, Actor, Actress, Writer, Lead, Supporting, Cameo)
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Nationality { get; set; }
        public int BirthYear { get; set; }


    }
}
