﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.Model
{
    public class GreetingResponseModel
    {
        public int Id { get; set; }

        public string Greeting { get; set; }
    }
}