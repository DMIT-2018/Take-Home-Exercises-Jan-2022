using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrocerySystem.Models
{
    public class PickedItem
    {
        public int OrderListId { get; set; }
        public int ProductId { get; set; }
        public decimal QtyPicked { get; set; }
        public string Pickedissue { get; set; }
    }
}
