using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_ID_IOC.Dao
{
    public class DaoImpl : IDao
    {

        private String name;

        public string Name { get => name; set => name = value; }

        public String GetName()
        {
            return "Nouveau Service";
        }

  
    }
}
