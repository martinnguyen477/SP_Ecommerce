using CloudinaryDotNet.Actions;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Team27_BookshopWeb.Models;

namespace Team27_BookshopWeb.Services
{
    public interface IImportFileServices
    {
        /// <summary>
        /// Hàm thêm hình ảnh vào cloud.
        /// </summary>
        /// <param name="formFile">File cần up.</param>
        /// <param name="cloudName">Tên cloud.</param>
        /// <param name="apiKey">API key trên cloud.</param>
        /// <param name="apiSecret">API secret trên cloud.</param>
        /// <returns></returns>
        Task<ResponseUploadImageCloud> AddPhotoCloudAsync(IFormFile formFile, string cloudName, string apiKey, string apiSecret);

        /// <summary>
        /// Hàm xóa hình ảnh trên cloud.
        /// </summary>
        /// <param name="publicId">public Id.</param>
        /// <param name="cloudName">tên cloud.</param>
        /// <param name="apiKey">Api key.</param>
        /// <param name="apiSecret">Api secret.</param>
        /// <returns></returns>
        Task<DeletionResult> DeleteImageAsync(string publicId, string cloudName, string apiKey, string apiSecret);
    }
}
