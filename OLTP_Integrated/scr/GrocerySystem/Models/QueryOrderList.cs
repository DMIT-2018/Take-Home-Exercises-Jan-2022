using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrocerySystem.Models
{
    public class QueryOrderList
    {
        public string PickerName { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }
        public List<QueryOrderListItem> OrderedItems { get; set; }
    }
}
