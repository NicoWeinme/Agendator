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
            Reader reader = new Reader();
            Presenter presenter = new Presenter();
            presenter.ShowMainMenu();
            int option = reader.ReadOption();
            switch (option)
            {
                case 1: InsertStudent(); break;
                case 2: DropStudent(); break;
                case 3: Console.Write("3 seleccionado"); break;
                case 4: Console.Write("4 seleccionado"); break;
                case 5: Console.Write("5 seleccionado"); break;
                case 6: Console.Write("6 seleccionado"); break;
                default: Console.WriteLine("default"); break;
            }

        }
        public void InsertStudent() 
        {
            bool managerBool = true;
            Reader reader = new Reader();
            Presenter presenter = new Presenter();
            Repository<Student> repository = new Repository<Student>();
            Student student = new Student();
            //Bucle while para controlar el ingreso de DNI
            while (managerBool)
            {

                presenter.AddDNIMenu();
                student.id = reader.ReadDNI();
                if (student.id == 0)
                {
                    presenter.InputErrorMessage();
                }
                else { managerBool = false; }
            }


            //Bucle while para controlar el ingreso de nombre
            managerBool = true;
            while (managerBool)
            {
                presenter.AddNameMenu();
                student.firstName = reader.ReadName();
                if (student.firstName == "0")
                {
                    presenter.InputErrorMessage();
                    
                }
                else { managerBool = false; }
            }

            //Bucle while para controlar el ingreso de apellido
            managerBool = true;
            while (managerBool)
            {
                presenter.AddLastNameMenu();
                student.lastName = reader.ReadLastName();
                if (student.lastName == "0")
                {
                    presenter.InputErrorMessage();

                }
                else { managerBool = false; }
            }

            //Bucle while para controlar el ingreso de correo electrónico
            managerBool = true;
            while (managerBool)
            {
                presenter.AddMailMenu();
                student.mail = reader.ReadMail();
                if (student.mail == "0")
                {
                    presenter.InputErrorMessage();

                }
                else { managerBool = false; }
            }

            //Bucle while para controlar el ingreso de teléfono
            managerBool = true;
            while (managerBool)
            {
                presenter.AddPhoneMenu();
                student.phone = reader.ReadPhone();
                if (student.phone == 0)
                {
                    presenter.InputErrorMessage();

                }
                else { managerBool = false; }
            }

            //Bucle while para controlar el ingreso de fecha de nacimiento
            managerBool = true;
            while (managerBool)
            {
                presenter.AddBornDateMenu();
                student.bornDate = reader.ReadBornDate();
                if (student.bornDate == "0")
                {
                    presenter.InputErrorMessage();

                }
                else { managerBool = false; }
            }

            //Bucle while para controlar el ingreso de id de facebook
            managerBool = true;
            while (managerBool)
            {
                presenter.AddFacebookIDMenu();
                student.facebookID = reader.ReadFacebook();
                if (student.facebookID == "0")
                {
                    presenter.InputErrorMessage();

                }
                else { managerBool = false; }
            }

            //Bucle while para controlar el ingreso de id de twitter
            managerBool = true;
            while (managerBool)
            {
                presenter.AddTwitterIDMenu();
                student.twitterID = reader.ReadTwitter();
                if (student.twitterID == "0")
                {
                    presenter.InputErrorMessage();

                }
                else { managerBool = false; }
            }

            //Bucle while para controlar el ingreso de id de instagram
            managerBool = true;
            while (managerBool)
            {
                presenter.AddInstagramIDMenu();
                student.instagramID = reader.ReadInstagram();
                if (student.instagramID == "0")
                {
                    presenter.InputErrorMessage();

                }
                else { managerBool = false; }
            }

            //Bucle while para controlar el ingreso de país
            managerBool = true;
            while (managerBool)
            {
                presenter.AddCountryMenu();
                student.country = reader.ReadCountry();
                if (student.country == "0")
                {
                    presenter.InputErrorMessage();

                }
                else { managerBool = false; }
            }

            //Bucle while para controlar el ingreso de ciudad
            managerBool = true;
            while (managerBool)
            {
                presenter.AddCityMenu();
                student.city = reader.ReadCity();
                if (student.city == "0")
                {
                    presenter.InputErrorMessage();

                }
                else { managerBool = false; }
            }

            //Bucle while para controlar el ingreso de domicilio
            managerBool = true;
            while (managerBool)
            {
                presenter.AddStreetMenu();
                student.street = reader.ReadStreet();
                if (student.street == "0")
                {
                    presenter.InputErrorMessage();

                }
                else { managerBool = false; }
            }

            //Almacenado de edad en base a fecha de nacimiento contra fecha actual.
            student.age = reader.ReadAge(student.bornDate);

            repository.AddStudent(student);

            presenter.StudentAdded(student);

            Start();
        }

        public void DropStudent()
        {
            bool managerBool = true;
            int option = 0;
            Reader reader = new Reader();
            Presenter presenter = new Presenter();
            Repository<Student> repository = new Repository<Student>();
            Student student = new Student();

            //Bucle while para controlar el ingreso de DNI
            while (managerBool)
            {
                presenter.ReadDNIMenu();
                student.id = reader.ReadDNI();
                int output = repository.VerifyExistsInt(student);
                if (student.id == 0)
                {
                    presenter.InputErrorMessage();
                } else if (output == 2) 
                {
                    presenter.StudentNotFound();
                }
                else { managerBool = false; } 
            }

            managerBool = true;
            //Bucle while para controlar opción seleccionada
            while (managerBool)
            {

                presenter.DeleteStudentConfirm(repository.VerifyExists(student));

                char sOrN = reader.ReadYesOrNot();
                if (sOrN == '0')
                {
                    presenter.InputErrorMessage();
                }

                else if (sOrN == 'n' || sOrN == 'N')
                {
                    while (managerBool)
                    {
                        presenter.ReadDNIMenu();
                        student.id = reader.ReadDNI();
                        if (student.id == 0)
                        {
                            presenter.InputErrorMessage();
                        } 
                        else
                        {
                            managerBool = false;
                        }
                    }
                    managerBool = true;
                }
                else { managerBool = false; }

            }

            option = (repository.DeleteStudent(student));
            if  (option == 1)
            {
                
                presenter.StudentDeleted(student.id);

            }

            Start();
        }
    }
}
