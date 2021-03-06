﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using LO.MyAirport.EF;

namespace LO.MyAirport.Razor.Pages.Bagages
{
    public class CreateModelBagage  : PageModel
    {
        private readonly LO.MyAirport.EF.MyAirportContext _context;

        public CreateModelBagage(LO.MyAirport.EF.MyAirportContext context)
        {
            _context = context;
        }

          public IActionResult OnGet()
        {
            ViewData["VolId"] = BagagesHelper.ListVolInfo(_context);
            return Page();
        }
        [BindProperty]
        public Bagage Bagage { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Bagages.Add(Bagage);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
