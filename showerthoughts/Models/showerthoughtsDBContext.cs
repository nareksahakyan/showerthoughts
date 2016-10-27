using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace showerthoughts.Models
{
    public class showerthoughtsDBContext:DbContext
    {
        public showerthoughtsDBContext():base("ShowerConnection")
        {
        }

        public DbSet<thought> thoughts {get; set;}
    }
}