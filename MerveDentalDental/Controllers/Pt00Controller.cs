using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MerveDentalDental.Models;
using Microsoft.EntityFrameworkCore;

namespace MerveDentalDental.Controllers
{
    public class Pt00Controller : Controller
    {
        private readonly MerveDentalDentalContext _context;

        
        public Pt00Controller(MerveDentalDentalContext context)
        {
            _context=context;
        }
        
        public async Task<IActionResult> Index(){
            return View(await _context.Pt00.ToListAsync());
        }
    }
}
