﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Consulta
    {
        private DateTime fecha;
        private Paciente paciente;

        public Consulta(DateTime fecha, Paciente paciente)
        {
            this.fecha = fecha;
            this.paciente = paciente;
        }
        //propiedades
        public DateTime Fecha { get => fecha; }
        public Paciente Paciente { get => paciente; }

        public override string ToString()
        {

            return $"{Fecha} se ha atendido a {paciente.NombreCompleto}";
        }

        
    }
}
