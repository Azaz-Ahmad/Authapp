using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Authapp.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the AuthappUser class
    public class AuthappUser : IdentityUser
    {
        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string FirstName { get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string LastName { get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string CCNumber { get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(5)")]
        public string CCExpiry { get; set; }

        [PersonalData]
        [Column(TypeName = "int")]
        public int CCCVV { get; set; }
    }
}
