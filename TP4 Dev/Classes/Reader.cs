using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace TP4_Dev.Classes
{
    /// <summary>
    /// EN LA PRESENTE CLASE "Reader" REALIZAMOS TODAS LAS LECTUAS DE INGRESO POR TECLADO Y SE ENVÍAN A VALIDACIÓN.
    /// </summary>
    internal class Reader
    {
        Validator validator = new Validator();
        public int ReadOption(char minValue, char maxValue)
        {
            Validator validator = new Validator();
            char option = '0';
            option = Console.ReadKey().KeyChar;
            if (validator.ValidateOptions(option, minValue, maxValue))
            {
                return int.Parse(option.ToString());
            }
            else {  return 0;  }
            
        }
        public char ReadOptionForUpdate()
        {
            Validator validator = new Validator();
            char option = '0';
            option = Console.ReadKey().KeyChar;
            if (validator.ValidateOptionsForUpdate(option))
            {
                return option;
            }
            else { return '0'; }

        }
        public int ReadDNI()
        {
            Presenter presenter = new Presenter();
            Validator validator = new Validator();
            string DNI = "0";

            string[] menu = presenter.Menu();
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
                }
            } return 0;
        }
        public string ReadName()
        {
            Presenter presenter = new Presenter();
            Validator validator = new Validator();
            string Name = "0";

            string[] menu = presenter.Menu();
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
            Presenter presenter = new Presenter();
            Validator validator = new Validator();
            string lastName = "0";

            string[] menu = presenter.Menu();
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
            Presenter presenter = new Presenter();
            Validator validator = new Validator();
            string[] menu = presenter.Menu();
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
        public long ReadPhone()
        {
            Presenter presenter = new Presenter();
            Validator validator = new Validator();
            string[] menu = presenter.Menu();
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
                    if (validator.ValidateInteger(phone, 8, 15))
                    {
                        return long.Parse(phone);
                    }
                }
            }
            return 0;
        }
        public string ReadBornDate()
        {
            Presenter presenter = new Presenter();
            Validator validator = new Validator();
            string[] menu = presenter.Menu();
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
                }
            }
            return "0";
        }
        public string ReadCountry()
        {
            Presenter presenter = new Presenter();
            Validator validator = new Validator();
            string[] menu = presenter.Menu();
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
                }

            }
            return "0";
        }
        public string ReadCity()
        {
            Presenter presenter = new Presenter();
            Validator validator = new Validator();
            string[] menu = presenter.Menu();
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
                }

            }
            return "0";
        }
        public string ReadFacebook()
        {
            Presenter presenter = new Presenter();
            Validator validator = new Validator();
            string[] menu = presenter.Menu();
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
                }

            }
            return "0";
        }
        public string ReadTwitter()
        {
            Presenter presenter = new Presenter();
            Validator validator = new Validator();
            string[] menu = presenter.Menu();
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
                }

            }
            return "0";
        }
        public string ReadInstagram()
        {
            Presenter presenter = new Presenter();
            Validator validator = new Validator();
            string[] menu = presenter.Menu();
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
                }

            }
            return "0";
        }
        public string ReadStreet()
        {
            Presenter presenter = new Presenter();
            Validator validator = new Validator();
            string[] menu = presenter.Menu();
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
                    if (validator.ValidateAddress(street))
                    {
                        return street;
                    }
                }
            }
            return "0";
        }
        public int ReadAge(string born)
        {
            DateTime currentDate = DateTime.Now;
            DateTime bornDate = DateTime.ParseExact(born, "dd/MM/yyyy", null);
            int age = currentDate.Year - bornDate.Year;
            
            if (currentDate.Month < bornDate.Month || (currentDate.Month == bornDate.Month && currentDate.Day < bornDate.Day))
            {
                age --;
            }
            return age;

        }
        public char ReadYesOrNot()
        {
            char option = Console.ReadKey().KeyChar;
            if (validator.validateSORN(option) == true)
            {
                return option;
            }
            return '0';
        }
        public string ReadNewValue(char attribute)
        {
            switch (attribute)
            {
                case 'j': return(ReadFacebook());
                case 'a': return(ReadName());
                case 'f': return(ReadLastName());
                case 'b': return(ReadMail());
                case 'g': return(ReadCountry());
                case 'c': return(ReadPhone().ToString());
                case 'h': return(ReadCity());
                case 'd': return(ReadBornDate());
                case 'i': return(ReadStreet());
                case 'e': return(ReadTwitter());
                case 'k': return(ReadInstagram());
                case 'J': return(ReadFacebook());   
                case 'A': return(ReadName());
                case 'F': return(ReadLastName());
                case 'B': return(ReadMail());
                case 'G': return(ReadCountry());
                case 'C': return(ReadPhone().ToString());       
                case 'H': return(ReadCity());
                case 'D': return(ReadBornDate());
                case 'I': return(ReadStreet());
                case 'E': return(ReadTwitter());
                case 'K': return(ReadInstagram());
                case 'l': return(ReadDNI().ToString());
                default:
                    return "0";
            }

        }
        
    }
}
