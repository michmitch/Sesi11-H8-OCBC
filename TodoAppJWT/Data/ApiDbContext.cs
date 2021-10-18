using Microsoft.EntityFrameworkCore;
using TodoAppJWT.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using TodoAppJWT.Data;
using TodoAppJWT.Configuration;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using Microsoft.EntityFrameworkCore;

namespace TodoAppJWT.Data
{
    public class ApiDbContext : IdentityDbContext
    {
        public virtual DbSet<ItemData> Items {get; set;}
        public virtual DbSet<RefreshToken> RefreshTokens {get; set;}

        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {
            
        }
    }
}