﻿using Entities.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Players:IEntities
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public int ShirtNumber{ get; set; }
    }
}
