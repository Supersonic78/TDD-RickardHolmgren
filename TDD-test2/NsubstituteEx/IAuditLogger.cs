﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NsubstituteEx
{
    public interface IAuditLogger
    {
        void AddMessage(string message);
        List<string> GetLog();
    }
}