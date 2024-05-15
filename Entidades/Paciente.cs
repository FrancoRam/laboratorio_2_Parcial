using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Paciente:Persona
    {
        public string diagnostico;


        public Paciente(string nombre, string apellido, DateTime? nacimiento,  string barrioResidencia) : base(nombre, apellido, nacimiento,  barrioResidencia)
        {
        }
        public string Diagnostico { get => diagnostico; set => diagnostico = value; }

        public override string FichaExtra()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Reside en: {barrioResidencia}");
            sb.AppendLine($"{diagnostico}");
            return sb.ToString();
        }
    }
}
