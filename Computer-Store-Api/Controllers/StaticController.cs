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
        OrderDetailRepository _orderDetailRepository;
        public StaticController(DatabaseContext databaseContext, ApiOption apiConfig)
        {
            _userRepository = new UserRepository( apiConfig, databaseContext);
            _productRepository = new ProductRepository( apiConfig, databaseContext);
            _orderRepository = new OrderRepository( apiConfig, databaseContext);
            _orderDetailRepository = new OrderDetailRepository( apiConfig, databaseContext);
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
                var totalProductSold = _orderDetailRepository.FindAll().Sum(row => row.Quantity);

                var toDay = DateTime.Now;
                var numberOrderDetail = new List<int>();
                for (int i = 7; i >= 1; i--)
                {
                    var date = toDay.AddDays(-i);
                    var start = new DateTime(date.Year, date.Month, date.Day);
                    var finish = start.AddDays(1);
                    var orderList = _orderRepository.FindByCondition(row => row.CreatedDate >= start && row.CreatedDate <= finish).ToList();
                    var orderIdList = orderList.Select(row => row.Id).ToList();
                    var number = _orderDetailRepository.FindByCondition(row => orderIdList.Contains(row.OrderId)).Sum(row => row.Quantity);
                    numberOrderDetail.Add(number);
                }

                return new
                {
                    totalUser = totalUser,
                    totalOrder = totalOrder,
                    totalProduct = totalProduct,
                    totalProductSold = totalProductSold,
                    numberOrderDetail = numberOrderDetail,
                };
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
