using KiPwChlab5.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace KiPwChlab5.Controllers;

public class StudentsController : Controller
{
    private readonly SchoolContext _context;

    public StudentsController(SchoolContext context)
    {
        _context = context;
    }
    
    public async Task<IActionResult> Index()
    {
        return View(await _context.Students.ToListAsync());
    }
}