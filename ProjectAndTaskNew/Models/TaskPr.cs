﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAndTaskNew.Models
{
    public class TaskPr
    {
        public string Name { get; set; }
        public string Status { get; set; }
        public int Description { get; set; }
        public int Priority { get; set; }
        public int Id { get; set; }
        public Project Project { get; set; }
    }
}
