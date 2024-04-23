﻿using Microsoft.EntityFrameworkCore;
using WebAccountant.ModelsBase;
using WebAccountant.ModelsLogin;

namespace WebAccountant.DAOs
{
    public class LoginContext : DbContext
    {
        public LoginContext()
        {
        }
        public LoginContext(DbContextOptions<LoginContext> options)
            : base(options)
        {
            
        }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<DatabaseInfor> DatabaseInfors { get; set; }
    }
}
