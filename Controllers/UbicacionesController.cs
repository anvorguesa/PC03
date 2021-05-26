using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PC03.Models;

namespace PC03.Controllers
{
    public class UbicacionesController : Controller
    {
       private readonly ClienteContext _context; 

       public UbicacionesController(ClienteContext context){
           _context = context;
       }

       public IActionResult Clientes(){
           var clientes = _context.Clientes.OrderBy(r => r.Nombre).ToList();
           return View();
       }
    }
}