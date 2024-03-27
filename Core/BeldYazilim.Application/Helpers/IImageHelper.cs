using BeldYazilim.Dto.ImageDtos;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeldYazilim.Application.Helpers
{
    public interface IImageHelper
    {

        Task<ImageUploadedDto> Upload(string name, IFormFile imageFile, string folderName = null);
        void Delete(string imageName);
    }
}
