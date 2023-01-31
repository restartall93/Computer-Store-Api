using AutoMapper;
using AutoMapper.Configuration;
using BaseApi.Repositories;
using Computer_Store_Api.Common;
using Computer_Store_Api.Database;
using Computer_Store_Api.Models;
using Computer_Store_Api.Request;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
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
    public class OrderController : ControllerBase
    {
        UserRepository _userRepository;
        ProductRepository _productRepository;
        OrderRepository _orderRepository;
        public OrderController(DatabaseContext databaseContext, ApiOption apiConfig)
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
        [Route("GetOrders")]
        public object GetOrders(int limit, int page)
        {
            try
            {
                var query = _orderRepository.FindAll();
                query = query.Skip((page - 1) * limit).Take(limit);

                var total = _orderRepository.FindAll().Count();
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
                    orderList = query.ToList(),
                };
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
