using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CineMania.Data;
using CineMania.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CineMania.Pages.Contacts
{
    public class ContactModel : PageModel
    {
        private readonly CinemaniaContext _context;

        public ContactModel(CinemaniaContext context)
        {
            _context = context;
        }
        
        
        public IActionResult OnGet()
        {

            return Page();

        }
        [BindProperty] 
        public Contact Contact { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Contacts.Add(Contact);
            await _context.SaveChangesAsync();
            return Redirect("../Movies/Index");
        }
    }
}