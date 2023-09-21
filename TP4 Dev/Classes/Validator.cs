using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4_Dev.Classes
{
    public class Validator
    {
        //VALIDADOR DE CADENAS, RECIBE COMO PARAMETRO LA CADENA Y SU LONGITUD
        public bool ValidateString(string Input, int lengthMin, int lenghtMax)
        {
            bool valid = false;
            if (!string.IsNullOrWhiteSpace(Input) && (Input.Length >= lengthMin && Input.Length <= lenghtMax))
            {
                valid = true;
            }
            return valid;
        }
        //VALIDADOR DE ENTEROS
        public bool ValidateInteger(string Input, int lengthMin, int lenghtMax)
        {
            return false;
        }
        //VALIDADOR DE CARACTERES
        public bool ValidateChar(char Input)
        {
            return false;
        }

        public bool ValidatePath()
        {
            Path path = new Path();
            bool exists = System.IO.File.Exists(path.fileName);
            return exists;
            path = null;
        }
        public bool ValidatePersonExists(List<Student> students, Student newStudent)
        {
            bool exists = false;
            foreach (Student student in students)
            {
                if (student.id == newStudent.id && ValidateString(student.id, 1, 1))
                {
                    exists = true;
                }
            }
            return exists;
        }
    }
}
