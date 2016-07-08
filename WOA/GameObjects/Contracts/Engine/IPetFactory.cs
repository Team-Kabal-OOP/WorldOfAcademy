﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameObjects.Contracts.Engine
{
    public interface IPetFactory
    {
        IPet CreatePet(string name);
    }
}
