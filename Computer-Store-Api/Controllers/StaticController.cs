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
    public class StaticController : ControllerBase
    {
        UserRepository _userRepository;
        ProductRepository _productRepository;
        OrderRepository _orderRepository;
        public StaticController(DatabaseContext databaseContext, ApiOption apiConfig)
        {
            _userRepository = new UserRepository( apiConfig, databaseContext);
            _productRepository = new ProductRepository( apiConfig, databaseContext);
            _orderRepository = new OrderRepository( apiConfig, databaseContext);
        }

        /// <summary>
        /// Get achievement list of user
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("Dashboard")]
        public object Dashboard()
        {
            try
            {
                var totalUser = _userRepository.FindAll().Count();
                var totalOrder = _orderRepository.FindAll().Count();
                var totalProduct = _productRepository.FindAll().Count();
                return new
                {
                    totalUser = totalUser,
                    totalOrder = totalOrder,
                    totalProduct = totalProduct,
                };
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
