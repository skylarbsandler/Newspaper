﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newspaper
{
    public class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Reporter { get; set; }
        public Issue Issue { get; set; }
    }
}
