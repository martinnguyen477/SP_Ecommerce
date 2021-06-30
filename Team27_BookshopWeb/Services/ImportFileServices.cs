using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Team27_BookshopWeb.Entities;
using Team27_BookshopWeb.Models;

namespace Team27_BookshopWeb.Services
{
    public class ImportFileServices : IImportFileServices
    {
        #region Contructors, Vabiable, Dipose
        private readonly MyDbContext _myDbContext;
        private Cloudinary _cloudinary;

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportFileServices"/> class.
        /// ImportFileServices.
        /// </summary>
        /// <param name="mapper">mapper.</param>
        public ImportFileServices(MyDbContext myDbContext)
        {
            _myDbContext = myDbContext;
        }

        #endregion Contructors, Vabiable, Dipose

        #region Upload Image To Cloud

        /// <summary>
        /// Hàm upload image to cloud.
        /// </summary>
        /// <param name="formFile">File ảnh.</param>
        /// <param name="cloudName">tên cloud.</param>
        /// <param name="apiKey">api key</param>
        /// <param name="apiSecret">api secrect.</param>
        /// <returns>Model ResponseUploadImageCloud chứa 2 trường là publicId và urlimage.</returns>
        public async Task<ResponseUploadImageCloud> AddPhotoCloudAsync(IFormFile formFile, string cloudName, string apiKey, string apiSecret)
        {
            //Khởi tạo account connect đến cloud.
            var accountCloud = new Account(cloudName, apiKey, apiSecret);
            _cloudinary = new Cloudinary(accountCloud);

            //Khởi tạo kết quả sau khi upload image to cloud.
            var uploadResult = new ImageUploadResult();

            if (formFile.Length > 0)
            {
                using var streams = formFile.OpenReadStream();
                //Lấy thông số hình ảnh.
                var uploadParams = new ImageUploadParams
                {
                    File = new FileDescription(formFile.FileName, streams),
                    Transformation = new Transformation().Height(1000).Width(1000).Crop("fill").Gravity("face"),
                    //test thử
                    //PublicId = "myfolder/mysubfolder/Category"
                };

                //Up load lên cloud.
                uploadResult = await _cloudinary.UploadAsync(uploadParams);
            }

            //trả giá trị sau khi upload hình ảnh vào model.
            var resultData = new ResponseUploadImageCloud()
            {
                UrlImage = uploadResult.SecureUrl.AbsoluteUri,
                PublicId = uploadResult.PublicId
            };
            return resultData;
        }
        #endregion

        #region Delete Photo in Cloud.

        /// <summary>
        /// Phương thức xóa hình ảnh trên cloud. 
        /// </summary>
        /// <param name="publicId"></param>
        /// <param name="cloudName"></param>
        /// <param name="apiKey"></param>
        /// <param name="apiSecret"></param>
        /// <returns></returns>
        public async Task<DeletionResult> DeleteImageAsync(string publicId, string cloudName, string apiKey, string apiSecret)
        {
            //Khởi tạo account cloud.
            var accountCloud = new Account(cloudName, apiKey, apiSecret);
            _cloudinary = new Cloudinary(accountCloud);
            //Lấy tham số của hình .
            var deleteParams = new DeletionParams(publicId);
            //Xóa hình.
            var result = await _cloudinary.DestroyAsync(deleteParams);
            return result;
        }

        #endregion
    }
}
