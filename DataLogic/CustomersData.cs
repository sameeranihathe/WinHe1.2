using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace DataLogic
{
    public class CustomersData
    {

        public void Insert(CostomerModel cm)
        {
            using (WinHeDbEntities db = new WinHeDbEntities())
            {
                tbl_customer tbl = new tbl_customer();

                tbl.Customer_Name = cm.cus_name;
                tbl.Customer_Email = cm.cus_email;
                tbl.Address = cm.cus_address;
                tbl.ContactNo = cm.cus_contact;
                tbl.DOB = cm.cus_dob;
                tbl.Gender = cm.cus_gender;

                db.tbl_customer.Add(tbl);
                db.SaveChanges();
            }
        }

        public List<CostomerModel> GetData()
        {
            List<CostomerModel> customers = new List<CostomerModel>();
            try
            {
                using (WinHeDbEntities context = new WinHeDbEntities())
                {
                    List<tbl_customer> list = (from recodes in context.tbl_customer select recodes).ToList();

                    foreach (tbl_customer item in list)
                    {
                        CostomerModel cm = new CostomerModel();

                        cm.cus_name = item.Customer_Name;
                        cm.cus_email = item.Customer_Email;
                        cm.cus_address = item.Address;
                        cm.cus_dob = Convert.ToDateTime(item.DOB);
                        cm.cus_gender = item.Gender;
                        cm.cus_contact = Convert.ToInt32(item.ContactNo);

                        customers.Add(cm);
                    }
                }
            }
            catch (Exception)
            {
                
                throw;
            }

            return customers;

        }

        public List<CostomerModel> GetSearchData(string search_text)
        {
            List<CostomerModel> list = new List<CostomerModel>();

            try
            {
                using (WinHeDbEntities context = new WinHeDbEntities())
                {
                    List<tbl_customer> listdata = (from recodes in context.tbl_customer where (recodes.Customer_Name.Contains(search_text)) select recodes).ToList();

                    foreach (tbl_customer item in listdata)
                    {
                        CostomerModel cm = new CostomerModel();

                        cm.cus_address = item.Address;
                        cm.cus_contact = Convert.ToInt32(item.ContactNo);
                        cm.cus_dob = Convert.ToDateTime(item.DOB);
                        cm.cus_id = item.CustomerID;
                        cm.cus_email = item.Customer_Email;
                        cm.cus_gender = item.Gender;
                        cm.cus_name = item.Customer_Name;

                        list.Add(cm);

                    }
                }
            }
            catch (Exception)
            {

                throw;
            }

            return list;
        }
    }
}
