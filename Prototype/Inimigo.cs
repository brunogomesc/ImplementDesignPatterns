﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public abstract class Inimigo
    {

        public string? Nome { get; set; }

        public string? Cor { get; set; }

        public Arma? Arma { get; set; }

    }
}
