using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrocerySystem.Models
{
    public class QueryOrderListItem
    {
        public int OrderListId { get; set; }
        public int ProductId { get; set; }
        public string Description { get; set;  }
        public double OrderQty { get; set; }
        public string OrderComment { get; set; }
    }
}
