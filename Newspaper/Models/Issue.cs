﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newspaper.Models
{
    public class Issue
    {
        public int Id { get; set; }
        public DateTime IssueDate { get; set; }
        public List<Article> Articles { get; set; } = new List<Article>();
    }
}
