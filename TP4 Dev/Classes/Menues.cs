using System;
using System.Collections.Generic;
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
            string[] menu = new string[14];
            menu[0] = "╔═══════════◄►══════════╗";
            menu[1] = "║       AGENDATOR       ║";
            menu[2] = "╠═══════════════════════╣";
            menu[3] = "║ 1.- Agregar Alumno    ║";
            menu[4] = "║ 2.- Eliminar Alumno   ║";
            menu[5] = "║ 3.- Modificar Alumno  ║";
            menu[6] = "║ 4.- Consultar Alumno  ║";
            menu[7] = "║ 5.- Listar Alumnos    ║";
            menu[8] = "║ 6.- Salir             ║";
            menu[9] = "╠═══════════════════════╣";
            menu[10] = "║             ┌───┐     ║";
            menu[11] = "║ Elección:   ┤   ├     ║";
            menu[12] = "║             └───┘     ║";
            menu[13] = "╚═══════════◄►══════════╝";

            //LIMPIAMOS LA CONSOLA
            Console.Clear();

            for (int t = 0; t < Console.BufferHeight; t++)
            {
                if (t >= Console.BufferHeight / 4 && t <= (Console.BufferHeight / 4 + 13))
                {
                    for (int j = 0; j < Console.BufferWidth; j++)
                    {
                        if (j >= ((Console.BufferWidth - menu[0].Length) / 2) && j < (((Console.BufferWidth - menu[0].Length) / 2) + menu[0].Length))
                        {
                            if (t == 11)
                            {
                                cursorLeftPosition = ((Console.BufferWidth - menu[t].Length) / 2) + 16;
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
            for (int i = 0; i < 14; i++)
            {
                Console.SetCursorPosition(((Console.BufferWidth - menu[i].Length) / 2), (Console.BufferHeight / 4) + i);
                Console.WriteLine(menu[i]);
            }

            //ESTABLECEMOS LA POSICIÓN DEL CURSOR EN EL CAMPO DE INGRESO
            Console.SetCursorPosition(cursorLeftPosition, cursorTopPosition);

            Console.ReadKey();

        }

    }
}
