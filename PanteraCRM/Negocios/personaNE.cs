﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocios
{
    public abstract class personaNE
    {
        public static int PersonaIngresar(persona registros)
        {
            return personaDL.PersonaIngresar(registros);
        }
    }
}
