using System;
using System.Collections.Generic;
using System.IO;
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

            //SOLUTION 2 en utilisant un fichier de config 

            String path = "Config.txt";
            try
            {
                StreamReader read = new StreamReader(path);
                String[] data = File.ReadAllLines(path);

                String daoClassName = data[0];
                String metierClassName = data[1];

                Type typeDao = Type.GetType(daoClassName);
                IDao dao =(IDao) Activator.CreateInstance(typeDao);

                Type typeMetier = Type.GetType(metierClassName);
                //j'instancie le type metier et je lui passe l'objet dao en parametre telque l'aurai fait dans le constructeur dans la Solution 1
                IMetier metier = (IMetier)Activator.CreateInstance(typeMetier,dao);



                Console.WriteLine(metier.ToString());

                //Console.WriteLine(daoClassName);
                //Console.WriteLine(metierClassName);
                Console.ReadKey();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
   

        //SOLUTION 1


        //    DaoImpl dao = new DaoImpl();
        //    MetierImpl metier = new MetierImpl(dao);
        //    metier.Dao = dao;
        //    Console.WriteLine(metier.ToString());
        //    Console.ReadLine();
        //
        }
    }
}
