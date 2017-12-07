using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shayan.Controllers
{
    public class StageController : BaseEntityController<Stage>
    {
        protected override object SelectProvider(Stage info) => new
        {
            _id = info._id.ToString(),
            Name = info.Name
        };
    }
}
