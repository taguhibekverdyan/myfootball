﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyFootballRestApi.Models
{
    public class Staff:EntityBase<Staff>
    {
        
        public string Occupation { get; set; }
        public string License { get; set; }

        [Required]
        public User User { get; set; }

    }
}