using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Server.Data;
using Shared.Models;

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController] //para usar como API
    public class CategoriesController : ControllerBase
    {
        private readonly AppDBContext _appDBContext;

        //localhost:5001/api/categories
        public CategoriesController(AppDBContext appDBContext)
        {
            _appDBContext = appDBContext; 
        }

        //ourwebsita.com/api/categories
        [HttpGet]
        public async Task<IActionResult> Get() 
        {
            List<Category> categories = await _appDBContext.Categories.ToListAsync();
            return Ok(categories);
        }

    }
}
