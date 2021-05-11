using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesTurtle.Data;
using RazorPagesTurtle.Models;

namespace RazorPagesTurtle.Pages.Turtles
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesTurtle.Data.RazorPagesTurtleContext _context;

        public IndexModel(RazorPagesTurtle.Data.RazorPagesTurtleContext context)
        {
            _context = context;
        }

        public IList<Turtle> Turtle { get;set; }

        public async Task OnGetAsync()
        {
            Turtle = await _context.Turtle.ToListAsync();
        }
    }
}
