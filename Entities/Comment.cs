﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Comment
    {
        public int Id { get; set; }
        public string CmText { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
    }
}
