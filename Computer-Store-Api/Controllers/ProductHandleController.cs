using AutoMapper;
using AutoMapper.Configuration;
using BaseApi.Repositories;
using Computer_Store_Api.Common;
using Computer_Store_Api.Database;
using Computer_Store_Api.Dto;
using Computer_Store_Api.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
    public class ProductHandleController : ControllerBase
    {
        ProductRepository _productRepository;
        CartRepository _cartRepository;
        CartDetailRepository _cartDetailRepository;
        IMapper _mapper;
        public ProductHandleController(DatabaseContext databaseContext, ApiOption apiConfig, IMapper mapper)
        {
            _productRepository = new ProductRepository( apiConfig, databaseContext);
            _cartRepository = new CartRepository( apiConfig, databaseContext);
            _cartDetailRepository = new CartDetailRepository( apiConfig, databaseContext);
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
    }
}
