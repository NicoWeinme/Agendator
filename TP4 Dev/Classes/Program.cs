using Newtonsoft.Json;
using System;

namespace TP4_Dev.Classes
{
    class program
    {
        static void Main(string[] args)
        {
            //Manager manager = new Manager();
            //manager.Start();
            Student student1 = new Student();
            student1.firstName = "Pedro";
            student1.id = "1";
            student1.lastName = "Juarez";
            student1.street = "JJ STREET";
            student1.country = "Argentina";
            Student student2 = new Student();
            student2.firstName = "JUAN";
            student2.id = "2";
            student2.lastName = "JAMON";
            student2.street = "LEEEEE";
            student2.country = "PERUU";
            Student student3 = new Student();
            student3.firstName = "AAAA";
            student3.id = "3";
            student3.lastName = "BBBB";
            student3.street = "CCCC";
            student3.country = "DDDD";
            Repository<Student> repository = new Repository<Student>();
            repository.Write(student1);
            repository.Write(student2);
            repository.Write(student3);
            repository.Read();


            


          
            
                

            


        }
    }
}