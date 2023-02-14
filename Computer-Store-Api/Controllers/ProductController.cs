using AutoMapper;
using BaseApi.Repositories;
using Computer_Store_Api.Common;
using Computer_Store_Api.Database;
using Computer_Store_Api.Models;
using Computer_Store_Api.Request;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace BaseApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [AllowAnonymous]
    public class ProductController : ControllerBase
    {
        ProductRepository _productRepository;
        IWebHostEnvironment _webHost;
        IMapper _mapper;
        public ProductController(DatabaseContext databaseContext, ApiOption apiConfig, IMapper mapper, IWebHostEnvironment webHost)
        {
            _productRepository = new ProductRepository( apiConfig, databaseContext);
            _webHost = webHost;
            _mapper = mapper;
        }

        /// <summary>
        /// Get achievement list of user
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetProducts")]
        public object GetProducts(int limit, int page, string? name)
        {
            try
            {
                var query = _productRepository.FindAll();

                if(!string.IsNullOrEmpty(name))
                {
                    query = query.Where(row => row.Name.Contains(name));
                }

                query = query.Skip((page - 1) * limit).Take(limit);

                var total = _productRepository.FindAll().Count();
                var totalPage = 0;
                if ((double)total / limit > (int)((double)total / limit))
                {
                    totalPage = total / limit + 1;
                }
                else
                {
                    totalPage = total / limit;
                }

                return new
                {
                    total = total,
                    totalPage = totalPage,
                    productList = query.ToList(),
                };
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet]
        [Route("GetProductListByCategory")]
        public object GetProductListByCategory(string productType)
        {
            try
            {
                //var allProduct = _productRepository.FindAll().ToList();
                //var listProduct = new List<Product>();
                //for(int i=0; i<allProduct.Count-1; i++)
                //{
                //    if (allProduct[i].ProductType == productType)
                //    {
                //        listProduct.Add(allProduct[i]);
                //    }
                //}
                //return listProduct;
                return _productRepository.FindByCondition(row => row.ProductType == productType).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Get achievement list of user
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetDetail")]
        public object GetDetail(int id)
        {
            try
            {
                return _productRepository.FindAll().Where(row=> row.Id ==id).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Get achievement list of user
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("AddProduct")]
        public object AddProduct(AddProductRequest addProductRequest)
        {
            try
            {
                var product = _mapper.Map<Product>(addProductRequest);
                if(product != null)
                {
                    product.Image = "/product/" + product.Image;
                    _productRepository.Create(product);
                    _productRepository.SaveChange();
                    return product;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// post image
        /// </summary>
        /// <param name="image"></param>
        /// <returns></returns>
        [HttpPost]
        [AllowAnonymous]
        [Route("PostImage")]
        public object PostImage(IFormFile image)
        {
            try
            {
                if (image == null)
                {
                    return new
                    {
                        result = false
                    };
                }

                using (FileStream fileStream = System.IO.File.Create(_webHost.WebRootPath + "\\product\\" + image.FileName))
                {
                    image.CopyTo(fileStream);
                    fileStream.Flush();
                    return new
                    {
                        result = true
                    };
                }

                return false;
            }
            catch (Exception ex)
            {
                return new
                {
                    result = false
                };
            }
        }

    }
}
