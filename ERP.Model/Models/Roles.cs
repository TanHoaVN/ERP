﻿using System.Collections.Generic;

namespace ERP.Model.Models
{
    public class Roles : BaseModel
    {
        public string name { get; set; }

        public bool isActive { get; set; }
        
        public ICollection<Users> users { get; set; }
    }
}
