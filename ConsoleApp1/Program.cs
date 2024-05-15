using Entidades;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Persona persona = new Persona("Ramirez", new DateTime(1997,12,12), "Franco", "Quilmes");
            Console.WriteLine(persona.Edad);
            Console.WriteLine(Persona.FichaPersonal(persona));

        }
    }
}