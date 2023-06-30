using OrderManagement.Models.Context;
using OrderManagement.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement.Helpers.Helpers
{
    public static class OrderHelper
    {
        public static orders ModelToDb(OrderModel ModelOrder,int couponId)
        {
            try
            {
                orders DbOrder = new orders();
                DbOrder.orderId = ModelOrder.orderId;
                DbOrder.userId = ModelOrder.userId;
                DbOrder.itemId = ModelOrder.itemId;
                if (couponId == 0)
                {
                    DbOrder.couponCode = null;
                }
                else
                {
                    DbOrder.couponCode = couponId;
                }
                DbOrder.orderDate = ModelOrder.orderDate;
                DbOrder.orderTotalQty = ModelOrder.orderTotalQty;
                DbOrder.orderAmount = ModelOrder.orderAmount;
                DbOrder.afterGst = ModelOrder.afterGst;
                DbOrder.totalPayable = ModelOrder.totalPayable;
                return DbOrder;
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}
