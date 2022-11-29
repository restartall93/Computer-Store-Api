using AutoMapper;
using AutoMapper.Configuration;
using BaseApi.Repositories;
using Computer_Store_Api.Common;
using Computer_Store_Api.Database;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
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
        public ProductController(DatabaseContext databaseContext, ApiOption apiConfig)
        {
            _productRepository = new ProductRepository( apiConfig, databaseContext);
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
    }
}
