﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Propietario : Consorcista
    {
        public decimal PorcentajePropiedad { get; set; }

        public string Observaciones { get; set; }
    }
}
