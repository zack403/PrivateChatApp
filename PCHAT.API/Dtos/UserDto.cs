﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PCHAT.API.Dtos
{
    public class UserDto
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string Gender { get; set; }
        public DateTime Created { get; set; }
   
    }
}
