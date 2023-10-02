using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TP4_Dev.Classes
{
    public class Validator
    {
        //VALIDADOR DE CADENAS, RECIBE COMO PARAMETRO LA CADENA Y SU LONGITUD
        public bool ValidateString(string Input, int lengthMin, int lenghtMax)
        {
            //En este método evaluamos que la cadena no contenga símbolos ni espacios en blanco
            //Y también que cumpla con las longitudes establecidas
            bool valid = false;
            Regex regex = new Regex("^[a-zA-Z]+$");            
            if (!string.IsNullOrWhiteSpace(Input) && (Input.Length >= lengthMin && Input.Length <= lenghtMax) && regex.IsMatch(Input))
            {
                valid = true;
            }
            return valid;
        }
        //VALIDADOR DE ENTEROS
        public bool ValidateInteger(string Input, int lengthMin, int lengthMax)
        {
            //Aquí validamos que sea un entero lo ingresado
            //Y que cumpla con la longitud establecida
            if (!string.IsNullOrWhiteSpace(Input) && (Input.Length >= lengthMin && Input.Length <= lengthMax))
            {
                try
                {
                    int convert = int.Parse(Input);
                    return true;
                }
                catch
                {
                    return false;
                }
            }else { return false; }
            
        }
        //VALIDADOR DE CARACTERES
        public bool ValidateChar(char Input)
        {
            return false;
        }

        public bool ValidatePath()
        {
            //Validamos la existencia del directorio
            Path path = new Path();
            bool exists = System.IO.File.Exists(path.fileName);
            return exists;
            path = null;
        }
        public bool ValidatePersonExists(List<Student> students, Student newStudent)
        {
            //Validamos si ya existe el alumno en BD.
            bool exists = false;
            foreach (Student student in students)
            {
                if (student.id == newStudent.id)
                {
                    exists = true;
                }
            }
            return exists;
        }
        public bool ValidateStudentExists(List<Student> students, Student newStudent)
        {
            //Validamos si ya existe el alumno en BD.
            bool exists = false;
            foreach (Student student in students)
            {
                if (student.id == newStudent.id)
                {
                    exists = true;
                }
            }
            return exists;
        }

        public bool ValidateOptions()
        {
            //Validamos la opción ingresada
            bool validOption = true;
            int option = 6;
            while (validOption)
            {
                var input = Console.ReadKey();
                char inputValue = input.KeyChar;
                switch (inputValue)
                {
                    case '1': option = 1; validOption = false; break;
                    case '2': option = 2; validOption = false; break;
                    case '3': option = 3; validOption = false; break;
                    case '4': option = 4; validOption = false; break;
                    case '5': option = 5; validOption = false; break;
                    case '6': option = 6; validOption = false; break;
                    default:
                        Console.WriteLine("El valor ingresado es incorrecto, vuelva a intentar");
                        break;
                }
            }
            return validOption;
        }
        public void ValidateSelectedOption()
        {
            bool validOption = true;
            while (validOption)
            {
                
            }
        }

        public bool ValidateMail(string Input)
        {
            Regex regex = new Regex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
            if (regex.IsMatch(Input))
            {
                return true;
            }
            return false;
        }
        public bool ValidateDate(string Input)
        {
            Regex regex = new Regex(@"^(0[1-9]|1[0-9]|2[0-9]|3[0-1])/(0[1-9]|1[0-2])/(19|20)\d\d$");
            if (regex.IsMatch(Input))
            {
                if (int.Parse(Input.Substring(6)) >= 1900 && int.Parse(Input.Substring(6)) < DateTime.Now.Year)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
