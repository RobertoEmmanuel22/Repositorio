using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U2AC1_D
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aqui se declararan las variables

            string nombreAlumno, primerpellidoAlumno, segundoapellidoAlumno, telefonoAlumno, cursoAlumno;
            byte unidad1, unidad2, unidad3, unidad4;
            int calificacionAlumno;

            //En esta seccion se realiza la entrada de datos, preguntadole al usuario la información

            Console.WriteLine("Ingrese el nombre del alumno");

            nombreAlumno = Console.ReadLine();

            Console.WriteLine("Ingrese el primer apellido del alumno");

            primerpellidoAlumno = Console.ReadLine();

            Console.WriteLine("Ingrese el segundo apellido del alumno");

            segundoapellidoAlumno = Console.ReadLine();

            Console.WriteLine("Ingrese el telefono del alumno");

            telefonoAlumno = Console.ReadLine();

            Console.WriteLine("Ingresa el curso a calificar");

            cursoAlumno = Console.ReadLine();



            Console.WriteLine("Ingrese la calificacion de la Unidad 1 de un curso");

            unidad1 = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("Ingrese la calificacion de la Unidad 2 de un curso");

            unidad2 = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("Ingrese la calificacion de la Unidad 3 de un curso");

            unidad3 = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("Ingrese la calificacion de la Unidad 4 de un curso");

            unidad4 = Convert.ToByte(Console.ReadLine());



            calificacionAlumno = (unidad1 + unidad2 + unidad3 + unidad4) / 4;


            if (calificacionAlumno >= 70)
            {

                Console.WriteLine("Felicitades acreditaste el curso");

                Console.WriteLine("\n Tu nombre es: {0} \n Tu primer apellido es: {1} \n Tu segundo apellido es: {2}" +
                    "\n Tu telefono es: {3} \n Tu curso acreditado es: {4}", nombreAlumno, primerpellidoAlumno, segundoapellidoAlumno, telefonoAlumno,
                    cursoAlumno);

            }

            else
            {

                Console.WriteLine("Vuelve a cursar la materia");
            }
            Console.ReadKey();

        }
    }
}
