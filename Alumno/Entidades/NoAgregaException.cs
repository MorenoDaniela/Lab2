﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class NoAgregaException : Exception
    {
        public NoAgregaException(string mensaje) : base(mensaje)
        {

        }
    }
}
