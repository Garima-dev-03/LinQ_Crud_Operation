using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi2.Models;

namespace WebApi2.Data
{
    public class WebApiContext:DbContext
    {
        public WebApiContext(DbContextOptions<WebApiContext> opt) : base(opt)
        {

        }

        public DbSet<WebApiModel> WebApiTable { get; set; }

    }
}
