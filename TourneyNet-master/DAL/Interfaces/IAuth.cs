﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IAuth<Ret>
    {
        bool Authenticate(string username, string password);
        Ret HasExtToken(string Username);
    }
}
