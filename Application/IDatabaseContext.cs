﻿using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
   public interface IDatabaseContext
    {
        DbSet<User> Users { get; set; }
    }
}
