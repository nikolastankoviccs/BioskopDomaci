﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BioskopMVC.Models
{
    public class Member
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName{ get; set; }
        public string PersonalNumber{ get; set; }
        public string Adress{ get; set; }

        
    }
}