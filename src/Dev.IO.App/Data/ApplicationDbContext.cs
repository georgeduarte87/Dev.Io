﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Dev.IO.App.ViewModels;

namespace Dev.IO.App.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Dev.IO.App.ViewModels.ProdutoViewModel> ProdutoViewModel { get; set; }
    }
}
