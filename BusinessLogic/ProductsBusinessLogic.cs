using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DataLogic;

namespace BusinessLogic
{

    public class ProductsBusinessLogic
    {
       ProductsData pd = new ProductsData();
        public void InsertToBusinessLogic(ProductsModel obj)
        {
            pd.Insert(obj);
        }

        public List<ProductsModel> GetProduct()
        {
            List<ProductsModel> returnList = new List<ProductsModel>();

            returnList = this.pd.GetData();

            return returnList;
        }

        public void EditBusinessLogic(ProductsModel pm)
        {
            ProductsData pd = new ProductsData();
            pd.Edit(pm);
        }

        public bool DeleteProduct(int pid)
        {
            return this.pd.Delete(pid);
        }
        public List<ProductsModel> SearchProduct(string search_text)
        {
            List<ProductsModel> returnList = new List<ProductsModel>();

            returnList = this.pd.GetSearchData(search_text);

            return returnList;
        }

        
    }
}
