﻿using FactoryPattern.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Factories
{
    abstract class MembershipFactory
    {
       public abstract IMembership GetMembership();
    }
}
