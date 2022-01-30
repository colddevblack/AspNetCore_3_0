using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using AspNetCore_3_0.Models;
using Microsoft.EntityFrameworkCore;

namespace AspNetCore_3_0.Connection
{
    public class BancoContext: DbContext
    {

        public BancoContext(DbContextOptions<BancoContext> options) : base(options) 
        {
            Database.EnsureCreated();
        }
        public DbSet<UsuarioModel> userdb { get; set; }



    }
}