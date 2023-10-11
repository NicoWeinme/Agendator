using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4_Dev.Classes
{
    /// <summary>
    /// EN LA PRESENTE CLASE "Presenter" ENCONTRAMOS TODOS LOS MENÚES GRÁFICOS.
    /// </summary>
    public class Presenter
    {
        //MOSTRAMOS EL MENÚ PRINCIPAL
        public string[] Menu()
        {
            string[] menu = new string[16];
            menu[0] = "╔═════════════════════◄►════════════════════╗";
            menu[1] = "║                 AGENDATOR                 ║";
            menu[2] = "╠═══════════════════════════════════════════╣";
            menu[3] = "║                                           ║";
            menu[4] = "║            1.- Agregar Alumno             ║";
            menu[5] = "║            2.- Eliminar Alumno            ║";
            menu[6] = "║            3.- Modificar Alumno           ║";
            menu[7] = "║            4.- Consultar Alumno           ║";
            menu[8] = "║            5.- Listar Alumnos             ║";
            menu[9] = "║            6.- Salir                      ║";
            menu[10] = "║                                           ║";
            menu[11] = "╠═══════════════════════════════════════════╣";
            menu[12] = "║                       ┌───┐               ║";
            menu[13] = "║           Elección:   ┤   ├               ║";
            menu[14] = "║                       └───┘               ║";
            menu[15] = "╚═════════════════════◄►════════════════════╝";

            return menu;
        }
        public void ShowMainMenu()
        {
            /*
            
            Se genera el menú principal
            
            */

            //VARIABLES PARA MANIPULAR CURSOR
            int cursorTopPosition = 0;
            int cursorLeftPosition = 0;


            //ALMACENAMOS EL MENÚ EN UN ARREGLO
            string[] menu = new string[16];
            menu[0] = "╔═════════════════════◄►════════════════════╗";
            menu[1] = "║                 AGENDATOR                 ║";
            menu[2] = "╠═══════════════════════════════════════════╣";
            menu[3] = "║                                           ║";
            menu[4] = "║            1.- Agregar Alumno             ║";
            menu[5] = "║            2.- Eliminar Alumno            ║";
            menu[6] = "║            3.- Modificar Alumno           ║";
            menu[7] = "║            4.- Consultar Alumno           ║";
            menu[8] = "║            5.- Listar Alumnos             ║";
            menu[9] = "║            6.- Salir                      ║";
            menu[10] = "║                                           ║";
            menu[11] = "╠═══════════════════════════════════════════╣";
            menu[12] = "║                       ┌───┐               ║";
            menu[13] = "║           Elección:   ┤   ├               ║";
            menu[14] = "║                       └───┘               ║";
            menu[15] = "╚═════════════════════◄►════════════════════╝";

            //LIMPIAMOS LA CONSOLA
            Console.Clear();

            //RECORREMOS LA CONSOLA PARA PODER ARMAR INTERFAZ GRÁFICA
            for (int t = 0; t < Console.BufferHeight; t++)
            {
                if (t >= Console.BufferHeight / 4 && t <= (Console.BufferHeight / 4 + 15))
                {
                    for (int j = 0; j < Console.BufferWidth; j++)
                    {
                        if (j >= ((Console.BufferWidth - menu[0].Length) / 2) && j < (((Console.BufferWidth - menu[0].Length) / 2) + menu[0].Length))
                        {
                            if (t == 13)
                            {
                                cursorLeftPosition = ((Console.BufferWidth - menu[t].Length) / 2) + 26;
                                cursorTopPosition = (Console.BufferHeight / 4) + t;
                            }
                            Console.Write("W");
                        }
                        else if (j <= (Console.BufferWidth - menu[0].Length) / 2 || j >= (((Console.BufferWidth - menu[0].Length) / 2) + menu[0].Length))
                        {
                            Console.Write("W");
                        }
                    }
                }
                else
                {
                    for (int j = 0; j < Console.BufferWidth; j++)
                    {
                        Console.Write("W");
                    }
                }
            }

            //RECORREMOS EL ARREGLO CON BUCLE FOR
            for (int i = 0; i < 16; i++)
            {
                Console.SetCursorPosition(((Console.BufferWidth - menu[i].Length) / 2), (Console.BufferHeight / 4) + i);
                Console.WriteLine(menu[i]);
            }

            //ESTABLECEMOS LA POSICIÓN DEL CURSOR EN EL CAMPO DE INGRESO
            Console.SetCursorPosition(cursorLeftPosition, cursorTopPosition);
        }
        public void StudentInfoMenu1(Student student)
        {
            /*
            
            Se genera el menú de información de alumno
            
            */

            //VARIABLES PARA MANIPULAR CURSOR
            int cursorTopPosition = 0;
            int cursorLeftPosition = 0;
            int cursorTop = 0;
            int cursorLeft = 0;

            //ALMACENAMOS EL MENÚ EN UN ARREGLO
            string[] menu = new string[16];
            menu[0] = "╔═════════════════════◄►════════════════════╗";
            menu[1] = "║                 AGENDATOR                 ║";
            menu[2] = "╠═══════════════════════════════════════════╣";
            menu[3] = "║ Nombre......                              ║";
            menu[4] = "║ Mail........                              ║";
            menu[5] = "║ Tel.........                              ║";
            menu[6] = "║ Cumpleaños..                              ║";
            menu[7] = "║ Domicilio...                              ║";
            menu[8] = "║ Twitter.....                              ║";
            menu[9] = "║ Facebook....                              ║";
            menu[10] = "║ Instagram...                              ║";
            menu[11] = "╠═══════════════════════════════════════════╣";
            menu[12] = "║                                           ║";
            menu[13] = "║   Presione una tecla para continuar...    ║";
            menu[14] = "║                                           ║";
            menu[15] = "╚═════════════════════◄►════════════════════╝";

            //LIMPIAMOS LA CONSOLA
            Console.Clear();

            //RECORREMOS LA CONSOLA PARA PODER ARMAR INTERFAZ GRÁFICA
            for (int t = 0; t < Console.BufferHeight; t++)
            {
                if (t >= Console.BufferHeight / 4 && t <= (Console.BufferHeight / 4 + 15))
                {
                    for (int j = 0; j < Console.BufferWidth; j++)
                    {
                        if (j >= ((Console.BufferWidth - menu[0].Length) / 2) && j < (((Console.BufferWidth - menu[0].Length) / 2) + menu[0].Length))
                        {
                            if (t == 13)
                            {
                                cursorLeftPosition = ((Console.BufferWidth - menu[t].Length) / 2) + 39;
                                cursorTopPosition = (Console.BufferHeight / 4) + t;
                            }
                            Console.Write("W");
                        }
                        else if (j <= (Console.BufferWidth - menu[0].Length) / 2 || j >= (((Console.BufferWidth - menu[0].Length) / 2) + menu[0].Length))
                        {
                            Console.Write("W");
                        }
                    }
                }
                else
                {
                    for (int j = 0; j < Console.BufferWidth; j++)
                    {
                        Console.Write("W");
                    }
                }
            }

            for (int i = 0; i < 16; i++)
            {
                Console.SetCursorPosition(((Console.BufferWidth - menu[i].Length) / 2), (Console.BufferHeight / 4) + i);
                Console.WriteLine(menu[i]);
            }

            for (int t = 0; t < Console.BufferHeight; t++)
            {

                //ESCRIBIMOS EL NOMBRE COMPLETO SOBRE EL MENU
                if (t == 3)
                {
                    cursorLeft = ((Console.BufferWidth - menu[t].Length) / 2) + 15;
                    cursorTop = (Console.BufferHeight / 4) + t;
                    Console.SetCursorPosition(cursorLeft, cursorTop);
                    Console.WriteLine($"{student.lastName}, {student.firstName}");
                }
                //ESCRIBIMOS EL MAIL SOBRE EL MENU
                else if (t == 4)
                {
                    cursorLeft = ((Console.BufferWidth - menu[t].Length) / 2) + 15;
                    cursorTop = (Console.BufferHeight / 4) + t;
                    Console.SetCursorPosition(cursorLeft, cursorTop);
                    Console.WriteLine($"{student.mail}");
                }
                //ESCRIBIMOS EL TELÉFONO SOBRE EL MENU
                else if (t == 5)
                {
                    cursorLeft = ((Console.BufferWidth - menu[t].Length) / 2) + 15;
                    cursorTop = (Console.BufferHeight / 4) + t;
                    Console.SetCursorPosition(cursorLeft, cursorTop);
                    Console.WriteLine($"{student.phone}");
                }
                //ESCRIBIMOS LA FECHA DE NACIMIENTO SOBRE EL MENU
                else if (t == 6)
                {
                    cursorLeft = ((Console.BufferWidth - menu[t].Length) / 2) + 15;
                    cursorTop = (Console.BufferHeight / 4) + t;
                    Console.SetCursorPosition(cursorLeft, cursorTop);
                    Console.WriteLine($"{student.bornDate}");
                }
                //ESCRIBIMOS LA CALLE SOBRE EL MENU
                else if (t == 7)
                {
                    cursorLeft = ((Console.BufferWidth - menu[t].Length) / 2) + 15;
                    cursorTop = (Console.BufferHeight / 4) + t;
                    Console.SetCursorPosition(cursorLeft, cursorTop);
                    Console.WriteLine($"{student.street}");
                }
                //ESCRIBIMOS EL ID DE TWITTER SOBRE EL MENU
                else if (t == 8)
                {
                    cursorLeft = ((Console.BufferWidth - menu[t].Length) / 2) + 15;
                    cursorTop = (Console.BufferHeight / 4) + t;
                    Console.SetCursorPosition(cursorLeft, cursorTop);
                    Console.WriteLine($"{student.twitterID}");
                }
                //ESCRIBIMOS EL ID DE FACEBOOK SOBRE EL MENU
                else if (t == 9)
                {
                    cursorLeft = ((Console.BufferWidth - menu[t].Length) / 2) + 15;
                    cursorTop = (Console.BufferHeight / 4) + t;
                    Console.SetCursorPosition(cursorLeft, cursorTop);
                    Console.WriteLine($"{student.facebookID}");
                }
                //ESCRIBIMOS EL ID DE INSTAGRAM SOBRE EL MENU
                else if (t == 10)
                {
                    cursorLeft = ((Console.BufferWidth - menu[t].Length) / 2) + 15;
                    cursorTop = (Console.BufferHeight / 4) + t;
                    Console.SetCursorPosition(cursorLeft, cursorTop);
                    Console.WriteLine($"{student.instagramID}");
                }
            }
            //ESTABLECEMOS LA POSICIÓN DEL CURSOR EN EL CAMPO DE INGRESO
            Console.SetCursorPosition(cursorLeftPosition, cursorTopPosition);
            Console.ReadKey();

        }
        public void StudentInfoMenu2(Student student)
        {
            /*
            
            Se genera el menú de información de alumno 2
            
            */

            //VARIABLES PARA MANIPULAR CURSOR
            int cursorTopPosition = 0;
            int cursorLeftPosition = 0;
            int cursorTop = 0;
            int cursorLeft = 0;

            //ALMACENAMOS EL MENÚ EN UN ARREGLO
            string[] menu = new string[16];
            menu[0] = "╔═════════════════════◄►════════════════════╗";
            menu[1] = "║                 AGENDATOR                 ║";
            menu[2] = "╠═══════════════════════════════════════════╣";
            menu[3] = "║ Pais........                              ║";
            menu[4] = "║ Ciudad......                              ║";
            menu[5] = "║ Edad........                              ║";
            menu[6] = "║                                           ║";
            menu[7] = "║                                           ║";
            menu[8] = "║                                           ║";
            menu[9] = "║                                           ║";
            menu[10] = "║                                           ║";
            menu[11] = "╠═══════════════════════════════════════════╣";
            menu[12] = "║                                           ║";
            menu[13] = "║   Presione una tecla para continuar...    ║";
            menu[14] = "║                                           ║";
            menu[15] = "╚═════════════════════◄►════════════════════╝";

            //LIMPIAMOS LA CONSOLA
            Console.Clear();

            //RECORREMOS LA CONSOLA PARA PODER ARMAR INTERFAZ GRÁFICA
            for (int t = 0; t < Console.BufferHeight; t++)
            {
                if (t >= Console.BufferHeight / 4 && t <= (Console.BufferHeight / 4 + 15))
                {
                    for (int j = 0; j < Console.BufferWidth; j++)
                    {
                        if (j >= ((Console.BufferWidth - menu[0].Length) / 2) && j < (((Console.BufferWidth - menu[0].Length) / 2) + menu[0].Length))
                        {
                            if (t == 13)
                            {
                                cursorLeftPosition = ((Console.BufferWidth - menu[t].Length) / 2) + 39;
                                cursorTopPosition = (Console.BufferHeight / 4) + t;
                            }
                            Console.Write("W");
                        }
                        else if (j <= (Console.BufferWidth - menu[0].Length) / 2 || j >= (((Console.BufferWidth - menu[0].Length) / 2) + menu[0].Length))
                        {
                            Console.Write("W");
                        }
                    }
                }
                else
                {
                    for (int j = 0; j < Console.BufferWidth; j++)
                    {
                        Console.Write("W");
                    }
                }
            }

            for (int i = 0; i < 16; i++)
            {
                Console.SetCursorPosition(((Console.BufferWidth - menu[i].Length) / 2), (Console.BufferHeight / 4) + i);
                Console.WriteLine(menu[i]);
            }

            for (int t = 0; t < Console.BufferHeight; t++)
            {
                //ESCRIBIMOS EL PAÍS SOBRE EL MENU
                if (t == 3)
                {
                    cursorLeft = ((Console.BufferWidth - menu[t].Length) / 2) + 15;
                    cursorTop = (Console.BufferHeight / 4) + t;
                    Console.SetCursorPosition(cursorLeft, cursorTop);
                    Console.WriteLine($"{student.country}");
                }
                //ESCRIBIMOS LA CIUDAD SOBRE EL MENU
                else if (t == 4)
                {
                    cursorLeft = ((Console.BufferWidth - menu[t].Length) / 2) + 15;
                    cursorTop = (Console.BufferHeight / 4) + t;
                    Console.SetCursorPosition(cursorLeft, cursorTop);
                    Console.WriteLine($"{student.city}");
                }
                //ESCRIBIMOS LA EDAD SOBRE EL MENU
                else if (t == 5)
                {
                    cursorLeft = ((Console.BufferWidth - menu[t].Length) / 2) + 15;
                    cursorTop = (Console.BufferHeight / 4) + t;
                    Console.SetCursorPosition(cursorLeft, cursorTop);
                    Console.WriteLine($"{student.age}");
                }
                
                
                
            }
            //ESTABLECEMOS LA POSICIÓN DEL CURSOR EN EL CAMPO DE INGRESO
            Console.SetCursorPosition(cursorLeftPosition, cursorTopPosition);
            Console.ReadKey();

        }
        public void InputErrorMessage()
        {
            /*
            
            Se genera alerta de error en ingreso.
            
            */

            //VARIABLES PARA MANIPULAR CURSOR
            int cursorTop = 0;
            int cursorLeft = 0;
           
            //ALMACENAMOS EL MENÚ EN UN ARREGLO
            string[] menu = new string[16];
            menu[0] = "╔═════════════════════◄►════════════════════╗";
            menu[1] = "║                 AGENDATOR                 ║";
            menu[2] = "╠═══════════════════════════════════════════╣";
            menu[3] = "║                                           ║";
            menu[4] = "║   ¡El valor ingresado es incorrecto!      ║";
            menu[5] = "║                                           ║";
            menu[6] = "║                                           ║";
            menu[7] = "║     Para más información referirse        ║";
            menu[8] = "║     a la documentación del programa       ║";
            menu[9] = "║                                           ║";
            menu[10] = "║                                           ║";
            menu[11] = "╠═══════════════════════════════════════════╣";
            menu[12] = "║                                           ║";
            menu[13] = "║    Regresando al menú anterior...         ║";
            menu[14] = "║                                           ║";
            menu[15] = "╚═════════════════════◄►════════════════════╝";

            //LIMPIAMOS LA CONSOLA
            Console.Clear();


            //RECORREMOS LA CONSOLA PARA PODER ARMAR INTERFAZ GRÁFICA
            for (int t = 0; t < Console.BufferHeight; t++)
            {
                if (t >= Console.BufferHeight / 4 && t <= (Console.BufferHeight / 4 + 15))
                {
                    for (int j = 0; j < Console.BufferWidth; j++)
                    {
                        if (j >= ((Console.BufferWidth - menu[0].Length) / 2) && j < (((Console.BufferWidth - menu[0].Length) / 2) + menu[0].Length))
                        {
                            Console.Write("W");
                        }
                        else if (j <= (Console.BufferWidth - menu[0].Length) / 2 || j >= (((Console.BufferWidth - menu[0].Length) / 2) + menu[0].Length))
                        {
                            Console.Write("W");
                        }
                    }
                }
                else
                {
                    for (int j = 0; j < Console.BufferWidth; j++)
                    {
                        Console.Write("W");
                    }
                }
            }

            for (int i = 0; i < 16; i++)
            {
                Console.SetCursorPosition(((Console.BufferWidth - menu[i].Length) / 2), (Console.BufferHeight / 4) + i);
                Console.WriteLine(menu[i]);
            }

            for (int t = 0; t < Console.BufferHeight; t++)
            {

                if (t == 13)
                {
                    cursorLeft = ((Console.BufferWidth - menu[t].Length) / 2) + 36;
                    cursorTop = (Console.BufferHeight / 4) + t;
                }

            }
            //ESTABLECEMOS LA POSICIÓN DEL CURSOR EN EL CAMPO DE INGRESO
            Console.SetCursorPosition(cursorLeft, cursorTop);
            Thread.Sleep(2500);
        }
        public void AddDNIMenu()
        {
            /*
            
            Se genera el menú de información de alumno
            
            */

            //ALMACENAMOS EL MENÚ EN UN ARREGLO
            string[] menu = new string[16];
            menu[0] = "╔═════════════════════◄►════════════════════╗";
            menu[1] = "║                 AGENDATOR                 ║";
            menu[2] = "╠═══════════════════════════════════════════╣";
            menu[3] = "║                                           ║";
            menu[4] = "║  Insertando datos...                      ║";
            menu[5] = "║                                           ║";
            menu[6] = "║                                           ║";
            menu[7] = "║          1/12                             ║";
            menu[8] = "║                                           ║";
            menu[9] = "║          Inserte el DNI:                  ║";
            menu[10] = "║                                           ║";
            menu[11] = "╠═══════════════════════════════════════════╣";
            menu[12] = "║           ┌────────────────────────────┐  ║";
            menu[13] = "║ Ingreso:  ┤                            ├  ║";
            menu[14] = "║           └────────────────────────────┘  ║";
            menu[15] = "╚═════════════════════◄►════════════════════╝";

            //LIMPIAMOS LA CONSOLA
            Console.Clear();

            //RECORREMOS LA CONSOLA PARA PODER ARMAR INTERFAZ GRÁFICA
            for (int t = 0; t < Console.BufferHeight; t++)
            {
                if (t >= Console.BufferHeight / 4 && t <= (Console.BufferHeight / 4 + 15))
                {
                    for (int j = 0; j < Console.BufferWidth; j++)
                    {
                        if (j >= ((Console.BufferWidth - menu[0].Length) / 2) && j < (((Console.BufferWidth - menu[0].Length) / 2) + menu[0].Length))
                        {
                            Console.Write("W");
                        }
                        else if (j <= (Console.BufferWidth - menu[0].Length) / 2 || j >= (((Console.BufferWidth - menu[0].Length) / 2) + menu[0].Length))
                        {
                            Console.Write("W");
                        }
                    }
                }
                else
                {
                    for (int j = 0; j < Console.BufferWidth; j++)
                    {
                        Console.Write("W");
                    }
                }
            }
            for (int i = 0; i < 16; i++)
            {
                Console.SetCursorPosition(((Console.BufferWidth - menu[i].Length) / 2), (Console.BufferHeight / 4) + i);
                Console.WriteLine(menu[i]);
            }

        }
        public void AddNameMenu()
        {

            /*
            
            Se genera el menú de ingreso de nomre
            
            */

            //ALMACENAMOS EL MENÚ EN UN ARREGLO
            string[] menu = new string[16];
            menu[0] = "╔═════════════════════◄►════════════════════╗";
            menu[1] = "║                 AGENDATOR                 ║";
            menu[2] = "╠═══════════════════════════════════════════╣";
            menu[3] = "║                                           ║";
            menu[4] = "║  Insertando datos...                      ║";
            menu[5] = "║                                           ║";
            menu[6] = "║                                           ║";
            menu[7] = "║          2/12                             ║";
            menu[8] = "║                                           ║";
            menu[9] = "║          Inserte el Nombre:               ║";
            menu[10] = "║                                           ║";
            menu[11] = "╠═══════════════════════════════════════════╣";
            menu[12] = "║           ┌────────────────────────────┐  ║";
            menu[13] = "║ Ingreso:  ┤                            ├  ║";
            menu[14] = "║           └────────────────────────────┘  ║";
            menu[15] = "╚═════════════════════◄►════════════════════╝";

            //LIMPIAMOS LA CONSOLA
            Console.Clear();

            //RECORREMOS LA CONSOLA PARA PODER ARMAR INTERFAZ GRÁFICA
            for (int t = 0; t < Console.BufferHeight; t++)
            {
                if (t >= Console.BufferHeight / 4 && t <= (Console.BufferHeight / 4 + 15))
                {
                    for (int j = 0; j < Console.BufferWidth; j++)
                    {
                        if (j >= ((Console.BufferWidth - menu[0].Length) / 2) && j < (((Console.BufferWidth - menu[0].Length) / 2) + menu[0].Length))
                        {
                            Console.Write("W");
                        }
                        else if (j <= (Console.BufferWidth - menu[0].Length) / 2 || j >= (((Console.BufferWidth - menu[0].Length) / 2) + menu[0].Length))
                        {
                            Console.Write("W");
                        }
                    }
                }
                else
                {
                    for (int j = 0; j < Console.BufferWidth; j++)
                    {
                        Console.Write("W");
                    }
                }
            }

            for (int i = 0; i < 16; i++)
            {
                Console.SetCursorPosition(((Console.BufferWidth - menu[i].Length) / 2), (Console.BufferHeight / 4) + i);
                Console.WriteLine(menu[i]);
            }

        }
        public void AddLastNameMenu()
        {
            /*
            
            Se genera el menú de ingreso del apellido
            
            */

            //ALMACENAMOS EL MENÚ EN UN ARREGLO
            string[] menu = new string[16];
            menu[0] = "╔═════════════════════◄►════════════════════╗";
            menu[1] = "║                 AGENDATOR                 ║";
            menu[2] = "╠═══════════════════════════════════════════╣";
            menu[3] = "║                                           ║";
            menu[4] = "║  Insertando datos...                      ║";
            menu[5] = "║                                           ║";
            menu[6] = "║                                           ║";
            menu[7] = "║          3/12                             ║";
            menu[8] = "║                                           ║";
            menu[9] = "║          Inserte el Apellido:              ║";
            menu[10] = "║                                           ║";
            menu[11] = "╠═══════════════════════════════════════════╣";
            menu[12] = "║           ┌────────────────────────────┐  ║";
            menu[13] = "║ Ingreso:  ┤                            ├  ║";
            menu[14] = "║           └────────────────────────────┘  ║";
            menu[15] = "╚═════════════════════◄►════════════════════╝";

            //LIMPIAMOS LA CONSOLA
            Console.Clear();

            for (int t = 0; t < Console.BufferHeight; t++)
            {
                if (t >= Console.BufferHeight / 4 && t <= (Console.BufferHeight / 4 + 15))
                {
                    for (int j = 0; j < Console.BufferWidth; j++)
                    {
                        if (j >= ((Console.BufferWidth - menu[0].Length) / 2) && j < (((Console.BufferWidth - menu[0].Length) / 2) + menu[0].Length))
                        {
                            Console.Write("W");
                        }
                        else if (j <= (Console.BufferWidth - menu[0].Length) / 2 || j >= (((Console.BufferWidth - menu[0].Length) / 2) + menu[0].Length))
                        {
                            Console.Write("W");
                        }
                    }
                }
                else
                {
                    for (int j = 0; j < Console.BufferWidth; j++)
                    {
                        Console.Write("W");
                    }
                }
            }

            for (int i = 0; i < 16; i++)
            {
                Console.SetCursorPosition(((Console.BufferWidth - menu[i].Length) / 2), (Console.BufferHeight / 4) + i);
                Console.WriteLine(menu[i]);
            }
        }
        public void AddMailMenu()
        {

            /*
            
            Se genera el menú de ingreso de mail
            
            */

            //ALMACENAMOS EL MENÚ EN UN ARREGLO
            string[] menu = new string[16];
            menu[0] = "╔═════════════════════◄►════════════════════╗";
            menu[1] = "║                 AGENDATOR                 ║";
            menu[2] = "╠═══════════════════════════════════════════╣";
            menu[3] = "║                                           ║";
            menu[4] = "║  Insertando datos...                      ║";
            menu[5] = "║                                           ║";
            menu[6] = "║                                           ║";
            menu[7] = "║          4/12                             ║";
            menu[8] = "║                                           ║";
            menu[9] = "║          Inserte el mail:                 ║";
            menu[10] = "║                                           ║";
            menu[11] = "╠═══════════════════════════════════════════╣";
            menu[12] = "║           ┌────────────────────────────┐  ║";
            menu[13] = "║ Ingreso:  ┤                            ├  ║";
            menu[14] = "║           └────────────────────────────┘  ║";
            menu[15] = "╚═════════════════════◄►════════════════════╝";

            //LIMPIAMOS LA CONSOLA
            Console.Clear();

            //RECORREMOS LA CONSOLA PARA PODER ARMAR INTERFAZ GRÁFICA
            for (int t = 0; t < Console.BufferHeight; t++)
            {
                if (t >= Console.BufferHeight / 4 && t <= (Console.BufferHeight / 4 + 15))
                {
                    for (int j = 0; j < Console.BufferWidth; j++)
                    {
                        if (j >= ((Console.BufferWidth - menu[0].Length) / 2) && j < (((Console.BufferWidth - menu[0].Length) / 2) + menu[0].Length))
                        {
                            Console.Write("W");
                        }
                        else if (j <= (Console.BufferWidth - menu[0].Length) / 2 || j >= (((Console.BufferWidth - menu[0].Length) / 2) + menu[0].Length))
                        {
                            Console.Write("W");
                        }
                    }
                }
                else
                {
                    for (int j = 0; j < Console.BufferWidth; j++)
                    {
                        Console.Write("W");
                    }
                }
            }

            for (int i = 0; i < 16; i++)
            {
                Console.SetCursorPosition(((Console.BufferWidth - menu[i].Length) / 2), (Console.BufferHeight / 4) + i);
                Console.WriteLine(menu[i]);
            }


        }
        public void AddPhoneMenu()
        {

            /*
            
            Se genera el menú de ingreso de teléfono
            
            */

            //ALMACENAMOS EL MENÚ EN UN ARREGLO
            string[] menu = new string[16];
            menu[0] = "╔═════════════════════◄►════════════════════╗";
            menu[1] = "║                 AGENDATOR                 ║";
            menu[2] = "╠═══════════════════════════════════════════╣";
            menu[3] = "║                                           ║";
            menu[4] = "║  Insertando datos...                      ║";
            menu[5] = "║                                           ║";
            menu[6] = "║                                           ║";
            menu[7] = "║          5/12                             ║";
            menu[8] = "║                                           ║";
            menu[9] = "║          Inserte el teléfono:             ║";
            menu[10] = "║                                           ║";
            menu[11] = "╠═══════════════════════════════════════════╣";
            menu[12] = "║           ┌────────────────────────────┐  ║";
            menu[13] = "║ Ingreso:  ┤                            ├  ║";
            menu[14] = "║           └────────────────────────────┘  ║";
            menu[15] = "╚═════════════════════◄►════════════════════╝";

            //LIMPIAMOS LA CONSOLA
            Console.Clear();

            //RECORREMOS LA CONSOLA PARA PODER ARMAR INTERFAZ GRÁFICA
            for (int t = 0; t < Console.BufferHeight; t++)
            {
                if (t >= Console.BufferHeight / 4 && t <= (Console.BufferHeight / 4 + 15))
                {
                    for (int j = 0; j < Console.BufferWidth; j++)
                    {
                        if (j >= ((Console.BufferWidth - menu[0].Length) / 2) && j < (((Console.BufferWidth - menu[0].Length) / 2) + menu[0].Length))
                        {
                            Console.Write("W");
                        }
                        else if (j <= (Console.BufferWidth - menu[0].Length) / 2 || j >= (((Console.BufferWidth - menu[0].Length) / 2) + menu[0].Length))
                        {
                            Console.Write("W");
                        }
                    }
                }
                else
                {
                    for (int j = 0; j < Console.BufferWidth; j++)
                    {
                        Console.Write("W");
                    }
                }
            }

            for (int i = 0; i < 16; i++)
            {
                Console.SetCursorPosition(((Console.BufferWidth - menu[i].Length) / 2), (Console.BufferHeight / 4) + i);
                Console.WriteLine(menu[i]);
            }

        }
        public void AddBornDateMenu()
        {
            /*
            
            Se genera el menú de ingreso de fecha de nacimiento
            
            */

            //ALMACENAMOS EL MENÚ EN UN ARREGLO
            string[] menu = new string[16];
            menu[0] = "╔═════════════════════◄►════════════════════╗";
            menu[1] = "║                 AGENDATOR                 ║";
            menu[2] = "╠═══════════════════════════════════════════╣";
            menu[3] = "║                                           ║";
            menu[4] = "║  Insertando datos...                      ║";
            menu[5] = "║                                           ║";
            menu[6] = "║                                           ║";
            menu[7] = "║          6/12                             ║";
            menu[8] = "║                                           ║";
            menu[9] = "║        Inserte fecha de nacimiento:       ║";
            menu[10] = "║                                           ║";
            menu[11] = "╠═══════════════════════════════════════════╣";
            menu[12] = "║           ┌────────────┐                  ║";
            menu[13] = "║ Ingreso:  ┤   /  /     ├                  ║";
            menu[14] = "║           └────────────┘                  ║";
            menu[15] = "╚═════════════════════◄►════════════════════╝";

            //LIMPIAMOS LA CONSOLA
            Console.Clear();

            //RECORREMOS LA CONSOLA PARA PODER ARMAR INTERFAZ GRÁFICA
            for (int t = 0; t < Console.BufferHeight; t++)
            {
                if (t >= Console.BufferHeight / 4 && t <= (Console.BufferHeight / 4 + 15))
                {
                    for (int j = 0; j < Console.BufferWidth; j++)
                    {
                        if (j >= ((Console.BufferWidth - menu[0].Length) / 2) && j < (((Console.BufferWidth - menu[0].Length) / 2) + menu[0].Length))
                        {
                            Console.Write("W");
                        }
                        else if (j <= (Console.BufferWidth - menu[0].Length) / 2 || j >= (((Console.BufferWidth - menu[0].Length) / 2) + menu[0].Length))
                        {
                            Console.Write("W");
                        }
                    }
                }
                else
                {
                    for (int j = 0; j < Console.BufferWidth; j++)
                    {
                        Console.Write("W");
                    }
                }
            }

            for (int i = 0; i < 16; i++)
            {
                Console.SetCursorPosition(((Console.BufferWidth - menu[i].Length) / 2), (Console.BufferHeight / 4) + i);
                Console.WriteLine(menu[i]);
            }
        }
        public void AddFacebookIDMenu()
        {
            /*
            
            Se genera el menú de ingreso de Facebook ID
            
            */

            //ALMACENAMOS EL MENÚ EN UN ARREGLO
            string[] menu = new string[16];
            menu[0] = "╔═════════════════════◄►════════════════════╗";
            menu[1] = "║                 AGENDATOR                 ║";
            menu[2] = "╠═══════════════════════════════════════════╣";
            menu[3] = "║                                           ║";
            menu[4] = "║  Insertando datos...                      ║";
            menu[5] = "║                                           ║";
            menu[6] = "║                                           ║";
            menu[7] = "║          7/12                             ║";
            menu[8] = "║                                           ║";
            menu[9] = "║     Inserte el usuario de Facebook:       ║";
            menu[10] = "║                                           ║";
            menu[11] = "╠═══════════════════════════════════════════╣";
            menu[12] = "║           ┌────────────────────────────┐  ║";
            menu[13] = "║ Ingreso:  ┤                            ├  ║";
            menu[14] = "║           └────────────────────────────┘  ║";
            menu[15] = "╚═════════════════════◄►════════════════════╝";

            //LIMPIAMOS LA CONSOLA
            Console.Clear();

            //RECORREMOS LA CONSOLA PARA PODER ARMAR INTERFAZ GRÁFICA
            for (int t = 0; t < Console.BufferHeight; t++)
            {
                if (t >= Console.BufferHeight / 4 && t <= (Console.BufferHeight / 4 + 15))
                {
                    for (int j = 0; j < Console.BufferWidth; j++)
                    {
                        if (j >= ((Console.BufferWidth - menu[0].Length) / 2) && j < (((Console.BufferWidth - menu[0].Length) / 2) + menu[0].Length))
                        {
                            Console.Write("W");
                        }
                        else if (j <= (Console.BufferWidth - menu[0].Length) / 2 || j >= (((Console.BufferWidth - menu[0].Length) / 2) + menu[0].Length))
                        {
                            Console.Write("W");
                        }
                    }
                }
                else
                {
                    for (int j = 0; j < Console.BufferWidth; j++)
                    {
                        Console.Write("W");
                    }
                }
            }

            for (int i = 0; i < 16; i++)
            {
                Console.SetCursorPosition(((Console.BufferWidth - menu[i].Length) / 2), (Console.BufferHeight / 4) + i);
                Console.WriteLine(menu[i]);
            }

        }
        public void AddTwitterIDMenu()
        {
            /*
            
            Se genera el menú de ingreso de Twitter ID
            
            */


            //ALMACENAMOS EL MENÚ EN UN ARREGLO
            string[] menu = new string[16];
            menu[0] = "╔═════════════════════◄►════════════════════╗";
            menu[1] = "║                 AGENDATOR                 ║";
            menu[2] = "╠═══════════════════════════════════════════╣";
            menu[3] = "║                                           ║";
            menu[4] = "║  Insertando datos...                      ║";
            menu[5] = "║                                           ║";
            menu[6] = "║                                           ║";
            menu[7] = "║          8/12                             ║";
            menu[8] = "║                                           ║";
            menu[9] = "║     Inserte el usuario de Twitter:        ║";
            menu[10] = "║                                           ║";
            menu[11] = "╠═══════════════════════════════════════════╣";
            menu[12] = "║           ┌────────────────────────────┐  ║";
            menu[13] = "║ Ingreso:  ┤                            ├  ║";
            menu[14] = "║           └────────────────────────────┘  ║";
            menu[15] = "╚═════════════════════◄►════════════════════╝";

            //LIMPIAMOS LA CONSOLA
            Console.Clear();

            //RECORREMOS LA CONSOLA PARA PODER ARMAR INTERFAZ GRÁFICA
            for (int t = 0; t < Console.BufferHeight; t++)
            {
                if (t >= Console.BufferHeight / 4 && t <= (Console.BufferHeight / 4 + 15))
                {
                    for (int j = 0; j < Console.BufferWidth; j++)
                    {
                        if (j >= ((Console.BufferWidth - menu[0].Length) / 2) && j < (((Console.BufferWidth - menu[0].Length) / 2) + menu[0].Length))
                        {
                            Console.Write("W");
                        }
                        else if (j <= (Console.BufferWidth - menu[0].Length) / 2 || j >= (((Console.BufferWidth - menu[0].Length) / 2) + menu[0].Length))
                        {
                            Console.Write("W");
                        }
                    }
                }
                else
                {
                    for (int j = 0; j < Console.BufferWidth; j++)
                    {
                        Console.Write("W");
                    }
                }
            }

            for (int i = 0; i < 16; i++)
            {
                Console.SetCursorPosition(((Console.BufferWidth - menu[i].Length) / 2), (Console.BufferHeight / 4) + i);
                Console.WriteLine(menu[i]);
            }
        }
        public void AddInstagramIDMenu()
        {
            /*
            
            Se genera el menú de ingreso de Instagram ID
            
            */

            //ALMACENAMOS EL MENÚ EN UN ARREGLO
            string[] menu = new string[16];
            menu[0] = "╔═════════════════════◄►════════════════════╗";
            menu[1] = "║                 AGENDATOR                 ║";
            menu[2] = "╠═══════════════════════════════════════════╣";
            menu[3] = "║                                           ║";
            menu[4] = "║  Insertando datos...                      ║";
            menu[5] = "║                                           ║";
            menu[6] = "║                                           ║";
            menu[7] = "║          9/12                             ║";
            menu[8] = "║                                           ║";
            menu[9] = "║     Inserte el usuario de Instagram:      ║";
            menu[10] = "║                                           ║";
            menu[11] = "╠═══════════════════════════════════════════╣";
            menu[12] = "║           ┌────────────────────────────┐  ║";
            menu[13] = "║ Ingreso:  ┤                            ├  ║";
            menu[14] = "║           └────────────────────────────┘  ║";
            menu[15] = "╚═════════════════════◄►════════════════════╝";

            //LIMPIAMOS LA CONSOLA
            Console.Clear();

            //RECORREMOS LA CONSOLA PARA PODER ARMAR INTERFAZ GRÁFICA
            for (int t = 0; t < Console.BufferHeight; t++)
            {
                if (t >= Console.BufferHeight / 4 && t <= (Console.BufferHeight / 4 + 15))
                {
                    for (int j = 0; j < Console.BufferWidth; j++)
                    {
                        if (j >= ((Console.BufferWidth - menu[0].Length) / 2) && j < (((Console.BufferWidth - menu[0].Length) / 2) + menu[0].Length))
                        {
                            Console.Write("W");
                        }
                        else if (j <= (Console.BufferWidth - menu[0].Length) / 2 || j >= (((Console.BufferWidth - menu[0].Length) / 2) + menu[0].Length))
                        {
                            Console.Write("W");
                        }
                    }
                }
                else
                {
                    for (int j = 0; j < Console.BufferWidth; j++)
                    {
                        Console.Write("W");
                    }
                }
            }

            for (int i = 0; i < 16; i++)
            {
                Console.SetCursorPosition(((Console.BufferWidth - menu[i].Length) / 2), (Console.BufferHeight / 4) + i);
                Console.WriteLine(menu[i]);
            }
        }
        public void AddCountryMenu()
        {
            /*
            
            Se genera el menú de ingreso del país
            
            */

            //ALMACENAMOS EL MENÚ EN UN ARREGLO
            string[] menu = new string[16];
            menu[0] = "╔═════════════════════◄►════════════════════╗";
            menu[1] = "║                 AGENDATOR                 ║";
            menu[2] = "╠═══════════════════════════════════════════╣";
            menu[3] = "║                                           ║";
            menu[4] = "║  Insertando datos...                      ║";
            menu[5] = "║                                           ║";
            menu[6] = "║                                           ║";
            menu[7] = "║          10/12                            ║";
            menu[8] = "║                                           ║";
            menu[9] = "║             Inserte el país:              ║";
            menu[10] = "║                                           ║";
            menu[11] = "╠═══════════════════════════════════════════╣";
            menu[12] = "║           ┌────────────────────────────┐  ║";
            menu[13] = "║ Ingreso:  ┤                            ├  ║";
            menu[14] = "║           └────────────────────────────┘  ║";
            menu[15] = "╚═════════════════════◄►════════════════════╝";

            //LIMPIAMOS LA CONSOLA
            Console.Clear();

            //RECORREMOS LA CONSOLA PARA PODER ARMAR INTERFAZ GRÁFICA
            for (int t = 0; t < Console.BufferHeight; t++)
            {
                if (t >= Console.BufferHeight / 4 && t <= (Console.BufferHeight / 4 + 15))
                {
                    for (int j = 0; j < Console.BufferWidth; j++)
                    {
                        if (j >= ((Console.BufferWidth - menu[0].Length) / 2) && j < (((Console.BufferWidth - menu[0].Length) / 2) + menu[0].Length))
                        {
                            Console.Write("W");
                        }
                        else if (j <= (Console.BufferWidth - menu[0].Length) / 2 || j >= (((Console.BufferWidth - menu[0].Length) / 2) + menu[0].Length))
                        {
                            Console.Write("W");
                        }
                    }
                }
                else
                {
                    for (int j = 0; j < Console.BufferWidth; j++)
                    {
                        Console.Write("W");
                    }
                }
            }

            for (int i = 0; i < 16; i++)
            {
                Console.SetCursorPosition(((Console.BufferWidth - menu[i].Length) / 2), (Console.BufferHeight / 4) + i);
                Console.WriteLine(menu[i]);
            }
        }
        public void AddCityMenu()
        {
            /*
            
            Se genera el menú de ingreso de la ciudad
            
            */

            //ALMACENAMOS EL MENÚ EN UN ARREGLO
            string[] menu = new string[16];
            menu[0] = "╔═════════════════════◄►════════════════════╗";
            menu[1] = "║                 AGENDATOR                 ║";
            menu[2] = "╠═══════════════════════════════════════════╣";
            menu[3] = "║                                           ║";
            menu[4] = "║  Insertando datos...                      ║";
            menu[5] = "║                                           ║";
            menu[6] = "║                                           ║";
            menu[7] = "║          11/12                            ║";
            menu[8] = "║                                           ║";
            menu[9] = "║             Inserte la ciudad:             ║";
            menu[10] = "║                                           ║";
            menu[11] = "╠═══════════════════════════════════════════╣";
            menu[12] = "║           ┌────────────────────────────┐  ║";
            menu[13] = "║ Ingreso:  ┤                            ├  ║";
            menu[14] = "║           └────────────────────────────┘  ║";
            menu[15] = "╚═════════════════════◄►════════════════════╝";

            //LIMPIAMOS LA CONSOLA
            Console.Clear();

            //RECORREMOS LA CONSOLA PARA PODER ARMAR INTERFAZ GRÁFICA
            for (int t = 0; t < Console.BufferHeight; t++)
            {
                if (t >= Console.BufferHeight / 4 && t <= (Console.BufferHeight / 4 + 15))
                {
                    for (int j = 0; j < Console.BufferWidth; j++)
                    {
                        if (j >= ((Console.BufferWidth - menu[0].Length) / 2) && j < (((Console.BufferWidth - menu[0].Length) / 2) + menu[0].Length))
                        {
                            Console.Write("W");
                        }
                        else if (j <= (Console.BufferWidth - menu[0].Length) / 2 || j >= (((Console.BufferWidth - menu[0].Length) / 2) + menu[0].Length))
                        {
                            Console.Write("W");
                        }
                    }
                }
                else
                {
                    for (int j = 0; j < Console.BufferWidth; j++)
                    {
                        Console.Write("W");
                    }
                }
            }

            for (int i = 0; i < 16; i++)
            {
                Console.SetCursorPosition(((Console.BufferWidth - menu[i].Length) / 2), (Console.BufferHeight / 4) + i);
                Console.WriteLine(menu[i]);
            }
        }
        public void AddStreetMenu()
        {
            /*
            
            Se genera el menú de información de alumno
            
            */

            //ALMACENAMOS EL MENÚ EN UN ARREGLO
            string[] menu = new string[16];
            menu[0] = "╔═════════════════════◄►════════════════════╗";
            menu[1] = "║                 AGENDATOR                 ║";
            menu[2] = "╠═══════════════════════════════════════════╣";
            menu[3] = "║                                           ║";
            menu[4] = "║  Insertando datos...                      ║";
            menu[5] = "║                                           ║";
            menu[6] = "║                                           ║";
            menu[7] = "║          12/12                            ║";
            menu[8] = "║                                           ║";
            menu[9] = "║        Inserte el domicilio (Calle):      ║";
            menu[10] = "║                                           ║";
            menu[11] = "╠═══════════════════════════════════════════╣";
            menu[12] = "║           ┌────────────────────────────┐  ║";
            menu[13] = "║ Ingreso:  ┤                            ├  ║";
            menu[14] = "║           └────────────────────────────┘  ║";
            menu[15] = "╚═════════════════════◄►════════════════════╝";

            //LIMPIAMOS LA CONSOLA
            Console.Clear();

            for (int t = 0; t < Console.BufferHeight; t++)
            {
                if (t >= Console.BufferHeight / 4 && t <= (Console.BufferHeight / 4 + 15))
                {
                    for (int j = 0; j < Console.BufferWidth; j++)
                    {
                        if (j >= ((Console.BufferWidth - menu[0].Length) / 2) && j < (((Console.BufferWidth - menu[0].Length) / 2) + menu[0].Length))
                        {
                            Console.Write("W");
                        }
                        else if (j <= (Console.BufferWidth - menu[0].Length) / 2 || j >= (((Console.BufferWidth - menu[0].Length) / 2) + menu[0].Length))
                        {
                            Console.Write("W");
                        }
                    }
                }
                else
                {
                    for (int j = 0; j < Console.BufferWidth; j++)
                    {
                        Console.Write("W");
                    }
                }
            }

            for (int i = 0; i < 16; i++)
            {
                Console.SetCursorPosition(((Console.BufferWidth - menu[i].Length) / 2), (Console.BufferHeight / 4) + i);
                Console.WriteLine(menu[i]);
            }

        }
        public void StudentAdded(Student student)
        {
            /*
            
            Se genera alerta de error en ingreso.
            
            */

            //VARIABLES PARA MANIPULAR CURSOR
            int cursorTop = 0;
            int cursorLeft = 0;

            //ALMACENAMOS EL MENÚ EN UN ARREGLO
            string[] menu = new string[16];
            menu[0] = "╔═════════════════════◄►════════════════════╗";
            menu[1] = "║                 AGENDATOR                 ║";
            menu[2] = "╠═══════════════════════════════════════════╣";
            menu[3] = "║                                           ║";
            menu[4] = "║              ¡Carga exitosa!              ║";
            menu[5] = "║                                           ║";
            menu[6] = "║                                           ║";
            menu[7] = "║     Se logró agregar a su agenda a:       ║";
            menu[8] = "║                                           ║";
            menu[9] = "║                                           ║";
            menu[10] = "║                                           ║";
            menu[11] = "╠═══════════════════════════════════════════╣";
            menu[12] = "║                                           ║";
            menu[13] = "║   Presione una tecla para continuar...    ║";
            menu[14] = "║                                           ║";
            menu[15] = "╚═════════════════════◄►════════════════════╝";

            //LIMPIAMOS LA CONSOLA
            Console.Clear();

            for (int t = 0; t < Console.BufferHeight; t++)
            {
                if (t >= Console.BufferHeight / 4 && t <= (Console.BufferHeight / 4 + 15))
                {
                    for (int j = 0; j < Console.BufferWidth; j++)
                    {
                        if (j >= ((Console.BufferWidth - menu[0].Length) / 2) && j < (((Console.BufferWidth - menu[0].Length) / 2) + menu[0].Length))
                        {
                            Console.Write("W");
                        }
                        else if (j <= (Console.BufferWidth - menu[0].Length) / 2 || j >= (((Console.BufferWidth - menu[0].Length) / 2) + menu[0].Length))
                        {
                            Console.Write("W");
                        }
                    }
                }
                else
                {
                    for (int j = 0; j < Console.BufferWidth; j++)
                    {
                        Console.Write("W");
                    }
                }
            }

            for (int i = 0; i < 16; i++)
            {
                Console.SetCursorPosition(((Console.BufferWidth - menu[i].Length) / 2), (Console.BufferHeight / 4) + i);
                Console.WriteLine(menu[i]);
            }

            for (int t = 0; t < Console.BufferHeight; t++)
            {

                if (t == 9)
                {
                    cursorLeft = ((Console.BufferWidth - menu[t].Length) / 2) + 5;
                    cursorTop = (Console.BufferHeight / 4) + t;
                }

            }
            //ESTABLECEMOS LA POSICIÓN DEL CURSOR EN EL CAMPO DE INGRESO
            Console.SetCursorPosition(cursorLeft, cursorTop);
            Console.WriteLine($"{student.lastName}, {student.firstName}");
            Console.ReadKey();
        }
        public void ReadDNIStudentForDropMenu()
        {

            /*
            
            Se genera el menú de información de alumno
            
            */

            //ALMACENAMOS EL MENÚ EN UN ARREGLO
            string[] menu = new string[16];
            menu[0] = "╔═════════════════════◄►════════════════════╗";
            menu[1] = "║                 AGENDATOR                 ║";
            menu[2] = "╠═══════════════════════════════════════════╣";
            menu[3] = "║                                           ║";
            menu[4] = "║     Ingrese el DNI de la persona          ║";
            menu[5] = "║     que desea quitar de su agenda         ║";
            menu[6] = "║                                           ║";
            menu[7] = "║                                           ║";
            menu[8] = "║                                           ║";
            menu[9] = "║                                           ║";
            menu[10] = "║                                           ║";
            menu[11] = "╠═══════════════════════════════════════════╣";
            menu[12] = "║           ┌────────────────────────────┐  ║";
            menu[13] = "║ Ingreso:  ┤                            ├  ║";
            menu[14] = "║           └────────────────────────────┘  ║";
            menu[15] = "╚═════════════════════◄►════════════════════╝";

            //LIMPIAMOS LA CONSOLA
            Console.Clear();

            //RECORREMOS LA CONSOLA PARA PODER ARMAR INTERFAZ GRÁFICA
            for (int t = 0; t < Console.BufferHeight; t++)
            {
                if (t >= Console.BufferHeight / 4 && t <= (Console.BufferHeight / 4 + 15))
                {
                    for (int j = 0; j < Console.BufferWidth; j++)
                    {
                        if (j >= ((Console.BufferWidth - menu[0].Length) / 2) && j < (((Console.BufferWidth - menu[0].Length) / 2) + menu[0].Length))
                        {
                            Console.Write("W");
                        }
                        else if (j <= (Console.BufferWidth - menu[0].Length) / 2 || j >= (((Console.BufferWidth - menu[0].Length) / 2) + menu[0].Length))
                        {
                            Console.Write("W");
                        }
                    }
                }
                else
                {
                    for (int j = 0; j < Console.BufferWidth; j++)
                    {
                        Console.Write("W");
                    }
                }
            }
            for (int i = 0; i < 16; i++)
            {
                Console.SetCursorPosition(((Console.BufferWidth - menu[i].Length) / 2), (Console.BufferHeight / 4) + i);
                Console.WriteLine(menu[i]);
            }
            
        }
        public void StudentDeleted(int DNI)
        {
            /*
            
            Se genera alerta de error en ingreso.
            
            */

            //VARIABLES PARA MANIPULAR CURSOR
            int cursorTop = 0;
            int cursorLeft = 0;

            //ALMACENAMOS EL MENÚ EN UN ARREGLO
            string[] menu = new string[16];
            menu[0] = "╔═════════════════════◄►════════════════════╗";
            menu[1] = "║                 AGENDATOR                 ║";
            menu[2] = "╠═══════════════════════════════════════════╣";
            menu[3] = "║                                           ║";
            menu[4] = "║          ¡Eliminación Exitosa!            ║";
            menu[5] = "║                                           ║";
            menu[6] = "║                                           ║";
            menu[7] = "║   Se logró quitar de su agenda al DNI:    ║";
            menu[8] = "║                                           ║";
            menu[9] = "║                                           ║";
            menu[10] = "║                                           ║";
            menu[11] = "╠═══════════════════════════════════════════╣";
            menu[12] = "║                                           ║";
            menu[13] = "║   Presione una tecla para continuar...    ║";
            menu[14] = "║                                           ║";
            menu[15] = "╚═════════════════════◄►════════════════════╝";

            //LIMPIAMOS LA CONSOLA
            Console.Clear();

            //RECORREMOS LA CONSOLA PARA PODER ARMAR INTERFAZ GRÁFICA
            for (int t = 0; t < Console.BufferHeight; t++)
            {
                if (t >= Console.BufferHeight / 4 && t <= (Console.BufferHeight / 4 + 15))
                {
                    for (int j = 0; j < Console.BufferWidth; j++)
                    {
                        if (j >= ((Console.BufferWidth - menu[0].Length) / 2) && j < (((Console.BufferWidth - menu[0].Length) / 2) + menu[0].Length))
                        {
                            Console.Write("W");
                        }
                        else if (j <= (Console.BufferWidth - menu[0].Length) / 2 || j >= (((Console.BufferWidth - menu[0].Length) / 2) + menu[0].Length))
                        {
                            Console.Write("W");
                        }
                    }
                }
                else
                {
                    for (int j = 0; j < Console.BufferWidth; j++)
                    {
                        Console.Write("W");
                    }
                }
            }

            for (int i = 0; i < 16; i++)
            {
                Console.SetCursorPosition(((Console.BufferWidth - menu[i].Length) / 2), (Console.BufferHeight / 4) + i);
                Console.WriteLine(menu[i]);
            }

            for (int t = 0; t < Console.BufferHeight; t++)
            {

                if (t == 9)
                {
                    cursorLeft = ((Console.BufferWidth - menu[t].Length) / 2) + 5;
                    cursorTop = (Console.BufferHeight / 4) + t;
                }

            }
            Console.SetCursorPosition(cursorLeft, cursorTop);
            Console.WriteLine($"{DNI}");
            Console.ReadKey();
        }
        public void StudentNotFound()
        {
            /*
            
            Se genera alerta de error en ingreso.
            
            */

            //VARIABLES PARA MANIPULAR CURSOR
            int cursorTop = 0;
            int cursorLeft = 0;

            //ALMACENAMOS EL MENÚ EN UN ARREGLO
            string[] menu = new string[16];
            menu[0] = "╔═════════════════════◄►════════════════════╗";
            menu[1] = "║                 AGENDATOR                 ║";
            menu[2] = "╠═══════════════════════════════════════════╣";
            menu[3] = "║                                           ║";
            menu[4] = "║     El usuario que intenta eliminar       ║";
            menu[5] = "║      no existe en base de datos           ║";
            menu[6] = "║                                           ║";
            menu[7] = "║                                           ║";
            menu[8] = "║                                           ║";
            menu[9] = "║                                           ║";
            menu[10] = "║                                           ║";
            menu[11] = "╠═══════════════════════════════════════════╣";
            menu[12] = "║                                           ║";
            menu[13] = "║    Regresando al menú principal...        ║";
            menu[14] = "║                                           ║";
            menu[15] = "╚═════════════════════◄►════════════════════╝";

            //LIMPIAMOS LA CONSOLA
            Console.Clear();

            //RECORREMOS LA CONSOLA PARA PODER ARMAR INTERFAZ GRÁFICA
            for (int t = 0; t < Console.BufferHeight; t++)
            {
                if (t >= Console.BufferHeight / 4 && t <= (Console.BufferHeight / 4 + 15))
                {
                    for (int j = 0; j < Console.BufferWidth; j++)
                    {
                        if (j >= ((Console.BufferWidth - menu[0].Length) / 2) && j < (((Console.BufferWidth - menu[0].Length) / 2) + menu[0].Length))
                        {
                            Console.Write("W");
                        }
                        else if (j <= (Console.BufferWidth - menu[0].Length) / 2 || j >= (((Console.BufferWidth - menu[0].Length) / 2) + menu[0].Length))
                        {
                            Console.Write("W");
                        }
                    }
                }
                else
                {
                    for (int j = 0; j < Console.BufferWidth; j++)
                    {
                        Console.Write("W");
                    }
                }
            }

            for (int i = 0; i < 16; i++)
            {
                Console.SetCursorPosition(((Console.BufferWidth - menu[i].Length) / 2), (Console.BufferHeight / 4) + i);
                Console.WriteLine(menu[i]);
            }

            for (int t = 0; t < Console.BufferHeight; t++)
            {

                if (t == 13)
                {
                    cursorLeft = ((Console.BufferWidth - menu[t].Length) / 2) + 36;
                    cursorTop = (Console.BufferHeight / 4) + t;
                }

            }
            //ESTABLECEMOS LA POSICIÓN DEL CURSOR EN EL CAMPO DE INGRESO
            Console.SetCursorPosition(cursorLeft, cursorTop);
            Thread.Sleep(2500);
        }
        public void DeleteStudentConfirm(Student student)
        {
            /*
            
            Se genera alerta de error en ingreso.
            
            */

            //VARIABLES PARA MANIPULAR CURSOR
            int cursorTop = 0;
            int cursorLeft = 0;

            //ALMACENAMOS EL MENÚ EN UN ARREGLO
            string[] menu = new string[16];
            menu[0] = "╔═════════════════════◄►════════════════════╗";
            menu[1] = "║                 AGENDATOR                 ║";
            menu[2] = "╠═══════════════════════════════════════════╣";
            menu[3] = "║                                           ║";
            menu[4] = "║¿Seguro desea quitar al siguiente contacto?║";
            menu[5] = "║                                           ║";
            menu[6] = "║                                           ║";
            menu[7] = "║                                           ║";
            menu[8] = "║                                           ║";
            menu[9] = "║                                           ║";
            menu[10] = "║                                           ║";
            menu[11] = "╠═══════════════════════════════════════════╣";
            menu[12] = "║                                           ║";
            menu[13] = "║         Seleccione S(Si) | N(No)          ║";
            menu[14] = "║                                           ║";
            menu[15] = "╚═════════════════════◄►════════════════════╝";

            //LIMPIAMOS LA CONSOLA
            Console.Clear();

            //RECORREMOS LA CONSOLA PARA PODER ARMAR INTERFAZ GRÁFICA
            for (int t = 0; t < Console.BufferHeight; t++)
            {
                if (t >= Console.BufferHeight / 4 && t <= (Console.BufferHeight / 4 + 15))
                {
                    for (int j = 0; j < Console.BufferWidth; j++)
                    {
                        if (j >= ((Console.BufferWidth - menu[0].Length) / 2) && j < (((Console.BufferWidth - menu[0].Length) / 2) + menu[0].Length))
                        {
                            Console.Write("W");
                        }
                        else if (j <= (Console.BufferWidth - menu[0].Length) / 2 || j >= (((Console.BufferWidth - menu[0].Length) / 2) + menu[0].Length))
                        {
                            Console.Write("W");
                        }
                    }
                }
                else
                {
                    for (int j = 0; j < Console.BufferWidth; j++)
                    {
                        Console.Write("W");
                    }
                }
            }

            for (int i = 0; i < 16; i++)
            {
                Console.SetCursorPosition(((Console.BufferWidth - menu[i].Length) / 2), (Console.BufferHeight / 4) + i);
                Console.WriteLine(menu[i]);
            }

            for (int t = 0; t < Console.BufferHeight; t++)
            {

                if (t == 9)
                {
                    cursorLeft = ((Console.BufferWidth - menu[t].Length) / 2) + 5;
                    cursorTop = (Console.BufferHeight / 4) + t;
                }

            }
            //ESTABLECEMOS LA POSICIÓN DEL CURSOR EN EL CAMPO DE INGRESO
            Console.SetCursorPosition(cursorLeft, cursorTop);
            Console.WriteLine($"{student.lastName}, {student.firstName}");
        }
        public void SelectValueForUpdateMenu()
        {
            /*
            
            Se genera el menú de información de alumno
            
            */

            //VARIABLES PARA MANIPULAR CURSOR
            int cursorTopPosition = 0;
            int cursorLeftPosition = 0;

            //ALMACENAMOS EL MENÚ EN UN ARREGLO
            string[] menu = new string[16];
            menu[0] = "╔═════════════════════◄►════════════════════╗";
            menu[1] = "║                 AGENDATOR                 ║";
            menu[2] = "╠═════════════════════╦╦════════════════════╣";
            menu[3] = "║                     ║║                    ║";
            menu[4] = "║    a.- Nombre       ║║    g.- Pais        ║";
            menu[5] = "║    b.- Mail         ║║    h.- Ciudad      ║";
            menu[6] = "║    c.- Teléfono     ║║    i.- Domicilio   ║";
            menu[7] = "║    d.- Fecha Nac.   ║║    j.- Facebook    ║";
            menu[8] = "║    e.- Twitter      ║║    k.- Instagram   ║";
            menu[9] = "║    f.- Apellido     ║║                    ║";
            menu[10] = "║                     ║║                    ║";
            menu[11] = "╠═════════════════════╩╩════════════════════╣";
            menu[12] = "║                       ┌───┐               ║";
            menu[13] = "║           Elección:   ┤   ├               ║";
            menu[14] = "║                       └───┘               ║";
            menu[15] = "╚═════════════════════◄►════════════════════╝";

            //LIMPIAMOS LA CONSOLA
            Console.Clear();

            //RECORREMOS LA CONSOLA PARA PODER ARMAR INTERFAZ GRÁFICA
            for (int t = 0; t < Console.BufferHeight; t++)
            {
                if (t >= Console.BufferHeight / 4 && t <= (Console.BufferHeight / 4 + 15))
                {
                    for (int j = 0; j < Console.BufferWidth; j++)
                    {
                        if (j >= ((Console.BufferWidth - menu[0].Length) / 2) && j < (((Console.BufferWidth - menu[0].Length) / 2) + menu[0].Length))
                        {
                            if (t == 13)
                            {
                                cursorLeftPosition = ((Console.BufferWidth - menu[t].Length) / 2) + 26;
                                cursorTopPosition = (Console.BufferHeight / 4) + t;
                            }
                            Console.Write("W");
                        }
                        else if (j <= (Console.BufferWidth - menu[0].Length) / 2 || j >= (((Console.BufferWidth - menu[0].Length) / 2) + menu[0].Length))
                        {
                            Console.Write("W");
                        }
                    }
                }
                else
                {
                    for (int j = 0; j < Console.BufferWidth; j++)
                    {
                        Console.Write("W");
                    }
                }
            }

            for (int i = 0; i < 16; i++)
            {
                Console.SetCursorPosition(((Console.BufferWidth - menu[i].Length) / 2), (Console.BufferHeight / 4) + i);
                Console.WriteLine(menu[i]);
            }

            //ESTABLECEMOS LA POSICIÓN DEL CURSOR EN EL CAMPO DE INGRESO
            Console.SetCursorPosition(cursorLeftPosition, cursorTopPosition);

        }
        public void ReadDNIStudentForUpdateMenu()
        {

            /*
            
            Se genera el menú de información de alumno
            
            */

            //ALMACENAMOS EL MENÚ EN UN ARREGLO
            string[] menu = new string[16];
            menu[0] = "╔═════════════════════◄►════════════════════╗";
            menu[1] = "║                 AGENDATOR                 ║";
            menu[2] = "╠═══════════════════════════════════════════╣";
            menu[3] = "║                                           ║";
            menu[4] = "║       Ingrese el DNI de la persona        ║";
            menu[5] = "║     que desea actualizar de su agenda     ║";
            menu[6] = "║                                           ║";
            menu[7] = "║                                           ║";
            menu[8] = "║                                           ║";
            menu[9] = "║                                           ║";
            menu[10] = "║                                           ║";
            menu[11] = "╠═══════════════════════════════════════════╣";
            menu[12] = "║           ┌────────────────────────────┐  ║";
            menu[13] = "║ Ingreso:  ┤                            ├  ║";
            menu[14] = "║           └────────────────────────────┘  ║";
            menu[15] = "╚═════════════════════◄►════════════════════╝";

            //LIMPIAMOS LA CONSOLA
            Console.Clear();

            //RECORREMOS LA CONSOLA PARA PODER ARMAR INTERFAZ GRÁFICA
            for (int t = 0; t < Console.BufferHeight; t++)
            {
                if (t >= Console.BufferHeight / 4 && t <= (Console.BufferHeight / 4 + 15))
                {
                    for (int j = 0; j < Console.BufferWidth; j++)
                    {
                        if (j >= ((Console.BufferWidth - menu[0].Length) / 2) && j < (((Console.BufferWidth - menu[0].Length) / 2) + menu[0].Length))
                        {
                            Console.Write("W");
                        }
                        else if (j <= (Console.BufferWidth - menu[0].Length) / 2 || j >= (((Console.BufferWidth - menu[0].Length) / 2) + menu[0].Length))
                        {
                            Console.Write("W");
                        }
                    }
                }
                else
                {
                    for (int j = 0; j < Console.BufferWidth; j++)
                    {
                        Console.Write("W");
                    }
                }
            }
            for (int i = 0; i < 16; i++)
            {
                Console.SetCursorPosition(((Console.BufferWidth - menu[i].Length) / 2), (Console.BufferHeight / 4) + i);
                Console.WriteLine(menu[i]);
            }

        }
        public void ReadDNIStudentForQueryMenu()
        {

            /*
            
            Se genera el menú de información de alumno
            
            */

            //ALMACENAMOS EL MENÚ EN UN ARREGLO
            string[] menu = new string[16];
            menu[0] = "╔═════════════════════◄►════════════════════╗";
            menu[1] = "║                 AGENDATOR                 ║";
            menu[2] = "╠═══════════════════════════════════════════╣";
            menu[3] = "║                                           ║";
            menu[4] = "║       Ingrese el DNI de la persona        ║";
            menu[5] = "║     que desea consultar en su agenda      ║";
            menu[6] = "║                                           ║";
            menu[7] = "║                                           ║";
            menu[8] = "║                                           ║";
            menu[9] = "║                                           ║";
            menu[10] = "║                                           ║";
            menu[11] = "╠═══════════════════════════════════════════╣";
            menu[12] = "║           ┌────────────────────────────┐  ║";
            menu[13] = "║ Ingreso:  ┤                            ├  ║";
            menu[14] = "║           └────────────────────────────┘  ║";
            menu[15] = "╚═════════════════════◄►════════════════════╝";

            //LIMPIAMOS LA CONSOLA
            Console.Clear();

            //RECORREMOS LA CONSOLA PARA PODER ARMAR INTERFAZ GRÁFICA
            for (int t = 0; t < Console.BufferHeight; t++)
            {
                if (t >= Console.BufferHeight / 4 && t <= (Console.BufferHeight / 4 + 15))
                {
                    for (int j = 0; j < Console.BufferWidth; j++)
                    {
                        if (j >= ((Console.BufferWidth - menu[0].Length) / 2) && j < (((Console.BufferWidth - menu[0].Length) / 2) + menu[0].Length))
                        {
                            Console.Write("W");
                        }
                        else if (j <= (Console.BufferWidth - menu[0].Length) / 2 || j >= (((Console.BufferWidth - menu[0].Length) / 2) + menu[0].Length))
                        {
                            Console.Write("W");
                        }
                    }
                }
                else
                {
                    for (int j = 0; j < Console.BufferWidth; j++)
                    {
                        Console.Write("W");
                    }
                }
            }
            for (int i = 0; i < 16; i++)
            {
                Console.SetCursorPosition(((Console.BufferWidth - menu[i].Length) / 2), (Console.BufferHeight / 4) + i);
                Console.WriteLine(menu[i]);
            }

        }

        public void updateMenu(string Attribute, string CurrentValue, Student student)
        {
            /*
            
            Se genera el menú de información de alumno
            
            */

            //VARIABLES PARA MANIPULAR CURSOR
            int cursorTopPosition = 0;
            int cursorLeftPosition = 0;
            int cursorTop = 0;
            int cursorLeft = 0;

            //ALMACENAMOS EL MENÚ EN UN ARREGLO
            string[] menu = new string[16];
            menu[0] = "╔═════════════════════◄►════════════════════╗";
            menu[1] = "║                 AGENDATOR                 ║";
            menu[2] = "╠═══════════════════════════════════════════╣";
            menu[3] = "║ Contacto:                                 ║";
            menu[4] = "║                                           ║";
            menu[5] = "║         Está a punto de modificar:        ║";
            menu[6] = "║                                           ║";
            menu[7] = "║                                           ║";
            menu[8] = "║ Actualmente es:                           ║";
            menu[9] = "║                                           ║";
            menu[10] = "║                                           ║";
            menu[11] = "╠═══════════════════════════════════════════╣";
            menu[12] = "║           ┌────────────────────────────┐  ║";
            menu[13] = "║ Ingreso:  ┤                            ├  ║";
            menu[14] = "║           └────────────────────────────┘  ║";
            menu[15] = "╚═════════════════════◄►════════════════════╝";

            //LIMPIAMOS LA CONSOLA
            Console.Clear();

            for (int t = 0; t < Console.BufferHeight; t++)
            {
                if (t >= Console.BufferHeight / 4 && t <= (Console.BufferHeight / 4 + 15))
                {
                    for (int j = 0; j < Console.BufferWidth; j++)
                    {
                        if (j >= ((Console.BufferWidth - menu[0].Length) / 2) && j < (((Console.BufferWidth - menu[0].Length) / 2) + menu[0].Length))
                        {
                            if (t == 13)
                            {
                                cursorLeftPosition = ((Console.BufferWidth - menu[t].Length) / 2) + 14;
                                cursorTopPosition = (Console.BufferHeight / 4) + t;
                            }
                            Console.Write("W");
                        }
                        else if (j <= (Console.BufferWidth - menu[0].Length) / 2 || j >= (((Console.BufferWidth - menu[0].Length) / 2) + menu[0].Length))
                        {
                            Console.Write("W");
                        }
                    }
                }
                else
                {
                    for (int j = 0; j < Console.BufferWidth; j++)
                    {
                        Console.Write("W");
                    }
                }
            }

            for (int i = 0; i < 16; i++)
            {
                Console.SetCursorPosition(((Console.BufferWidth - menu[i].Length) / 2), (Console.BufferHeight / 4) + i);
                Console.WriteLine(menu[i]);
            }

            for (int t = 0; t < Console.BufferHeight; t++)
            {

                if (t == 3)
                {
                    cursorLeft = ((Console.BufferWidth - menu[t].Length) / 2) + 13;
                    cursorTop = (Console.BufferHeight / 4) + t;
                    Console.SetCursorPosition(cursorLeft, cursorTop);
                    Console.WriteLine($"{student.lastName}, {student.firstName}");
                }
                else if (t == 6)
                {
                    cursorLeft = ((Console.BufferWidth - menu[t].Length) / 2) + 13;
                    cursorTop = (Console.BufferHeight / 4) + t;
                    Console.SetCursorPosition(cursorLeft, cursorTop);
                    Console.WriteLine($"{Attribute}");
                }
                else if (t == 8)
                {
                    cursorLeft = ((Console.BufferWidth - menu[t].Length) / 2) + 18;
                    cursorTop = (Console.BufferHeight / 4) + t;
                    Console.SetCursorPosition(cursorLeft, cursorTop);
                    Console.WriteLine($"{CurrentValue}");
                }
                
            }
            //ESTABLECEMOS LA POSICIÓN DEL CURSOR EN EL CAMPO DE INGRESO
            Console.SetCursorPosition(cursorLeftPosition, cursorTopPosition);

        }
        public void ListOfContactsMenu(List<Student> students)
        {
            /*
            
            Se genera el menú de información de alumno
            
            */

            //VARIABLES PARA MANIPULAR CURSOR
            int cursorTopPosition = 0;
            int cursorLeftPosition = 0;
            int cursorTop = 0;
            int cursorLeft = 0;

            //ALMACENAMOS EL MENÚ EN UN ARREGLO
            string[] menu = new string[16];
            menu[0] = "╔═════════════════════◄►════════════════════╗";
            menu[1] = "║                 AGENDATOR                 ║";
            menu[2] = "╠══════════╦════════════════════════════════╣";
            menu[3] = "║   DNI    ║           Nombre               ║";
            menu[4] = "╠══════════╬════════════════════════════════╣";
            menu[5] = "║          ║                                ║";
            menu[6] = "║          ║                                ║";
            menu[7] = "║          ║                                ║";
            menu[8] = "║          ║                                ║";
            menu[9] = "║          ║                                ║";
            menu[10] = "║          ║                                ║";
            menu[11] = "╠══════════╩════════════════════════════════╣";
            menu[12] = "║                                           ║";
            menu[13] = "║   Presione una tecla para continuar...    ║";
            menu[14] = "║                                           ║";
            menu[15] = "╚═════════════════════◄►════════════════════╝";

            

            
            int temp = 0;

            for (int s = 0; s < students.Count; s += 4) 
            {
                //LIMPIAMOS LA CONSOLA
                Console.Clear();

                for (int t = 0; t < Console.BufferHeight; t++)
                {
                    if (t >= Console.BufferHeight / 4 && t <= (Console.BufferHeight / 4 + 15))
                    {
                        for (int j = 0; j < Console.BufferWidth; j++)
                        {
                            if (j >= ((Console.BufferWidth - menu[0].Length) / 2) && j < (((Console.BufferWidth - menu[0].Length) / 2) + menu[0].Length))
                            {
                                if (t == 13)
                                {
                                    cursorLeftPosition = ((Console.BufferWidth - menu[t].Length) / 2) + 39;
                                    cursorTopPosition = (Console.BufferHeight / 4) + t;
                                }
                                Console.Write("W");
                            }
                            else if (j <= (Console.BufferWidth - menu[0].Length) / 2 || j >= (((Console.BufferWidth - menu[0].Length) / 2) + menu[0].Length))
                            {
                                Console.Write("W");
                            }
                        }
                    }
                    else
                    {
                        for (int j = 0; j < Console.BufferWidth; j++)
                        {
                            Console.Write("W");
                        }
                    }
                }

                for (int i = 0; i < 16; i++)
                {
                    Console.SetCursorPosition(((Console.BufferWidth - menu[i].Length) / 2), (Console.BufferHeight / 4) + i);
                    Console.WriteLine(menu[i]);
                }

                for (int t = 0; t < Console.BufferHeight; t++)
                {

                    for (int i = temp; i < students.Count; i++)
                    {
                        if (t == 5)
                        {
                            if (students.Count < 4 && students.Count > 0)
                            {
                                for (int cantStudents = 0; cantStudents < students.Count; cantStudents++)
                                {
                                    cursorLeft = ((Console.BufferWidth - menu[t].Length) / 2) + 2;
                                    cursorTop = (Console.BufferHeight / 4) + t;
                                    Console.SetCursorPosition(cursorLeft, cursorTop);
                                    Console.WriteLine($"{students[i].id}");
                                    cursorLeft = cursorLeft + 12;
                                    Console.SetCursorPosition(cursorLeft, cursorTop);
                                    Console.WriteLine($"{students[i].lastName}, {students[i].firstName}");
                                    i++;
                                    t++;
                                    temp = i;
                                }
                            }
                            else
                            {
                                for (int cantStudents = 0; cantStudents < 4; cantStudents++)
                                {
                                    cursorLeft = ((Console.BufferWidth - menu[t].Length) / 2) + 2;
                                    cursorTop = (Console.BufferHeight / 4) + t;
                                    Console.SetCursorPosition(cursorLeft, cursorTop);
                                    if (i < students.Count)
                                    {
                                        Console.WriteLine($"{students[i].id}");
                                        cursorLeft = cursorLeft + 12;
                                        Console.SetCursorPosition(cursorLeft, cursorTop);
                                        Console.WriteLine($"{students[i].lastName}, {students[i].firstName}");
                                    }
                                    i++;
                                    t++;
                                    temp = i;
                                }

                            }
                        }
                    }
                }
                Console.SetCursorPosition(cursorLeftPosition, cursorTopPosition);
                Console.ReadKey();
            }
            //ESTABLECEMOS LA POSICIÓN DEL CURSOR EN EL CAMPO DE INGRESO
            Console.SetCursorPosition(cursorLeftPosition, cursorTopPosition);
            
        }

        public void StudentUpdated(Student student)
        {
            /*
            
            Se genera alerta de error en ingreso.
            
            */

            //VARIABLES PARA MANIPULAR CURSOR
            int cursorTop = 0;
            int cursorLeft = 0;

            //ALMACENAMOS EL MENÚ EN UN ARREGLO
            string[] menu = new string[16];
            menu[0] = "╔═════════════════════◄►════════════════════╗";
            menu[1] = "║                 AGENDATOR                 ║";
            menu[2] = "╠═══════════════════════════════════════════╣";
            menu[3] = "║                                           ║";
            menu[4] = "║          ¡Eliminación Exitosa!            ║";
            menu[5] = "║                                           ║";
            menu[6] = "║                                           ║";
            menu[7] = "║    Se actualizó la información para:      ║";
            menu[8] = "║                                           ║";
            menu[9] = "║                                           ║";
            menu[10] = "║                                           ║";
            menu[11] = "╠═══════════════════════════════════════════╣";
            menu[12] = "║                                           ║";
            menu[13] = "║   Presione una tecla para continuar...    ║";
            menu[14] = "║                                           ║";
            menu[15] = "╚═════════════════════◄►════════════════════╝";

            //LIMPIAMOS LA CONSOLA
            Console.Clear();

            for (int t = 0; t < Console.BufferHeight; t++)
            {
                if (t >= Console.BufferHeight / 4 && t <= (Console.BufferHeight / 4 + 15))
                {
                    for (int j = 0; j < Console.BufferWidth; j++)
                    {
                        if (j >= ((Console.BufferWidth - menu[0].Length) / 2) && j < (((Console.BufferWidth - menu[0].Length) / 2) + menu[0].Length))
                        {
                            Console.Write("W");
                        }
                        else if (j <= (Console.BufferWidth - menu[0].Length) / 2 || j >= (((Console.BufferWidth - menu[0].Length) / 2) + menu[0].Length))
                        {
                            Console.Write("W");
                        }
                    }
                }
                else
                {
                    for (int j = 0; j < Console.BufferWidth; j++)
                    {
                        Console.Write("W");
                    }
                }
            }

            for (int i = 0; i < 16; i++)
            {
                Console.SetCursorPosition(((Console.BufferWidth - menu[i].Length) / 2), (Console.BufferHeight / 4) + i);
                Console.WriteLine(menu[i]);
            }

            for (int t = 0; t < Console.BufferHeight; t++)
            {

                if (t == 9)
                {
                    cursorLeft = ((Console.BufferWidth - menu[t].Length) / 2) + 5;
                    cursorTop = (Console.BufferHeight / 4) + t;
                }

            }
            Console.SetCursorPosition(cursorLeft, cursorTop);
            Console.WriteLine($"{student.lastName}, {student.firstName}");
            Console.ReadKey();
        }
    }

    
    
}
