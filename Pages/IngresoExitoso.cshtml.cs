using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Clase_2.Pages
{
    public class IngresoExitosoModel : PageModel
    {
        private readonly ILogger<IngresoExitosoModel> _logger;

        public IngresoExitosoModel(ILogger<IngresoExitosoModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
        }
    }
}
