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
    /// <summary>
    /// EN LA PRESENTE CLASE "Manager" REALIZAMOS LA ADMINISTRACIÓN DEL PROGRAMA.
    /// </summary>
    
    internal class Manager
    {
        //MÉTODO START PARA INICIALIZAR APP
        public void Start()
        {
            Reader reader = new Reader();
            Presenter presenter = new Presenter();
            presenter.ShowMainMenu();
            int option = reader.ReadOption('1', '6');
            bool managerBool = true;
            while (managerBool)
            {
                switch (option)
                {
                    case 1: InsertStudent(); break;
                    case 2: DropStudent(); break;
                    case 3: ModifyStudent(); break;
                    case 4: QueryStudentInfo(); break;
                    case 5: ListOfContacts(); break;
                    case 6: Environment.Exit(0); break;
                    default: presenter.InputErrorMessage(); Start(); break;
                }
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

        //Consulta de información del contacto
        public void QueryStudentInfo()
        {
            bool managerBool = true;
            Reader reader = new Reader();
            Presenter presenter = new Presenter();
            Repository<Student> repository = new Repository<Student>();
            Student student = new Student();

            //Bucle while para controlar el ingreso de DNI
            while (managerBool)
            {
                presenter.ReadDNIStudentForQueryMenu();
                student.id = reader.ReadDNI();
                int output = repository.VerifyExistsInt(student);
                if (student.id == 0)
                {
                    presenter.InputErrorMessage();
                }
                else if (output == 2)
                {
                    presenter.StudentNotFound();
                }
                else
                {
                    student = repository.VerifyExists(student);
                    presenter.StudentInfoMenu1(student);
                    presenter.StudentInfoMenu2(student);
                    managerBool = false;
                }
            }

            Start();
        }

        //Eliminación de contacto
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
                presenter.ReadDNIStudentForDropMenu();
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
                        presenter.ReadDNIStudentForDropMenu();
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
            if (option == 1)
            {

                presenter.StudentDeleted(student.id);

            }

            Start();
        }

        //Modificación de contacto
        public void ModifyStudent()
        {
            bool managerBool = true;
            char option = '0';
            Reader reader = new Reader();
            Presenter presenter = new Presenter();
            Repository<Student> repository = new Repository<Student>();
            Student student = new Student();

            //Bucle while para controlar el ingreso de DNI
            while (managerBool)
            {
                presenter.ReadDNIStudentForUpdateMenu();
                student.id = reader.ReadDNI();
                int output = repository.VerifyExistsInt(student);
                if (student.id == 0)
                {
                    presenter.InputErrorMessage();
                }
                else if (output == 2)
                {
                    presenter.StudentNotFound();
                }
                else
                {
                    managerBool = false;
                }
            }

            managerBool = true;
            student = repository.VerifyExists(student);
            while (managerBool)
            {
                presenter.SelectValueForUpdateMenu();
                option = reader.ReadOptionForUpdate();
                switch (option)
                {
                    case 'j': repository.UpdateStudent(ModifyFacebookId(presenter, student, reader, option)); managerBool = false; break;
                    case 'a': repository.UpdateStudent(ModifyName(presenter, student, reader, option)); managerBool = false; break;
                    case 'f': repository.UpdateStudent(ModifyLastName(presenter, student, reader, option)); managerBool = false; break;
                    case 'b': repository.UpdateStudent(ModifyMail(presenter, student, reader, option)); managerBool = false; break;
                    case 'g': repository.UpdateStudent(ModifyCountry(presenter, student, reader, option)); managerBool = false; break;
                    case 'c': repository.UpdateStudent(ModifyPhone(presenter, student, reader, option)); managerBool = false; break;
                    case 'h': repository.UpdateStudent(ModifyCity(presenter, student, reader, option)); managerBool = false; break;
                    case 'd': repository.UpdateStudent(ModifyBornDate(presenter, student, reader, option)); managerBool = false; break;
                    case 'i': repository.UpdateStudent(ModifyStreet(presenter, student, reader, option)); managerBool = false; break;
                    case 'e': repository.UpdateStudent(ModifyTwitterId(presenter, student, reader, option)); managerBool = false; break;
                    case 'k': repository.UpdateStudent(ModifyInstagramID(presenter, student, reader, option)); managerBool = false; break;
                    case 'J': repository.UpdateStudent(ModifyFacebookId(presenter, student, reader, option)); managerBool = false; break;
                    case 'A': repository.UpdateStudent(ModifyName(presenter, student, reader, option)); managerBool = false; break;
                    case 'F': repository.UpdateStudent(ModifyLastName(presenter, student, reader, option)); managerBool = false; break;
                    case 'B': repository.UpdateStudent(ModifyMail(presenter, student, reader, option)); managerBool = false; break;
                    case 'G': repository.UpdateStudent(ModifyCountry(presenter, student, reader, option)); managerBool = false; break;
                    case 'C': repository.UpdateStudent(ModifyPhone(presenter, student, reader, option)); managerBool = false; break;
                    case 'H': repository.UpdateStudent(ModifyCity(presenter, student, reader, option)); managerBool = false; break;
                    case 'D': repository.UpdateStudent(ModifyBornDate(presenter, student, reader, option)); managerBool = false; break;
                    case 'I': repository.UpdateStudent(ModifyStreet(presenter, student, reader, option)); managerBool = false; break;
                    case 'E': repository.UpdateStudent(ModifyTwitterId(presenter, student, reader, option)); managerBool = false; break;
                    case 'K': repository.UpdateStudent(ModifyInstagramID(presenter, student, reader, option)); managerBool = false; break;
                    case 'l': repository.UpdateStudent(ModifyID(presenter, student, reader, option)); managerBool = false; break;
                    default:
                        presenter.InputErrorMessage(); Start(); break;
                }
            }
            presenter.StudentUpdated(student);
            Start();
        }

        //Modificación de campos
        public Student ModifyFacebookId(Presenter presenter, Student student, Reader reader, char option)
        {
            bool managerBool = true;
            while (managerBool)
            {
                presenter.updateMenu("facebook ID", student.facebookID, student);
                string temp = reader.ReadNewValue(option);
                if (temp == "0")
                {
                    presenter.InputErrorMessage();
                }
                else { student.facebookID = temp;  managerBool = false; }
            }
            return student;
        }
        public Student ModifyName(Presenter presenter, Student student, Reader reader, char option)
        {
            bool managerBool = true;
            while (managerBool)
            {
                presenter.updateMenu("el nombre", student.firstName, student);
                string temp = reader.ReadNewValue(option);
                if (temp == "0")
                {
                    presenter.InputErrorMessage();
                }
                else { student.firstName = temp; managerBool = false; }
            }
            return student;
        }
        public Student ModifyCountry(Presenter presenter, Student student, Reader reader, char option)
        {
            bool managerBool = true;
            while (managerBool)
            {
                presenter.updateMenu("el pais", student.country, student);
                string temp = reader.ReadNewValue(option);
                if (temp == "0")
                {
                    presenter.InputErrorMessage();
                }
                else { student.country = temp; managerBool = false; }
            }
            return student;
        }
        public Student ModifyLastName(Presenter presenter, Student student, Reader reader, char option)
        {
            bool managerBool = true;
            while (managerBool)
            {
                presenter.updateMenu("el apellido", student.lastName, student);
                string temp = reader.ReadNewValue(option);
                if (temp == "0")
                {
                    presenter.InputErrorMessage();
                }
                else { student.lastName = temp; managerBool = false; }
            }
            return student;
        }
        public Student ModifyMail(Presenter presenter, Student student, Reader reader, char option)
        {
            bool managerBool = true;
            while (managerBool)
            {
                presenter.updateMenu("el correo electronico", student.mail, student);
                string temp = reader.ReadNewValue(option);
                if (temp == "0")
                {
                    presenter.InputErrorMessage();
                }
                else { student.mail = temp; managerBool = false; }
            }
            return student;
        }
        public Student ModifyCity(Presenter presenter, Student student, Reader reader, char option)
        {
            bool managerBool = true;
            while (managerBool)
            {
                presenter.updateMenu("la ciudad", student.city, student);
                string temp = reader.ReadNewValue(option);
                if (temp == "0")
                {
                    presenter.InputErrorMessage();
                }
                else { student.city = temp; managerBool = false; }
            }
            return student;
        }
        public Student ModifyStreet(Presenter presenter, Student student, Reader reader, char option)
        {
           
            bool managerBool = true;
            while (managerBool)
            {

                presenter.updateMenu("el domicilio", student.street, student);
                string temp = reader.ReadNewValue(option);
                if (temp == "0")
                {
                    presenter.InputErrorMessage();
                }
                else { student.street = temp; managerBool = false; }
            }
            return student;
        }
        public Student ModifyPhone(Presenter presenter, Student student, Reader reader, char option)
        {
            bool managerBool = true;
            while (managerBool)
            {
                presenter.updateMenu("el telefono", student.phone.ToString(), student);
                string temp = reader.ReadNewValue(option);
                if (temp == "0")
                {
                    presenter.InputErrorMessage();
                }
                else { student.phone = int.Parse(temp); managerBool = false; }
            }
            return student;
        }
        public Student ModifyTwitterId(Presenter presenter, Student student, Reader reader, char option)
        {
            bool managerBool = true;
            while (managerBool)
            {
                presenter.updateMenu("twitter ID", student.twitterID, student);
                string temp = reader.ReadNewValue(option);
                if (temp == "0")
                {
                    presenter.InputErrorMessage();
                }
                else { student.twitterID = temp; managerBool = false; }
            }
            return student;
        }
        public Student ModifyInstagramID(Presenter presenter, Student student, Reader reader, char option)
        {
            bool managerBool = true;
            while (managerBool)
            {
                presenter.updateMenu("instagram ID", student.instagramID, student);
                string temp = reader.ReadNewValue(option);
                if (temp == "0")
                {
                    presenter.InputErrorMessage();
                }
                else { student.instagramID = temp; managerBool = false; }
            }
            return student;
        }
        public Student ModifyBornDate(Presenter presenter, Student student, Reader reader, char option)
        {
            bool managerBool = true;
            while (managerBool)
            {

                presenter.updateMenu("fecha de nacimiento", student.bornDate, student);
                string temp = reader.ReadNewValue(option);
                if (temp == "0")
                {
                    presenter.InputErrorMessage();
                }
                else { student.bornDate = temp; managerBool = false; }
            }
            return student;
        }
        public Student ModifyID(Presenter presenter, Student student, Reader reader, char option)
        {
            bool managerBool = true;
            while (managerBool)
            {
                presenter.updateMenu("DNI", student.id.ToString(), student);
                string temp = reader.ReadNewValue(option);
                if (temp == "0")
                {
                    presenter.InputErrorMessage();
                }
                else { student.id = int.Parse(temp); managerBool = false;  }
            }
            return student;
        }

        public void ListOfContacts()
        {
            Presenter presenter = new Presenter();
            Repository<Student> repository = new Repository<Student>();
            presenter.ListOfContactsMenu(repository.FindListOfStudents());
            Start();
        }
    }
}
