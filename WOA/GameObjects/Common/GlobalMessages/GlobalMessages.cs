﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameObjects.Common.GlobalMessages
{
    public static class GlobalMessages
    {
        public static string StudentWasAded(string name)
        {
            return $"--Student {name} was successfully added";
        }

    }
}
