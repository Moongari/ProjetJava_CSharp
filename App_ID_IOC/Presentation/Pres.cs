using App_ID_IOC.Metier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_ID_IOC.Presentation
{
    public class Pres
    {

        MetierImpl metier;



        public void Show()
        {
            metier = new MetierImpl();
            metier.ShowInformation();
            Console.WriteLine(metier.ToString());
        }

    }
}
