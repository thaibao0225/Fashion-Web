namespace Fashion_Infrastructure.Entities
{
    public class SizeTable
    {
        public string size_Id {  get; set; }
        public string size_Name {  get; set; }
        public bool size_IsDelete {  get; set; }

        public List<SizeInProductTable> size_sizeInProductTablesList { get; set; }
    }
}
