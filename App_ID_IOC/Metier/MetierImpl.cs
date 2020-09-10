using App_ID_IOC.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_ID_IOC.Metier
{
   public class MetierImpl : IMetier
    {
        public IDao dao;

        public IDao Dao { get; set; }

        public MetierImpl(IDao dao)
        {
            this.dao = dao;
            
        }

        public MetierImpl()
        {
          
        }

        public void ShowInformation()
        {
            Console.WriteLine(dao.GetName().ToString());
          
        }

        public override String ToString()
        {

            return string.Format($"information Metier :# {dao.GetName()} ");

        }

    }
}
