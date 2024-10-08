﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SistemaVendasPadaria.Data;
using SistemaVendasPadaria.Models;

namespace SistemaVendasPadaria.Pages.Produtos
{
    public class DetailsModel : PageModel
    {
        private readonly SistemaVendasPadaria.Data.SistemaVendasPadariaContext _context;

        public DetailsModel(SistemaVendasPadaria.Data.SistemaVendasPadariaContext context)
        {
            _context = context;
        }

        public Produto Produto { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produto = await _context.Produto.FirstOrDefaultAsync(m => m.Id == id);
            if (produto == null)
            {
                return NotFound();
            }
            else
            {
                Produto = produto;
            }
            return Page();
        }
    }
}
