using Microsoft.VisualBasic.FileIO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TP4_Dev.Classes
{
    public class Manager
    {
        //MÉTODO START PARA INICIALIZAR APP
        public void Start()
        {
            //Reader reader = new Reader();
            //Presenter presenter = new Presenter();
            //presenter.ShowMainMenu();
            //switch (reader.ReadOption())
            //{
            //    case '1': Console.Write("1 seleccionado"); break;
            //    case '2': Console.Write("2 seleccionado"); break;
            //    case '3': Console.Write("3 seleccionado"); break;
            //    case '4': Console.Write("4 seleccionado"); break;
            //    case '5': Console.Write("5 seleccionado"); break;
            //    case '6': Console.Write("6 seleccionado"); break;
            //    default:
            //        Console.WriteLine("default");
            //        break;
            //}
            


        }
        public void DeleteStudent(Student student)
        {
            //CREAMOS OBJETO PATH
            Path path = new Path();

            //CREAMOS LA LISTA DE ALUMNOS
            List<Student> students = new List<Student>();

            //VARIABLE DE CONTENIDO DEL ARCHIVO
            string contentJson;

            //GENERAMOS UN OBJETO VALIDADOR
            Validator validator = new Validator();

            //SE VALIDA EXISTENCIA DE FICHERO REPOSITORIO
            if (validator.ValidatePath())
            {
                contentJson = File.ReadAllText(path.fileName);
                try
                {
                    students = JsonConvert.DeserializeObject<List<Student>>(contentJson);
                }
                catch (Exception e) { Console.WriteLine(e.Message); }
            }

            if (validator.ValidatePersonExists(students, student))
            {
                students.Remove(student);
                contentJson = JsonConvert.SerializeObject(students);
                try
                {
                    File.WriteAllText(path.fileName, contentJson);
                }
                catch (Exception e) { Console.WriteLine(e.Message); }
                Console.WriteLine($"Se agregó a {student.firstName}, {student.lastName} a su agenda");
            }
            else { Console.WriteLine($"El usuario {student.firstName}, {student.lastName} que intenta eliminar no existe en base de datos"); }

        }
    }
}
