﻿using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interface
{
    public interface IClubs
    {
        Clubs Create (Clubs club);
        Clubs Update (string name, Clubs clubs);
        Clubs Delete (int id);
        Clubs Get (int id);
        Clubs GetId (int id);
        List<Clubs> GetAll(string name = null);
    }
}
