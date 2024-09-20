using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SistemaVendasPadaria.Data;
using SistemaVendasPadaria.Models;

namespace SistemaVendasPadaria.Pages.ClientesRegistrados
{
    public class CreateModel : PageModel
    {
        private readonly SistemaVendasPadaria.Data.SistemaVendasPadariaContext _context;

        public CreateModel(SistemaVendasPadaria.Data.SistemaVendasPadariaContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public ClienteRegistrado ClienteRegistrado { get; set; } = default!;

        [TempData]
        public string Mensagem { get; set; }

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            if (ClienteRegistrado.Cpf.Length != 11)
            {
                Mensagem = "Informe um CPF válido";
                return Page();
            }

            _context.ClienteRegistrado.Add(ClienteRegistrado);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
