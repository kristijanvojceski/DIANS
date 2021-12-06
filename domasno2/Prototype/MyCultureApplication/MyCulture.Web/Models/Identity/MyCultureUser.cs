﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCulture.Web.Models.Identity
{
    public class MyCultureUser:IdentityUser
    {

        public string FirstName { get; set; }

        public string  LastName { get; set; }

        public string Address { get; set; }

    }
}
