﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Zork_Common
{
    public interface IInputService
    {
        event EventHandler<string> InputReceived; 
    }
}
