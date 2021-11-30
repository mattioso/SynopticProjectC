using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace ApprenticeTips.Data
{
    public class ApprenticeTipsDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public ApprenticeTipsDbContext(DbContextOptions<ApprenticeTipsDbContext> options) : base(options)
        {

        } 
    }
}
