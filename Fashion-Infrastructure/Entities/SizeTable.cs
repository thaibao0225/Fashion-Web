namespace Fashion_Infrastructure.Entities
{
    public class SizeTable
    {
        public string size_Id {  get; set; }
        public int size_Name {  get; set; }
        public bool size_IsDelete {  get; set; }

        public List<SizeInProductTable> size_sizeInProductTablesList { get; set; }
        public List<CartTable> size_CartTableList { get; set; }
    }
}
