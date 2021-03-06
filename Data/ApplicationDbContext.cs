using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Myeal.Models;
using Spoonacular.Model;

namespace Myeal.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Myeal.Models.Auth0_Account>? Auth0_Account { get; set; }

        public DbSet<Myeal.Models.SpoonacularSearchViewModel>? SpoonacularSearchViewModel { get; set; }

        public DbSet<Myeal.Models.RecipeSearchFormModel>? RecipeSearchModel { get; set; }
    }
}