using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4_Dev.Classes
{
    public class Menues
    {
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
                                cursorLeftPosition = ((Console.BufferWidth - menu[t].Length) / 2) + 26 ;
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

            Console.ReadKey();

        }

        public void StudentInfoMenu(Student student)
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
            menu[12] = "║                       ┌───┐               ║";
            menu[13] = "║          6.- Salir:   ┤   ├               ║";
            menu[14] = "║                       └───┘               ║";
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

            for (int t = 0; t < Console.BufferHeight; t++)
            {

                if (t == 3)
                {
                    cursorLeft = ((Console.BufferWidth - menu[t].Length) / 2) + 15;
                    cursorTop = (Console.BufferHeight / 4) + t;
                    Console.SetCursorPosition(cursorLeft, cursorTop);
                    Console.WriteLine($"{student.lastName}, {student.firstName}");
                }
                else if (t == 4)
                {
                    cursorLeft = ((Console.BufferWidth - menu[t].Length) / 2) + 15;
                    cursorTop = (Console.BufferHeight / 4) + t;
                    Console.SetCursorPosition(cursorLeft, cursorTop);
                    Console.WriteLine($"{student.mail}");
                }
                else if (t == 5)
                {
                    cursorLeft = ((Console.BufferWidth - menu[t].Length) / 2) + 15;
                    cursorTop = (Console.BufferHeight / 4) + t;
                    Console.SetCursorPosition(cursorLeft, cursorTop);
                    Console.WriteLine($"{student.phone}");
                }
                else if (t == 6)
                {
                    cursorLeft = ((Console.BufferWidth - menu[t].Length) / 2) + 15;
                    cursorTop = (Console.BufferHeight / 4) + t;
                    Console.SetCursorPosition(cursorLeft, cursorTop);
                    Console.WriteLine($"{student.bornDate}");
                }
                else if (t == 7)
                {
                    cursorLeft = ((Console.BufferWidth - menu[t].Length) / 2) + 15;
                    cursorTop = (Console.BufferHeight / 4) + t;
                    Console.SetCursorPosition(cursorLeft, cursorTop);
                    Console.WriteLine($"{student.street}, {student.city}");
                }
                else if (t == 8)
                {
                    cursorLeft = ((Console.BufferWidth - menu[t].Length) / 2) + 15;
                    cursorTop = (Console.BufferHeight / 4) + t;
                    Console.SetCursorPosition(cursorLeft, cursorTop);
                    Console.WriteLine($"{student.twitterID}");
                }
                else if (t == 9)
                {
                    cursorLeft = ((Console.BufferWidth - menu[t].Length) / 2) + 15;
                    cursorTop = (Console.BufferHeight / 4) + t;
                    Console.SetCursorPosition(cursorLeft, cursorTop);
                    Console.WriteLine($"{student.facebookID}");
                }
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
            menu[12] = "║                                 ┌────┐    ║";
            menu[13] = "║ Presione una tecla para salir:  ┤    ├    ║";
            menu[14] = "║                                 └────┘    ║";
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

                if (t == 13)
                {
                    cursorLeft = ((Console.BufferWidth - menu[t].Length) / 2) + 36;
                    cursorTop = (Console.BufferHeight / 4) + t;
                }

            }
            //ESTABLECEMOS LA POSICIÓN DEL CURSOR EN EL CAMPO DE INGRESO
            Console.SetCursorPosition(cursorLeft, cursorTop);
            Console.ReadKey();
            
        }
        public int AddDNIMenu()
        {
            Validator validator = new Validator();
            string DNI = "0";
            /*
            
            Se genera el menú de información de alumno
            
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
                    cursorLeft = ((Console.BufferWidth - menu[t].Length) / 2) + 14;
                    cursorTop = (Console.BufferHeight / 4) + t;
                    Console.SetCursorPosition(cursorLeft, cursorTop);
                    DNI = Console.ReadLine();
                    //VALIDAMOS EL NUMERO, PASANDO COMO PARAMETROS EL INGRESO Y LA LONGITUD MÁXIMA Y MÍNIMA
                    if (validator.ValidateInteger(DNI, 8, 8))
                    {
                        return int.Parse(DNI);
                    }
                    else { Console.WriteLine("Error de ingreso"); }
                }
                
            }
            //ESTABLECEMOS LA POSICIÓN DEL CURSOR EN EL CAMPO DE INGRESO
            Console.SetCursorPosition(cursorLeft, cursorTop);

            validator = null;
            Console.ReadKey();
            return 0;
        }
        public string AddNameMenu()
        {
            Validator validator = new Validator();
            string Name = "0";
            /*
            
            Se genera el menú de información de alumno
            
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
                    cursorLeft = ((Console.BufferWidth - menu[t].Length) / 2) + 14;
                    cursorTop = (Console.BufferHeight / 4) + t;
                    Console.SetCursorPosition(cursorLeft, cursorTop);
                    Name = Console.ReadLine();
                    //VALIDAMOS EL STRING, PASANDO COMO PARAMETROS EL INGRESO Y LA LONGITUD MÁXIMA Y MÍNIMA
                    if (validator.ValidateString(Name, 2, 30))
                    {
                        return Name;
                    }
                    else { Console.WriteLine("Error de ingreso"); }
                }

            }
            //ESTABLECEMOS LA POSICIÓN DEL CURSOR EN EL CAMPO DE INGRESO
            Console.SetCursorPosition(cursorLeft, cursorTop);

            validator = null;
            Console.ReadKey();
            return "0";
        }
        public string AddLastNameMenu()
        {
            Validator validator = new Validator();
            string lastName = "0";
            /*
            
            Se genera el menú de información de alumno
            
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

            for (int t = 0; t < Console.BufferHeight; t++)
            {

                if (t == 13)
                {
                    cursorLeft = ((Console.BufferWidth - menu[t].Length) / 2) + 14;
                    cursorTop = (Console.BufferHeight / 4) + t;
                    Console.SetCursorPosition(cursorLeft, cursorTop);
                    lastName = Console.ReadLine();
                    //VALIDAMOS EL STRING, PASANDO COMO PARAMETROS EL INGRESO Y LA LONGITUD MÁXIMA Y MÍNIMA
                    if (validator.ValidateString(lastName, 2, 30))
                    {
                        return lastName;
                    }
                    else { Console.WriteLine("Error de ingreso"); }
                }

            }
            //ESTABLECEMOS LA POSICIÓN DEL CURSOR EN EL CAMPO DE INGRESO
            Console.SetCursorPosition(cursorLeft, cursorTop);

            validator = null;
            Console.ReadKey();
            return "0";
        }
        public string AddMailMenu()
        {
            Validator validator = new Validator();
            string mail = "0";
            /*
            
            Se genera el menú de información de alumno
            
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
                    cursorLeft = ((Console.BufferWidth - menu[t].Length) / 2) + 14;
                    cursorTop = (Console.BufferHeight / 4) + t;
                    Console.SetCursorPosition(cursorLeft, cursorTop);
                    mail = Console.ReadLine();
                    //VALIDAMOS EL STRING, PASANDO COMO PARAMETROS EL INGRESO Y LA LONGITUD MÁXIMA Y MÍNIMA
                    if (validator.ValidateMail(mail))
                    {
                        return mail;
                    }
                    else { Console.WriteLine("Error de ingreso"); }
                }

            }
            //ESTABLECEMOS LA POSICIÓN DEL CURSOR EN EL CAMPO DE INGRESO
            Console.SetCursorPosition(cursorLeft, cursorTop);

            validator = null;
            Console.ReadKey();
            return "0";
        }
        public int AddPhoneMenu()
        {
            Validator validator = new Validator();
            string phone = "0";
            /*
            
            Se genera el menú de información de alumno
            
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
                    cursorLeft = ((Console.BufferWidth - menu[t].Length) / 2) + 14;
                    cursorTop = (Console.BufferHeight / 4) + t;
                    Console.SetCursorPosition(cursorLeft, cursorTop);
                    phone = Console.ReadLine();
                    //VALIDAMOS EL NUMERO
                    if (validator.ValidateInteger(phone, 9, 15))
                    {
                        return int.Parse(phone);
                    }
                    else { Console.WriteLine("Error de ingreso"); }
                }

            }
            //ESTABLECEMOS LA POSICIÓN DEL CURSOR EN EL CAMPO DE INGRESO
            Console.SetCursorPosition(cursorLeft, cursorTop);

            validator = null;
            Console.ReadKey();
            return 0;
        }
        public string AddBornDateMenu()
        {
            Validator validator = new Validator();
            string date = "";
            /*
            
            Se genera el menú de información de alumno
            
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
                    cursorLeft = ((Console.BufferWidth - menu[t].Length) / 2) + 14;
                    cursorTop = (Console.BufferHeight / 4) + t;
                    Console.SetCursorPosition(cursorLeft, cursorTop);
                    for(int i = 0; i < 8; i++)
                    {
                        ConsoleKeyInfo keyInfo = Console.ReadKey();
                        char keyChar = keyInfo.KeyChar;
                        date = date + keyChar.ToString();
                        if (i == 1)
                        {
                            Console.SetCursorPosition(cursorLeft+3, cursorTop);
                            date = date + "/";
                        }
                        else if (i == 3)
                        {
                            Console.SetCursorPosition(cursorLeft + 6, cursorTop);
                            date = date + "/";
                        }
                    }
                    //Validamos la fecha
                    if (validator.ValidateDate(date))
                    {
                        return date;
                    }
                    else { Console.WriteLine($"Error de ingreso"); }
                }


            }
            //ESTABLECEMOS LA POSICIÓN DEL CURSOR EN EL CAMPO DE INGRESO
            Console.SetCursorPosition(cursorLeft, cursorTop);

            validator = null;
            Console.ReadKey();
            return date;
        }
        public string AddFacebookIDMenu()
        {
            Validator validator = new Validator();
            string id = "0";
            /*
            
            Se genera el menú de información de alumno
            
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
                    cursorLeft = ((Console.BufferWidth - menu[t].Length) / 2) + 14;
                    cursorTop = (Console.BufferHeight / 4) + t;
                    Console.SetCursorPosition(cursorLeft, cursorTop);
                    id = Console.ReadLine();
                    //VALIDAMOS EL STRING, PASANDO COMO PARAMETROS EL INGRESO Y LA LONGITUD MÁXIMA Y MÍNIMA
                    if (validator.ValidateString(id, 2, 30))
                    {
                        return id;
                    }
                    else { Console.WriteLine("Error de ingreso"); }
                }

            }
            //ESTABLECEMOS LA POSICIÓN DEL CURSOR EN EL CAMPO DE INGRESO
            Console.SetCursorPosition(cursorLeft, cursorTop);

            validator = null;
            Console.ReadKey();
            return "0";
        }
        public string AddTwitterIDMenu()
        {
            Validator validator = new Validator();
            string id = "0";
            /*
            
            Se genera el menú de información de alumno
            
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
                    cursorLeft = ((Console.BufferWidth - menu[t].Length) / 2) + 14;
                    cursorTop = (Console.BufferHeight / 4) + t;
                    Console.SetCursorPosition(cursorLeft, cursorTop);
                    id = Console.ReadLine();
                    //VALIDAMOS EL STRING, PASANDO COMO PARAMETROS EL INGRESO Y LA LONGITUD MÁXIMA Y MÍNIMA
                    if (validator.ValidateString(id, 2, 30))
                    {
                        return id;
                    }
                    else { Console.WriteLine("Error de ingreso"); }
                }

            }
            //ESTABLECEMOS LA POSICIÓN DEL CURSOR EN EL CAMPO DE INGRESO
            Console.SetCursorPosition(cursorLeft, cursorTop);

            validator = null;
            Console.ReadKey();
            return "0";
        }
        public string AddInstagramIDMenu()
        {
            Validator validator = new Validator();
            string id = "0";
            /*
            
            Se genera el menú de información de alumno
            
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
                    cursorLeft = ((Console.BufferWidth - menu[t].Length) / 2) + 14;
                    cursorTop = (Console.BufferHeight / 4) + t;
                    Console.SetCursorPosition(cursorLeft, cursorTop);
                    id = Console.ReadLine();
                    //VALIDAMOS EL STRING, PASANDO COMO PARAMETROS EL INGRESO Y LA LONGITUD MÁXIMA Y MÍNIMA
                    if (validator.ValidateString(id, 2, 30))
                    {
                        return id;
                    }
                    else { Console.WriteLine("Error de ingreso"); }
                }

            }
            //ESTABLECEMOS LA POSICIÓN DEL CURSOR EN EL CAMPO DE INGRESO
            Console.SetCursorPosition(cursorLeft, cursorTop);

            validator = null;
            Console.ReadKey();
            return "0";
        }
        public string AddCountryMenu()
        {
            Validator validator = new Validator();
            string country = "0";
            /*
            
            Se genera el menú de información de alumno
            
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
                    cursorLeft = ((Console.BufferWidth - menu[t].Length) / 2) + 14;
                    cursorTop = (Console.BufferHeight / 4) + t;
                    Console.SetCursorPosition(cursorLeft, cursorTop);
                    country = Console.ReadLine();
                    //VALIDAMOS EL STRING, PASANDO COMO PARAMETROS EL INGRESO Y LA LONGITUD MÁXIMA Y MÍNIMA
                    if (validator.ValidateString(country, 4, 30))
                    {
                        return country;
                    }
                    else { Console.WriteLine("Error de ingreso"); }
                }

            }
            //ESTABLECEMOS LA POSICIÓN DEL CURSOR EN EL CAMPO DE INGRESO
            Console.SetCursorPosition(cursorLeft, cursorTop);

            validator = null;
            Console.ReadKey();
            return "0";
        }
        public string AddCityMenu()
        {
            Validator validator = new Validator();
            string city = "0";
            /*
            
            Se genera el menú de información de alumno
            
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
                    cursorLeft = ((Console.BufferWidth - menu[t].Length) / 2) + 14;
                    cursorTop = (Console.BufferHeight / 4) + t;
                    Console.SetCursorPosition(cursorLeft, cursorTop);
                    city = Console.ReadLine();
                    //VALIDAMOS EL STRING, PASANDO COMO PARAMETROS EL INGRESO Y LA LONGITUD MÁXIMA Y MÍNIMA
                    if (validator.ValidateString(city, 4, 30))
                    {
                        return city;
                    }
                    else { Console.WriteLine("Error de ingreso"); }
                }

            }
            //ESTABLECEMOS LA POSICIÓN DEL CURSOR EN EL CAMPO DE INGRESO
            Console.SetCursorPosition(cursorLeft, cursorTop);

            validator = null;
            Console.ReadKey();
            return "0";
        }
        public string AddStreetMenu()
        {
            Validator validator = new Validator();
            string street = "0";
            /*
            
            Se genera el menú de información de alumno
            
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

            for (int t = 0; t < Console.BufferHeight; t++)
            {

                if (t == 13)
                {
                    cursorLeft = ((Console.BufferWidth - menu[t].Length) / 2) + 14;
                    cursorTop = (Console.BufferHeight / 4) + t;
                    Console.SetCursorPosition(cursorLeft, cursorTop);
                    street = Console.ReadLine();
                    //VALIDAMOS EL STRING, PASANDO COMO PARAMETROS EL INGRESO Y LA LONGITUD MÁXIMA Y MÍNIMA
                    if (validator.ValidateString(street, 4, 30))
                    {
                        return street;
                    }
                    else { Console.WriteLine("Error de ingreso"); }
                }

            }
            //ESTABLECEMOS LA POSICIÓN DEL CURSOR EN EL CAMPO DE INGRESO
            Console.SetCursorPosition(cursorLeft, cursorTop);

            validator = null;
            Console.ReadKey();
            return "0";
        }


    }
}
