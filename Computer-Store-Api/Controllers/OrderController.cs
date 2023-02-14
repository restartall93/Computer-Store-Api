using AutoMapper;
using AutoMapper.Configuration;
using BaseApi.Repositories;
using Computer_Store_Api.Common;
using Computer_Store_Api.Database;
using Computer_Store_Api.Dto;
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
        OrderDetailRepository _orderDetailRepository;
        OrderRepository _orderRepository;
        IMapper _mapper;

        public OrderController(DatabaseContext databaseContext, ApiOption apiConfig, IMapper mapper)
        {
            _userRepository = new UserRepository( apiConfig, databaseContext);
            _productRepository = new ProductRepository( apiConfig, databaseContext);
            _orderRepository = new OrderRepository( apiConfig, databaseContext);
            _orderDetailRepository = new OrderDetailRepository( apiConfig, databaseContext);
            _mapper = mapper;
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
                var orderList = query.ToList();
                var orderDtoList = orderList.Select(row => _mapper.Map<OrderDto>(row)).ToList();
                foreach (var orderDto in orderDtoList)
                {

                    var orderDetailListByOrder = _orderDetailRepository.FindAll().Where(row => row.OrderId == orderDto.Id).ToList();
                    foreach(var orderDetail in orderDetailListByOrder)
                    {
                        var product = _productRepository.FindOrFail(orderDetail.ProductId);
                        if(product!= null)
                        {
                            orderDto.TotalPrice += product.Price * orderDetail.Quantity;
                        }
                    }
                }
                return new
                {
                    total = total,
                    totalPage = totalPage,
                    orderList = orderDtoList,
                };
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
