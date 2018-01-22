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
    }
}
