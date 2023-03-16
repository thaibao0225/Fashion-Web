using Fashion_Infrastructure.Configurations;
using Fashion_Infrastructure.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Fashion_Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public static readonly ILoggerFactory loggerFactory = LoggerFactory.Create(builder => {
            builder
                .AddConsole();
        });

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);




            builder.ApplyConfiguration(new BillsTableConfigurations());
            builder.ApplyConfiguration(new CategoriesTableConfigurations());
            builder.ApplyConfiguration(new ColorInProductTableConfigurations());
            builder.ApplyConfiguration(new ColorsTableConfigurations());
            builder.ApplyConfiguration(new CommentTableConfigurations());
            builder.ApplyConfiguration(new ContactTableConfigurations());
            builder.ApplyConfiguration(new EmailCustomerTableConfigurations());
            builder.ApplyConfiguration(new ProductsTableConfigurations());
            builder.ApplyConfiguration(new RolesTableConfigurations());
            builder.ApplyConfiguration(new SizeInProductTableConfigurations());
            builder.ApplyConfiguration(new SizeTableConfigurations());
            builder.ApplyConfiguration(new UsersTableConfigurations());

            //builder.Seed();

        }


        public DbSet<BillsTable> billsTable { set; get; }
        public DbSet<CategoriesTable> categoriesTable { set; get; }
        public DbSet<ColorInProductTable> colorInProductTable { set; get; }
        public DbSet<ColorsTable> colorsTable { set; get; }
        public DbSet<CommentTable> commentTable { set; get; }
        public DbSet<ContactTable> contactTable { set; get; }
        public DbSet<EmailCustomerTable> emailCustomerTable { set; get; }
        public DbSet<ProductsTable> productsTable { set; get; }
        public DbSet<RolesTable> rolesTable { set; get; }
        public DbSet<SizeInProductTable> sizeInProductTable { set; get; }
        public DbSet<SizeTable> sizeTable { set; get; }
        public DbSet<UsersTable> usersTable { set; get; }
    }
}