#nullable disable
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

#region Additional Namespaces
using GrocerySystem.BLL;
using GrocerySystem.Models;
using Microsoft.Extensions.Logging;
#endregion

namespace WebApp.Pages.ExercisePages
{
    public class RecordPickingModel : PageModel
    {
        #region Private variables and DI constructor
        private readonly PickingServices _pickingservices;
        [TempData]
        public string FeedBackMessage { get; set; }
        public string ErrorMessage { get; set; }

        //a get property that returns the result of the lamda action
        public bool HasError => !string.IsNullOrWhiteSpace(ErrorMessage);
        public bool HasFeedBack => !string.IsNullOrWhiteSpace(FeedBackMessage);
        public List<string> ErrorDetails { get; set; } = new();
        public RecordPickingModel(PickingServices pickingservices)
        {
            _pickingservices = pickingservices;
        }
        #endregion

        [BindProperty(SupportsGet = true)]
        public int? OrderId { get; set; }

        [BindProperty(SupportsGet = true)]
        public int? PickerId { get; set; }

        [BindProperty]
        public QueryOrderList OrderInfo { get; set; }

        [BindProperty]
        public List<PickedItem> PickedItems { get; set; }

        // TODO: Student Code Here
        // Add code to the form to display the Order items.
        // The table body will need to be properly setup to collect
        //      input data along with displaying the query information.
        public void OnGet()
        {
            if (OrderId.HasValue && PickerId.HasValue && OrderId > 0 && PickerId > 0)
            {
                OrderInfo = _pickingservices.Picking_GetPickingOrder((int)OrderId, (int)PickerId);
            }

        }

        public IActionResult OnPostSave()
        {
            #region TODO: Student Code Here
            try
            {
                // TODO: Student Code Here
                // Remove this line as after adding your code
                throw new NotImplementedException("OnPostSave() Not Implemented"); 
            
            }
            catch (AggregateException ex)
            {
                ErrorMessage = "Unable to process your request:";
                foreach (var problem in ex.InnerExceptions)
                    ErrorDetails.Add(problem.Message);
                return Page();
            }
            catch (Exception ex)
            {
                ErrorMessage = GetInnerException(ex).Message;
                return Page();
            }
            #endregion
        }


        #region Fetch and Clear no need to alter
        public IActionResult OnPostFetch()
        {
            if (!OrderId.HasValue || OrderId == 0)
            {
                FeedBackMessage = "You need a order number";
                OrderId = 0;
            }

            else if (!PickerId.HasValue || PickerId == 0)
            {
                FeedBackMessage = "You need a picker number";
                PickerId = 0;
            }

            return RedirectToPage(new { OrderId = OrderId, PickerId = PickerId });
        }

        public IActionResult OnPostClear()
        {
            OrderId = null;
            PickerId = null;
            return RedirectToPage(new { OrderId = OrderId, PickerId = PickerId });
        }

        private Exception GetInnerException(Exception ex)
        {
            while (ex.InnerException != null)
                ex = ex.InnerException;
            return ex;
        }
        #endregion
    }
}
