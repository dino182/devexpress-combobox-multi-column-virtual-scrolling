using BlazorApp.Server.Data;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Data.ResponseModel;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace BlazorApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataController : ControllerBase
    {
        private readonly NorthwindContext _context;

        public DataController(NorthwindContext context)
        {
            _context = context;
        }

        [HttpGet]
        public Task<LoadResult> Get(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.LoadAsync(
                _context.Customers
                .AsNoTracking()
                , loadOptions);
        }
    }
}
