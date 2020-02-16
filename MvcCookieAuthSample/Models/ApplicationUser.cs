﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace MvcCookieAuthSample.Models
{
    public class ApplicationUser:IdentityUser<int>
    {
        public string Avatar { get; set; }
    }
}
