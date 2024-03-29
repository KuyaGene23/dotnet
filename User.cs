﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sabio.Models.Domain.Users
{
    public class User : BaseUser
    {
      
       public string Email { get; set; }
       public string AvatarUrl { get; set; }
       public string TenantId { get; set; }
       public DateTime DateCreated { get; set; }
       public DateTime DateModified { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }


    }
}
