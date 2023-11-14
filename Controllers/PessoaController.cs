using CRUDcomAjax.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CRUDcomAjax.Controllers
{
    public class PessoaController : Controller
    {
        private readonly AppDbContext _context;

        public PessoaController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> GetPessoas()
        {
            try
            {
                return Json(await _context.Pessoas.ToListAsync());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


    }
}
