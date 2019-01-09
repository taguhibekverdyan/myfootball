﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyFootballMvc.Models
{
    public class Coach : EntityBase<Coach>
    {
        [Required(ErrorMessage = "Please enter your License")]
        public string License { get; set; }
        public User User { get; set; }

    }
}