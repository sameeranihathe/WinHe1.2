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

        public List<CostomerModel> getCustomer()
        {
            List<CostomerModel> returnList = new List<CostomerModel>();
            returnList = this.cd.GetData();

            return returnList;
        }

        public List<CostomerModel> SearchCustomer(string search_text)
        {
            List<CostomerModel> reList = new List<CostomerModel>();

            reList = this.cd.GetSearchData(search_text);

            return reList;
        }
    }
}
