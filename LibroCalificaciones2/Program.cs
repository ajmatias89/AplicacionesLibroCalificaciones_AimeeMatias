using System.Reflection.Metadata.Ecma335;

namespace LibroCalificaciones2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MiLibroCalificaciones MyLibro = new MiLibroCalificaciones();

            string nombreDelCurso = "";

            while(string.IsNullOrWhiteSpace(nombreDelCurso))
            {
             Console.WriteLine("Por favor ingrese el nombre del curso: ");
            nombreDelCurso = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(nombreDelCurso))
                {
                Console.WriteLine("El campo no puede estar vacío");

                }

            }
            MyLibro.MostrarMensaje(nombreDelCurso);
        }
    }
}