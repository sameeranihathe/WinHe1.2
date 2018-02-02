using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ProductsModel
    {
        public int product_id { get; set; }
        public string product_name { get; set; }
        public string product_description { get; set; }
        public decimal purchase_price { get; set; }
        public decimal selling_price { get; set; }
        public int quantity { get; set; }

        
    }
}