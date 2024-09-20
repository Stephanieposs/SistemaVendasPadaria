using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SistemaVendasPadaria.Data;
using SistemaVendasPadaria.Models;

namespace SistemaVendasPadaria.Pages.ClientesRegistrados
{
    public class IndexModel : PageModel
    {
        private readonly SistemaVendasPadaria.Data.SistemaVendasPadariaContext _context;

        public IndexModel(SistemaVendasPadaria.Data.SistemaVendasPadariaContext context)
        {
            _context = context;
        }

        public IList<ClienteRegistrado> ClienteRegistrado { get;set; } = default!;

        public async Task OnGetAsync()
        {
            ClienteRegistrado = await _context.ClienteRegistrado.ToListAsync();
        }
    }
}
