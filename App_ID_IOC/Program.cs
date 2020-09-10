using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App_ID_IOC.Dao;
using App_ID_IOC.Metier;
using App_ID_IOC.Presentation;
namespace App_ID_IOC
{
    class Program
    {
        static void Main(string[] args)
        {
            DaoImpl dao = new DaoImpl();
            MetierImpl metier = new MetierImpl(dao);
            metier.Dao = dao;


            Console.WriteLine(metier.ToString());
            Console.ReadLine();
        }
    }
}
