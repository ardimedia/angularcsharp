﻿using AngularCsharp.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularCsharp.Processors
{
    public interface IProcessor
    {
        ProcessResults ProcessNode(NodeContext nodeContext);
    }
}
