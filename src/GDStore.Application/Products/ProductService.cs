using GDStore.Application.Exceptions;
using GDStore.Application.Interfaces;
using GDStore.Domain.Entities;
using GDStore.ViewModel.Products;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace GDStore.Application.Products
{
    public class ProductService : IProductService
    {
        private readonly IStorageService _storageService;
        private readonly IUnitOfWork _unitOfWork;
        public ProductService(IStorageService storageService, IUnitOfWork unitOfWork)
        {
            _storageService = storageService;
            _unitOfWork = unitOfWork;
        }
        public async Task Add(ProductCreateRequest request)
        {
            var product = new Product();
            product.Name = request.Name;
            product.Price = request.Price;
            product.OriginalPrice = request.OriginalPrice;
            product.Description = request.Description;
            product.BrandId = request.BrandId;
            product.CreatedDate = DateTime.Now;

            if (request.ThumbnailImage.Count == 0)
            {
                var productImages = new List<ProductImage>();
                foreach (var i in request.ThumbnailImage)
                {
                    productImages.Add(
                        new ProductImage()
                        {
                            Description = "Thumbnai Image",
                            CreatedDate = DateTime.Now,
                            Url = await this.SaveFile(i),
                            IsDefault = true
                        }
                    );
                }
            }

            await _unitOfWork.Products.Add(product);
            await _unitOfWork.SaveChangeAsync();
        }

        public async Task Delete(int id)
        {
            var product = await _unitOfWork.Products.FirstOrDefaultAsync(x => x.Id == id);
            if (product == null)
            {
                throw new NotFoundException(nameof(Product), id);
            }

            _unitOfWork.Products.Remove(product);
            await _unitOfWork.SaveChangeAsync();
        }

        public async Task<ProductVm> GetById(int id)
        {
            var product = await _unitOfWork.Products.FirstOrDefaultAsync(c => c.Id == id);
            if (product == null)
            {
                throw new NotFoundException(nameof(Product), id);
            }
            var productVm = new ProductVm
            {
                Id = product.Id,
                Name = product.Name,
                OriginalPrice = product.OriginalPrice,
                Price = product.Price,
                Description = product.Description,
                CreatedDate = product.CreatedDate,
                Rating = product.Rating,
                ThumbnailImage = product.ProductImages.Where(x => x.ProductId == product.Id).Select(x => x.Url).ToList(),
            };

            return productVm;
        }
        public async Task<IEnumerable<ProductVm>> GetProducts()
        {
            var products = await _unitOfWork.Products.GetAllAsync();
            var productVm = products.Select(c => new ProductVm
            {
                Id = c.Id,
                Name = c.Name,
                OriginalPrice = c.OriginalPrice,
                Price = c.Price,
                Description = c.Description,
                CreatedDate = c.CreatedDate,
                Rating = c.Rating,
                ThumbnailImage = c.ProductImages.Where(x => x.ProductId == c.Id).Select(x => x.Url).ToList(),
            });

            return productVm;
        }

        public async Task Update(ProductUpdateRequest request)
        {
            var product = await _unitOfWork.Products.FirstOrDefaultAsync(x => x.Id == request.Id);
            if(product == null)
            {
                throw new NotFoundException(nameof(Product), request.Id);
            }
            product.Name = request.Name;
            product.Price = request.Price;
            product.OriginalPrice = request.OriginalPrice;
            product.Description = request.Description;
            product.BrandId = request.BrandId;
            product.CreatedDate = DateTime.Now;

            if (request.ThumbnailImage.Count == 0)
            {
                var productImages = new List<ProductImage>();
                foreach (var i in request.ThumbnailImage)
                {
                    productImages.Add(
                        new ProductImage()
                        {
                            Description = "Thumbnai Image",
                            CreatedDate = DateTime.Now,
                            Url = await this.SaveFile(i),
                            IsDefault = true
                        }
                    );
                }
            }

            _unitOfWork.Products.Update(product);
            await _unitOfWork.SaveChangeAsync();
        }
        private async Task<string> SaveFile(IFormFile file)
        {
            var originalFileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');

            var fileName = $"{Guid.NewGuid()}{Path.GetExtension(originalFileName)}";

            await _storageService.SaveFileAsync(file.OpenReadStream(), fileName);

            return fileName;
        }
    }
}
