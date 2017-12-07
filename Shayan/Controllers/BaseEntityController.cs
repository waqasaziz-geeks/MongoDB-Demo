using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Shayan.Controllers
{
    [Route("api/[controller]")]
    public abstract class BaseEntityController<T> : Controller
    {
        protected abstract object SelectProvider(T info);

        public IActionResult Index()
        {
            return Ok(Database.GetList<T>().Select(x => SelectProvider(x)));
        }
    }
}
