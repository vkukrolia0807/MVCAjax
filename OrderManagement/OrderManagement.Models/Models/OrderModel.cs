using OrderManagement.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement.Models.Models
{
    public class OrderModel
    {
        public int orderId { get; set; }
        public int userId { get; set; }
        public string itemId { get; set; }
        public string couponCode { get; set; }
        public System.DateTime orderDate { get; set; }
        public int orderTotalQty { get; set; }
        public int orderItemQty { get; set; }
        public decimal orderAmount { get; set; }
        public decimal afterGst { get; set; }
        public decimal totalPayable { get; set; }
        public List<Items> itemList { get; set; }
    }
}
