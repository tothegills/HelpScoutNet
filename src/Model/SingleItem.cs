﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpScoutNet.Model
{
    internal class SingleItem <T>
    {
        public Task<T> Item { get; set; }

    }
}