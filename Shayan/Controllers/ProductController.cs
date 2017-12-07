using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Shayan.Controllers
{
    
    public class ProductController : BaseEntityController<Product>
    {

        // GET list of products

        // List of questions in each product

        // List of stages

        // Post a question

        // Update question stage
        protected override object SelectProvider(Product info) => new
        {
            _id = info._id.ToString(),
            Name = info.Name
        };
    }
}
