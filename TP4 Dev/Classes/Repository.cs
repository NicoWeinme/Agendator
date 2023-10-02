using Newtonsoft.Json;
using System;
using System.Collections;
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
        public void AddStudent(Student newStudent)
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

            if (!validator.ValidatePersonExists(students, newStudent))
            {
                students.Add(newStudent);
                contentJson = JsonConvert.SerializeObject(students);
                try
                {
                    File.WriteAllText(path.fileName, contentJson);
                }
                catch (Exception e) { Console.WriteLine(e.Message); }
                Console.WriteLine($"Se agregó a {newStudent.firstName}, {newStudent.lastName} a su agenda");
            }
            else { Console.WriteLine($"El usuario {newStudent.firstName}, {newStudent.lastName} que intenta ingresar ya existe en base de datos"); }            

        }

        public void DeleteStudent(Student newStudent)
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

            if (validator.ValidatePersonExists(students, newStudent))
            {
                students.RemoveAll(student => string.Equals(student.id.Trim(), newStudent.id.Trim()));
                contentJson = JsonConvert.SerializeObject(students);
                try
                {
                    File.WriteAllText(path.fileName, contentJson);
                }
                catch (Exception e) { Console.WriteLine(e.Message); }
                Console.WriteLine($"Se quitó a {newStudent.firstName}, {newStudent.lastName} de su agenda");
            }
            else { Console.WriteLine($"El usuario {newStudent.firstName}, {newStudent.lastName} que intenta eliminar no existe en base de datos"); }

        }
        public void Query()
        {

        }
        
    }
}
