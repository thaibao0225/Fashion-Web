using Fashion_Infrastructure.Data.StaticData;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fashion_Fuction.Extension
{
    public class BufferedFileUploadService : IBufferedFileUploadService
    {
        public async Task<bool> UploadFile(IFormFile file, string fileName, string productId)
        {
            string path = "";
            string productIdPath =  productId;
            try
            {
                if (file != null)
                {
                    path = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, BaseData.ImgPath, BaseData.ProductPath,  productIdPath));
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }

                    using (var fileStream = new FileStream(Path.Combine(path, fileName), FileMode.Create))
                    {
                        await file.CopyToAsync(fileStream);
                    }
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("File Copy Failed", ex);
            }
        }


    }
}
