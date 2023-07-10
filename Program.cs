using System;
namespace AdivinaElNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creacion de variables 
            Console.WriteLine("nueva linea agregada");
            Random random = new Random();
            int numeroAdivinar = random.Next(1, 101);//Variable que crea un numero aleatorio entre 1 y 100
            int intentos = 0;
            int numeroUsuario = 0;
            bool adivinado = false;
            Console.WriteLine("¡Bienvenido a Adivina el número!");
            Console.WriteLine("Intenta adivinar el número que he elegido entre 1 y 100.");
            while (!adivinado)
            {
                Console.Write("Ingresa tu número: ");
                string entrada = Console.ReadLine(); //Pide que el usuario ingrese un numero
                if (!int.TryParse(entrada, out numeroUsuario))//Verifica que lo que ingreso el ususario sea un numero y no un caracter cualquiera 
                {                                             //Si es un caracter cualquiera pide ingresar numero otra vez 
                    Console.WriteLine("Debes ingresar un número válido.");
                    continue;
                }
                intentos++;//aumenta el numero de intentos 
                if (numeroUsuario < numeroAdivinar) //condicion que verifica si el numero digitado por el usuario es menor al aleatorio creado
                {
                    Console.WriteLine("El número a adivinar es mayor.");//Si es mayor pide ingresar uno mayor al que ya ingreso 
                }
                else if (numeroUsuario > numeroAdivinar)//condicion que verifica si el numero digitado por el usuario es mayor al aleatorio creado
                {
                    Console.WriteLine("El número a adivinar es menor.");//Si es menor pide ingresar uno menor al que ya ingreso 
                }
                else
                {
                    Console.WriteLine("¡Felicidades! ¡Has adivinado el número correctamente!");
                    Console.WriteLine("Número de intentos: " + intentos);
                    adivinado = true;
                }
            }
            Console.ReadLine();
        }
    }
}