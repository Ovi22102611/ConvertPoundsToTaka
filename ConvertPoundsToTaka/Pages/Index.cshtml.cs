using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ConvertPoundsToTaka.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public decimal AmountInPounds { get; set; }

        public decimal? ConvertedAmount { get; set; }

        private decimal PoundToTakaRate = 115.50m; // Example rate, adjust to the current rate

        public void OnPost()
        {
            ConvertedAmount = AmountInPounds * PoundToTakaRate;
        }
    }
}
