namespace Fashion_Infrastructure.Entities
{
    public class ColorsTable
    {
        public string color_Id { get; set; }
        public string color_Name { get; set; }
        public bool color_IdDelete { get; set; }

        public List<ColorInProductTable> color_InProductsList { get; set;}
    }
}
