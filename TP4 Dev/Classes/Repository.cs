using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TP4_Dev.Classes
{
    public class Repository<T>
    {


        public void Read()
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
            }else { Console.WriteLine("Nope"); }
            foreach (Student student in students)
            {
                Console.WriteLine($"ID: {student.id}, Prop 1: {student.firstName}, Prop2: {student.lastName}, Prop3: {student.street}, Prop4: {student.country}");
            }
        }

        //CREAMOS EL MÉTODO DE ESCRITURA
        public void Write(Student Student)
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

            if (!validator.ValidatePersonExists(students, Student))
            {
                students.Add(Student);
                contentJson = JsonConvert.SerializeObject(students);
                try
                {
                    File.WriteAllText(path.fileName, contentJson);
                }
                catch (Exception e) { Console.WriteLine(e.Message); }
                Console.WriteLine($"Se agregó a {Student.firstName}, {Student.lastName} a su agenda");
            }
            else { Console.WriteLine("El usuario que intenta ingresar ya existe en base de datos"); }            

        }
        public void Query()
        {

        }
        
    }
}
