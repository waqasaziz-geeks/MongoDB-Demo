using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace Shayan
{
    public class Stage
    {
        public ObjectId _id { get; set; }
        public string Name { get; set; }
    }
}
