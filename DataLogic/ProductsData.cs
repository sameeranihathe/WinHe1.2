﻿using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLogic
{
   public class ProductsData
    {
       
       public void Insert(ProductsModel obj)
       {
           using (WinHeDbEntities db = new WinHeDbEntities())
           {
               tbl_product tbl = new tbl_product();

               tbl.Product_Name = obj.product_name;
               tbl.Product_Description = obj.product_description;
               tbl.Purchase_Price = obj.purchase_price;
               tbl.Selling_price = obj.selling_price;
               tbl.Quantity = obj.quantity;

               db.tbl_product.Add(tbl);
               db.SaveChanges();

           }
       }

       public List<ProductsModel> GetData()
       {
           List<ProductsModel> productList = new List<ProductsModel>();
           
           try 
	        {	        
		        using (WinHeDbEntities context = new WinHeDbEntities()){
                //LINQ quary
                List<tbl_product> list = (from recodes in context.tbl_product select recodes).ToList();

                foreach (tbl_product item in list)
                {
                    ProductsModel obj = new ProductsModel();

                    obj.product_id = item.ProductID;
                    obj.product_name = item.Product_Name;
                    obj.product_description = item.Product_Description;
                    obj.purchase_price = (decimal)item.Purchase_Price;
                    obj.selling_price = (decimal)item.Selling_price;
                    obj.quantity = (int)item.Quantity;

                    productList.Add(obj);
                }
	

                }
	        }
	        catch (Exception)
	        {
		
		        throw;
	        }
           return productList;
       }

        

        public void Edit(ProductsModel pm)
       {
           try
           {
               using (WinHeDbEntities dbupdate = new WinHeDbEntities())
               {
                   tbl_product updateProducts = (from record in dbupdate.tbl_product where record.ProductID == pm.product_id select record).FirstOrDefault();

                   updateProducts.Product_Name = pm.product_name;
                   updateProducts.Product_Description = pm.product_description;
                   updateProducts.Purchase_Price = pm.purchase_price;
                   updateProducts.Selling_price = pm.selling_price;
                   updateProducts.Quantity = pm.quantity;

                   dbupdate.Entry(updateProducts).State = System.Data.Entity.EntityState.Modified;
                   dbupdate.SaveChanges();
               }

           }
           catch (Exception)
           {
               
               throw;
           }
       }

       public bool Delete(int pid)
       {
           bool isSaved = false;
           try
           {
               using (WinHeDbEntities context = new WinHeDbEntities())
               {
                   tbl_product deleteproduct = (from record in context.tbl_product where record.ProductID == pid select record).FirstOrDefault();
                   context.tbl_product.Remove(deleteproduct);
                   context.SaveChanges();
               }
           }
           catch (Exception)
           {
               
               
           }

           return isSaved;
       }

          public List<ProductsModel> GetSearchData(string txt)
          {
              List<ProductsModel> dataList = new List<ProductsModel>();

              try
              {
                  using (WinHeDbEntities context = new WinHeDbEntities())
                  {
                      List<tbl_product> list = (from recodes in context.tbl_product where (recodes.Product_Name.Contains(txt))select recodes).ToList();

                      foreach (tbl_product item in list)
                      {
                          ProductsModel pd = new ProductsModel();

                          pd.product_id = item.ProductID;
                          pd.product_name = item.Product_Name;
                          pd.product_description = item.Product_Description;
                          pd.purchase_price = item.Purchase_Price;
                          pd.selling_price = item.Selling_price;
                          pd.quantity = item.Quantity;

                          dataList.Add(pd);
                      }

                  }
              }
              catch (Exception)
              {
               
                  throw;
              }

              return dataList;

          } 
    }
}
