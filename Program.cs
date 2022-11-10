using System;
using System.Threading;

namespace FPU3D_Ejemplo1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Declarar dos variables
            #region VARIABLES
            string nombreUsuario, primerApellidoUsuario, segundoApellidoUsuario, direccionUsuario, perfilUsuario,
            contraseñaUsuario, confirmContraseña, usuarioAcceso, telefonoCelularUsuario;
            byte edadUsuario;
            #endregion

            //Tarea: Solicitar datos apellido, direccion, telefono celular, 
            //Perfil Facebook, usuarioAcceso y contraseña

            //Que el Usuario ingrese por teclado los valores de las variabes

            #region DATOSDEENTRADA 

            Console.WriteLine("Ingresa tu nombre, despúes presiona ENTER");
            nombreUsuario = Console.ReadLine();

            Console.WriteLine("Ingresa tu edad, despúes presiona ENTER");
            edadUsuario = Convert.ToByte(Console.ReadLine());

            #endregion



            //if

            #region SEGUNDAENTRADACONDICION
            if (edadUsuario > 18)
            {

                Console.BackgroundColor = ConsoleColor.DarkMagenta;
                Console.Clear();
                Console.WriteLine("Tu código de acceso es: 345678");

                Console.WriteLine("Ingresa tu primer apellido, despúes presiona ENTER");

                primerApellidoUsuario = Console.ReadLine();

                Console.WriteLine("Ingresa tu segundo apellido, despúes presiona ENTER");

                segundoApellidoUsuario = Console.ReadLine();

                Console.WriteLine("Ingresa tu telefono, despúes presiona ENTER");

                telefonoCelularUsuario = Console.ReadLine();

                Console.WriteLine("Ingresa tu direccion, despúes presiona ENTER");

                direccionUsuario = Console.ReadLine();

                Console.WriteLine("Ingresa tu perfil de Facebook, despúes presiona ENTER");

                perfilUsuario = Console.ReadLine();

                Console.WriteLine("Ingresa tu usuario de acceso, despúes presiona ENTER");

                usuarioAcceso = Console.ReadLine();

                Console.WriteLine("Ingrese la contraseña, despúes presiona ENTER");

                contraseñaUsuario = Console.ReadLine();

                Console.WriteLine("Confirma tu contraseña");

                confirmContraseña = Console.ReadLine();

                #endregion





                //NUMERO ALEATORIO


                #region IMPRESIONDATOSCONDICION
                if (contraseñaUsuario == confirmContraseña)
                {

                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Clear();

                    //RANDOM
                    //ACCESO ALEATORIO 


                    Random numeroAleatorio = new Random();

                    numeroAleatorio.Next(1000, 9999);

                    Console.WriteLine("Tu codigo de acceso aleatorio es:");
                    Console.WriteLine(numeroAleatorio.Next(1000, 9999));

                    Console.WriteLine("\n Tu nombre es: {0} \n Tu edad es: {1} años \n Tu primer apellido es: {2}" +
                        "\n Tu segundo apellido es: {3} \n Tu numero de telefono es: {4} \n Tu direccion es: {5}" +
                        "\n Tu Perfil de Facebook es: {6} \n Tu usuario de acceso es: {7} \n Tu contraseña es: {8}" +
                        "\n Tu confirmacion de tu contraseña es: {9}"
                        , nombreUsuario, edadUsuario, primerApellidoUsuario, segundoApellidoUsuario, telefonoCelularUsuario, direccionUsuario,
                        perfilUsuario, usuarioAcceso, contraseñaUsuario, confirmContraseña);
                    #endregion
                    Console.ReadKey();
                }
            }

          



            //TAREA AL FINAL LA APLICACION IMPRIMA LOS DATOS DE INVITADO CON UNA NUEVA CONSOLA CON DIFERENTE COLOR MOSTRANDO SU CODIGO DE ACCESO 


            else
            {

                #region MENORDEDAD
                Console.WriteLine("No podemos validar tu acceso, debes ser mayor de edad");

                Console.WriteLine("Saliendo del sistema.");
                Thread.Sleep(800);
                Console.WriteLine("Saliendo del sistema..");
                Thread.Sleep(800);
                Console.WriteLine("Saliendo del sistema...");
                Thread.Sleep(800);
                Console.WriteLine("Saliendo del sistema....");
                Thread.Sleep(800);
                #endregion
            }

                  Console.WriteLine("Esto es una actualizacion");

        }

    }
}
