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


        public Student VerifyExists(Student studentCheck)
        {
            //CREAMOS OBJETO PATH
            Path path = new Path();

            //CREAMOS LA LISTA DE ALUMNOS
            List<Student> students = new List<Student>();

            //VARIABLE DE CONTENIDO DEL ARCHIVO
            string contentJson;

            Student student1 = new Student();
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
            
            foreach (Student student in students)
            {
                if (student.id == studentCheck.id)
                {
                    student1 = student;
                }
            }
            return student1;
        }
        public int VerifyExistsInt(Student studentCheck)
        {
            //CREAMOS OBJETO PATH
            Path path = new Path();

            //CREAMOS LA LISTA DE ALUMNOS
            List<Student> students = new List<Student>();

            //VARIABLE DE CONTENIDO DEL ARCHIVO
            string contentJson;

            Student student1 = new Student();
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

            if (validator.ValidatePersonExists(students, studentCheck))
            {
                return 1;
            }
            else
            {
                return 2;//El usuario no existe en BD
            }
        }

        public int AddStudent(Student newStudent)
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
                catch (Exception e) { Console.WriteLine(e.Message); return 0; }
            }

            if (!validator.ValidatePersonExists(students, newStudent))
            {
                students.Add(newStudent);
                contentJson = JsonConvert.SerializeObject(students);
                try
                {
                    File.WriteAllText(path.fileName, contentJson);
                    return 1; //Se agregó el alumno
                }
                catch (Exception e) { Console.WriteLine(e.Message); return 0; }
            }
            else { return 3; }   //Ya existe el alumno en BD  
        }

        public int DeleteStudent(Student newStudent)
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
                catch (Exception e) { Console.WriteLine(e.Message);}
            }

            if (validator.ValidatePersonExists(students, newStudent))
            {
                students.RemoveAll(student => Equals(student.id, newStudent.id));
                contentJson = JsonConvert.SerializeObject(students);
                try
                {
                    File.WriteAllText(path.fileName, contentJson);
                    return 1; //Se eliminó al alumno
                }
                catch (Exception e) { Console.WriteLine(e.Message); return 0; }
            }
            else 
            { 
                return 3; //El usuario no existe en BD
            }
        }
        
    }
}
