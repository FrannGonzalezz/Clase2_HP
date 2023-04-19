using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Clase_2.Pages
{
    public class PruebaFormModel : PageModel
    {
        private readonly ILogger<PruebaFormModel> _logger;

        public PruebaFormModel(ILogger<PruebaFormModel> logger)
        {
            _logger = logger;
        }

        //Propiedad creada para manejar los datos del formulario de la página PruebaForm
        [BindProperty]
        public Form Datos { get; set; }

        public void OnGet()
        {
            Datos = new Form();
            Datos.Usuario = "fgonzalezpodesta@gmail.com";
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            // guardar en la base de datos, procesar la info que trae

            var FormValues = Datos;

            return RedirectToPage("IngresoExitoso");
        }
    }
}
