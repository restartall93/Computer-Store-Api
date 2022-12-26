using AutoMapper;
using AutoMapper.Configuration;
using BaseApi.Repositories;
using Computer_Store_Api.Common;
using Computer_Store_Api.Database;
using Computer_Store_Api.Models;
using Computer_Store_Api.Request;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using NetTopologySuite.Operation.Valid;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace BaseApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [AllowAnonymous]
    public class ProductController : ControllerBase
    {
        ProductRepository _productRepository;
        IMapper _mapper;
        public ProductController(DatabaseContext databaseContext, ApiOption apiConfig, IMapper mapper)
        {
            _productRepository = new ProductRepository( apiConfig, databaseContext);
            _mapper = mapper;
        }

        /// <summary>
        /// Get achievement list of user
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetProducts")]
        public object GetProducts()
        {
            try
            {
                return _productRepository.FindAll().ToList();
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
                _productRepository.Create(product);
                _productRepository.SaveChange();
                return product;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
