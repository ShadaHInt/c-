﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APITestingPOC.DTO
{
    public class UpdateUserDTO
    {
        public string name { get; set; }
        public string job { get; set; }
        public DateTimeOffset updatedAt { get; set; }
    }
}

