using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fashion_Fuction.Extension
{
    public interface IBufferedFileUploadService
    {
        public Task<bool> UploadFile(IFormFile file, string fileName, string productId);
    }
}
