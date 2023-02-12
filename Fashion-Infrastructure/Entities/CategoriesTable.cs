using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace Fashion_Infrastructure.Entities
{
    public class CategoriesTable : BaseTable
    {
        public string category_Id { get; set; } = string.Empty;
        public string category_Name { get; set; } = string.Empty;
        public string categpry_Description { get; set; } = string.Empty;



        public List<ProductsTable>? Products { get; set; } 



    }
}
