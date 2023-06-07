﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newspaper.Models
{
    public class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public Reporter Reporter { get; set; }
        public Issue Issue { get; set; }
    }
}