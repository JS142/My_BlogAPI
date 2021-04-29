using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using My_Blog_API.Models;

namespace My_Blog_API.Data
{
    public class My_Blog_APIContext : DbContext
    {
        public My_Blog_APIContext (DbContextOptions<My_Blog_APIContext> options)
            : base(options)
        {
        }

        public DbSet<My_Blog_API.Models.Blog> Blog { get; set; }
    }
}
