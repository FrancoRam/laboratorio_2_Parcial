using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Entidades
{
    public class PersonalMedico:Persona
    {
        private bool esResidente;
        private List<Consulta> consultas;


        public PersonalMedico(string nombre, string apellido, DateTime? nacimiento, bool esResidente) : base(nombre, apellido, nacimiento)
        {
            this.esResidente = esResidente;
            consultas = new List<Consulta>();
        }

        public override string FichaExtra()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"¿Finalizó residencia? {esResidente}");
            sb.AppendLine("ATENCIONES:");
            sb.AppendLine();
            return sb.ToString();
        }

        //public static Consulta operator +(PersonalMedico doctor, Paciente paciente)
        //{
            
            
        //    return ;
        //}
    }
}
