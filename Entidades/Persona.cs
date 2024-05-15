using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Entidades
{
    public abstract class Persona
    {
        //atributos
        protected string apellido;
        protected string barrioResidencia;
        protected DateTime? nacimiento;
        protected string nombre;



        //Metodos
        public Persona(string nombre, string apellido, DateTime? nacimiento)
        {
            this.apellido = apellido;
            this.nacimiento = nacimiento;
            this.nombre = nombre;
        }
        public Persona(string nombre, string apellido, DateTime? nacimiento, string barrioResidencia):this(nombre, apellido, nacimiento)
        {
            this.barrioResidencia = barrioResidencia;
        }

        public abstract string FichaExtra();

        public override string ToString()
        {

            return $"{apellido.ToUpper()}, {nombre.ToUpper()}";
        }
        public static string FichaPersonal(Persona p)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(p.ToString());
            sb.AppendLine($"EDAD: {p.Edad}");
            sb.AppendLine("INFORMACION DEL OBJETO PENDIENTE -");
            return sb.ToString();
        }

        
        //propiedades
        public int Edad
        {
            get {

                int edadEntera = DateTime.Today.Year - nacimiento.Value.Year;
                return edadEntera;
            }
        }
        public string NombreCompleto
        {
            get
            {
                return $"{apellido.ToUpper()}, {nombre.ToUpper()}";
            }
        }



    }
}