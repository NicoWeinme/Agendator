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
            Presenter presenter = new Presenter();
            presenter.ShowMainMenu();

            Reader reader = new Reader();

        }
    }
}
