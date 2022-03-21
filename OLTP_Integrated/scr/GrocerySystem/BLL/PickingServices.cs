#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using GrocerySystem.Models;
using GrocerySystem.DAL;
using GrocerySystem.Entities;
using Microsoft.EntityFrameworkCore.ChangeTracking;
#endregion


namespace GrocerySystem.BLL
{
    public class PickingServices
    {
        #region Constructor and DI variable setup
        private readonly GrocerylistContext _context;

        internal PickingServices(GrocerylistContext context)
        {
            _context = context;
        }
        #endregion

        #region Query
        public QueryOrderList Picking_GetPickingOrder(int orderid,
                                             int pickerid)
        {
            QueryOrderList info = _context.Orders
                                 .Where(x => x.OrderID == orderid)
                                 .Select(x => new QueryOrderList
                                 {
                                     PickerName = _context.Pickers
                                                    .Where(y => y.PickerID == pickerid)
                                                    .Select(x => x.FirstName + " " + x.LastName)
                                                    .FirstOrDefault(),
                                     CustomerName = x.Customer.FirstName + " " + x.Customer.LastName,
                                     CustomerPhone = x.Customer.Phone,
                                     OrderedItems = x.OrderLists
                                                    .Select(o => new QueryOrderListItem
                                                    {
                                                        OrderListId = o.OrderListID,
                                                        ProductId = o.ProductID,
                                                        Description = o.Product.Description,
                                                        OrderQty = o.QtyOrdered,
                                                        OrderComment = o.CustomerComment
                                                    })
                                                    .ToList()
                                 }).FirstOrDefault();
            return info;

        }
        #endregion

        #region Command
        public void Picking_RecordPicking(int orderid, int pickerid, List<PickedItem> orderitems)
        {
            #region TODO: Student Code Here
            // TODO: Student Code Here
            throw new NotImplementedException("OnPostSave() Not Implemented"); // Remove this line as necessary
            //Rules:
            //Order exists
            //Picker exists
            //Picker assigned to store where order is placed.
            //List has at least one item picked
            //Each Order item exists
            //Every item picked quantity is positive (greater or equal to zero)
            //Any item that is picked that has a picked quanity not equal to the ordered qty must have a picked concern  

            //Update OrderList items quantity picked, product price, product discount, Pick issue
            //Update Order picker, last date updated (today), subtotal, gst, status (R)
            #endregion
        }
        #endregion


    }
}
