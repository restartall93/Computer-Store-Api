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
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using NetTopologySuite.Operation.Valid;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Net.Http;

namespace BaseApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [AllowAnonymous]
    public class ProductHandleController : ControllerBase
    {
        ProductRepository _productRepository;
        CartRepository _cartRepository;
        CartDetailRepository _cartDetailRepository;
        OrderRepository _orderRepository;
        OrderDetailRepository _orderDetailRepository;
        IMapper _mapper;
        public ProductHandleController(DatabaseContext databaseContext, ApiOption apiConfig, IMapper mapper)
        {
            _productRepository = new ProductRepository( apiConfig, databaseContext);
            _cartRepository = new CartRepository( apiConfig, databaseContext);
            _cartDetailRepository = new CartDetailRepository( apiConfig, databaseContext);
            _orderDetailRepository = new OrderDetailRepository( apiConfig, databaseContext);
            _orderRepository = new OrderRepository( apiConfig, databaseContext);
            _mapper = mapper;
        }

        /// <summary>
        /// Get achievement list of user
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetCartDetailList")]
        public object GetCartDetailList(int userID)
        {
            try
            {
                var cart = _cartRepository.FindAll().Where(cart => cart.UserId == userID).FirstOrDefault();
                var cartDetailList = _cartDetailRepository.FindAll().Where(cartDetail => cartDetail.CartId == cart.Id).ToList();
                var cartDetailDtoList = cartDetailList.Select(cartDetail => _mapper.Map<CartDetailDto>(cartDetail)).ToList();
                foreach(var cartDetailDto in cartDetailDtoList)
                {
                    var product = _productRepository.FindOrFail(cartDetailDto.ProductId);
                    if(product != null)
                    {
                        cartDetailDto.Name = product.Name;
                        cartDetailDto.Price = product.Price;
                        cartDetailDto.Image = product.Image;
                        cartDetailDto.Description = product.Description;
                        cartDetailDto.CPU = product.CPU;
                        cartDetailDto.RAM = product.RAM;
                        cartDetailDto.VGA = product.VGA;
                        cartDetailDto.Monitor = product.Monitor;
                    }
                }
                return cartDetailDtoList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Add product to cart user
        /// </summary>
        /// <param name="addtoCartRequest"></param>
        /// <returns>cartDetail</returns>
        [HttpPost]
        [Route("AddToCart")]
        public object AddToCart(AddtoCartRequest addtoCartRequest)
        {
            try
            {
                // find cart in db
                var cart = _cartRepository.FindAll().Where(cart => cart.UserId == addtoCartRequest.UserId).FirstOrDefault();
                
                // check if cart does not exist then create new cart
                if (cart == null)
                {
                    cart = new Cart()
                    {
                        Id = 0,
                        UserId = addtoCartRequest.UserId,
                        Quantity = 0,
                    };
                    _cartRepository.Create(cart);
                    _cartRepository.SaveChange();
                }

                // get cart detail in db by cart id and product id
                var cartDetail = _cartDetailRepository.FindByCondition(row => row.CartId == cart.Id && row.ProductId == addtoCartRequest.ProductId).FirstOrDefault();
                
                // check if cart detail does not exist then create new
                if(cartDetail == null)
                {
                    cartDetail = new CartDetail()
                    {
                        CartId = cart.Id,
                        ProductId = addtoCartRequest.ProductId,
                        Quantity = 1,
                    };
                    _cartDetailRepository.Create(cartDetail);
                    _cartDetailRepository.SaveChange();
                }
                // update quantity plus 1
                else
                {
                    cartDetail.Quantity++;
                    _cartDetailRepository.UpdateByEntity(cartDetail);
                    _cartDetailRepository.SaveChange();
                }

                // return result
                return cartDetail;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Order product
        /// </summary>
        /// <param name="UserId"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("OrderProduct")]
        public object OrderProduct(int UserId)
        {
            try
            {
                var cart = _cartRepository.FindByCondition(row => row.UserId == UserId).FirstOrDefault();
                //Get cart detail list by user
                var cartDetailList = _cartDetailRepository.FindAll().Where(row => row.CartId == cart.Id).ToList();
                //kiểm tra nếu danh sách cart detail có >= 1 thì đi tiếp còn không thống báo
                if( cartDetailList.Count == 0)
                {
                    return false;
                }
                else
                {
                    // nếu oke thì tạo order mới và tạo toàn bộ order detail theo danh sách cart detail
                    var oder = new Order()
                    {
                        Id = 0,
                        UserId = UserId,
                        Quantity = cartDetailList.Count,
                    };
                    _orderRepository.Create(oder);
                    _orderRepository.SaveChange();

                    foreach(var cartDetail in cartDetailList)
                    {
                        var orderDetail = new OrderDetail()
                        {
                            Id = 0,
                            OrderId = oder.Id,
                            ProductId = cartDetail.ProductId,
                            Quantity = cartDetail.Quantity,
                        };
                        _orderDetailRepository.Create(orderDetail);
                    }
                    _orderDetailRepository.SaveChange();


                    //xoá đi toàn bộ danh sách cartdetail
                    foreach (var cartDetail in cartDetailList)
                    {
                        _cartDetailRepository.DeleteByEntity(cartDetail);
                    }
                    _cartDetailRepository.SaveChange();

                }

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
