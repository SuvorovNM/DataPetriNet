﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataPetriNet.Enums
{
    public enum StateType
    {
        Initial,
        SoundIntermediate,
        Deadlock,
        UncleanFinal,
        CleanFinal
    }
}
