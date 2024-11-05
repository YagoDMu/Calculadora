using System.Runtime.InteropServices;

namespace Calculadora {
    class Program
    {
        static void Main(string [] args)
        {
            Console.WriteLine("Bienvenido a la calculadora");

            int choice = 0; // Declaración de la variable opción para el menú.
            bool intValido = false; // Declaración del bool intValido para usar en el while en caso de que el número del menú no sea correcto

            do // Realiza la primera iteración. Puntro de retorno en caso de que se quieran insertar número nuevos.
            {
                Console.WriteLine("\nIntroduce el primer operador, entero y positivo:"); // Pide le primer operador
                 int operador1 = Input(); // LLama al método Input para leer el primer número por consola

                Console.WriteLine("\nIntroduce el segundo operador, entero y positivo:"); // Pide el segundo operador
                 int operador2 = Input(); // Llama al método Input para leer el segundo numero por consola

                do // Realiza la primera iteración. Punto de retorno al realizar una operación
                {
                    Console.WriteLine("\nIndique el número de la operación que desea realizar:");
                    Console.WriteLine("1: Suma\n2: Resta\n3: Multiplicación\n4: División\n5: Insertar nuevos números\n6: Salir de la calculadora\n");
                    
                    choice = Input();   // Se entra un entero con el método Input

                    switch (choice) // switch para las diferentes opciones
                    {
                        case  1: // Suma
                            Console.WriteLine("\n- Operación : SUMA");
                            int resultadoSuma = Suma(operador1,operador2);
                            Console.WriteLine("El resultado de {0} + {1} = {2}",operador1,operador2,resultadoSuma);
                            break;

                        case 2: // Resta
                            Console.WriteLine("- Operación : RESTA");
                            int resultadoResta = Resta(operador1,operador2);
                            Console.WriteLine("El resultado de {0} - {1} = {2}",operador1,operador2,resultadoResta);
                            break;

                        case 3: // Multiplicación
                            Console.WriteLine("- Operación : MULTIPLICACIÓN");
                            int resultadoMultip = Multiplicacion(operador1,operador2);
                            Console.WriteLine("El resultado de {0} * {1} = {2}",operador1,operador2,resultadoMultip);
                            break;  

                        case 4: // División
                            Console.WriteLine("- Operación : DIVISÓN");
                            double resultadoDiv = Division(operador1,operador2);
                            Console.WriteLine("El resultado de {0} / {1} = {2:F3}",operador1,operador2,resultadoDiv);
                            break;
                        
                        case 5: // Simplemente acaba el switch para poder volver a insertar números nuevos
                            break;

                        case 6: // Saca el mensaje por consola y cierra el programa
                            Console.WriteLine("\nGracias por usar la calculadora\n");
                            return;
                        
                        default: // En caso de insertar otro número que no sea una de las opciones
                            Console.WriteLine("Inserta un número que corresponda a una de las opciones");
                            break;
                    }
                } while (choice != 5 && choice != 6); // Salir del while en caso de que se elija volver a poner números o salir de la aplicación
            
            } while (choice == 5); // En caso de que se elija la opción 5, volverá a pedir operadores
        }

        static int Input() // Método para entrada de datos donde solo acepta un número entero y positivo
        {
            int inputInt = 0;
            do
            {
                string? inputString = Console.ReadLine(); // Console.WriteLine ("Introduce un número entero positivo:\n");

                    try // Intenta convertir a Int
                    {
                     inputInt = int.Parse(inputString);
                    }
                    catch // Si no puede convierte el número a 0 y dice que el formato no es válido y vuelve a pedir el número.
                    {
                        Console.WriteLine("Número no válido."); 
                        inputInt = 0;
                    }
            } while (inputInt <= 0); // Si el número es negativo, vuelve a pedir un número

            return inputInt; // Devuelve el número entrado por consola si se puede convertir a un int
        }

        static int Suma(int n1,int n2) // Método para sumar
        {
            int suma = n1 + n2;
            return suma;
        }
        static int Resta(int n1,int n2) // Método para restar
        {
            int resta = n1 - n2;
            return resta;
        }
        static int Multiplicacion(int n1,int n2) // Método para multiplicar
        {
            int multi = n1 * n2;
            return multi;
        }
        static double Division(int n1,int n2) // Método para dividir
        {
            double div = (double)n1 / n2; // Convierte n1 en double para que la variable div tenga decimales
            return div;
        }
    }
}
