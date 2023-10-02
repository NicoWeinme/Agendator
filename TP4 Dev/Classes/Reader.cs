using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4_Dev.Classes
{
    public class Reader
    {
        Validator validator = new Validator();
        public int ReadDNI()
        {
            Menues menues = new Menues();
            Validator validator = new Validator();
            string DNI = "0";

            string[] menu = menues.Menu();
            //VARIABLES PARA MANIPULAR CURSOR
            int cursorTop = 0;
            int cursorLeft = 0;

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
                    else 
                    {
                        Console.WriteLine("Error de ingreso");
                        return 0;
                    }
                }

            } return 0;
        }
        public string ReadName()
        {
            Menues menues = new Menues();
            Validator validator = new Validator();
            string Name = "0";

            string[] menu = menues.Menu();
            //VARIABLES PARA MANIPULAR CURSOR
            int cursorTop = 0;
            int cursorLeft = 0;


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
            return "0";
        }
        public string ReadLastName()
        {
            Menues menues = new Menues();
            Validator validator = new Validator();
            string lastName = "0";

            string[] menu = menues.Menu();
            //VARIABLES PARA MANIPULAR CURSOR
            int cursorTop = 0;
            int cursorLeft = 0;

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
            return "0";
        }
        public string ReadMail() 
        {
            Menues menues = new Menues();
            Validator validator = new Validator();
            string[] menu = menues.Menu();
            //VARIABLES PARA MANIPULAR CURSOR
            int cursorTop = 0;
            int cursorLeft = 0;
            string mail = "0";

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
            return "0";
        }
        public int ReadPhone() 
        {
            Menues menues = new Menues();
            Validator validator = new Validator();
            string[] menu = menues.Menu();
            //VARIABLES PARA MANIPULAR CURSOR
            int cursorTop = 0;
            int cursorLeft = 0;
            string phone = "0";

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
            return 0;
        }
        public string ReadBornDate()
        {
            Menues menues = new Menues();
            Validator validator = new Validator();
            string[] menu = menues.Menu();
            //VARIABLES PARA MANIPULAR CURSOR
            int cursorTop = 0;
            int cursorLeft = 0;
            string date = "";

            for (int t = 0; t < Console.BufferHeight; t++)
            {


                if (t == 13)
                {
                    cursorLeft = ((Console.BufferWidth - menu[t].Length) / 2) + 14;
                    cursorTop = (Console.BufferHeight / 4) + t;
                    Console.SetCursorPosition(cursorLeft, cursorTop);
                    for (int i = 0; i < 8; i++)
                    {
                        ConsoleKeyInfo keyInfo = Console.ReadKey();
                        char keyChar = keyInfo.KeyChar;
                        date = date + keyChar.ToString();
                        if (i == 1)
                        {
                            Console.SetCursorPosition(cursorLeft + 3, cursorTop);
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
            return "0";
        }
        public string ReadCountry() 
        {
            Menues menues = new Menues();
            Validator validator = new Validator();
            string[] menu = menues.Menu();
            //VARIABLES PARA MANIPULAR CURSOR
            int cursorTop = 0;
            int cursorLeft = 0;
            string country = "0";

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
            return "0";
        }
        public string ReadCity() 
        {
            Menues menues = new Menues();
            Validator validator = new Validator();
            string[] menu = menues.Menu();
            //VARIABLES PARA MANIPULAR CURSOR
            int cursorTop = 0;
            int cursorLeft = 0;
            string city = "0";

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
            return "0";
        }
        public string ReadFacebook() 
        {
            Menues menues = new Menues();
            Validator validator = new Validator();
            string[] menu = menues.Menu();
            //VARIABLES PARA MANIPULAR CURSOR
            int cursorTop = 0;
            int cursorLeft = 0;
            string id = "0";

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
            return "0";
        }
        public string ReadTwitter()
        {
            Menues menues = new Menues();
            Validator validator = new Validator();
            string[] menu = menues.Menu();
            //VARIABLES PARA MANIPULAR CURSOR
            int cursorTop = 0;
            int cursorLeft = 0;
            string id = "0";

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
            return "0";
        }
        public string ReadInstagram() 
        {
            Menues menues = new Menues();
            Validator validator = new Validator();
            string[] menu = menues.Menu();
            //VARIABLES PARA MANIPULAR CURSOR
            int cursorTop = 0;
            int cursorLeft = 0;
            string id = "0";

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
            return "0";
        }
        public string ReadStreet()
        {
            Menues menues = new Menues();
            Validator validator = new Validator();
            string[] menu = menues.Menu();
            //VARIABLES PARA MANIPULAR CURSOR
            int cursorTop = 0;
            int cursorLeft = 0;
            string street = "0";

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
            return "0";
        }
        //public int ReadOption()
        //{
        //    return validator.ValidateSelectedOption();
        //}
    }
}
