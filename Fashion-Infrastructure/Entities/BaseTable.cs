
using System.Runtime.InteropServices;

namespace Fashion_Infrastructure.Entities
{
    public class BaseTable
    {
        public string CreateBy { get; set; }
        public string CreateOn { get; set; }
        public string? UpdateBy { get; set; }
        public string? UpdateOn { get; set; }
        public Boolean IsDelete { get; set; } = false;

    }
}
