using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DataLogic;

namespace BusinessLogic
{
   public class CustomerBusinessLogic
    {
       CustomersData cd = new CustomersData();

        public void InsertToBusinessLogic(CostomerModel cm)
        {
            cd.Insert(cm);
        }
    }
}
