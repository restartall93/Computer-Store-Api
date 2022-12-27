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
    public class UserController : ControllerBase
    {
        UserRepository _userRepository;
        public UserController(DatabaseContext databaseContext, ApiOption apiConfig)
        {
            _userRepository = new UserRepository( apiConfig, databaseContext);
        }

        /// <summary>
        /// Get achievement list of user
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("UserLogin")]
        public object UserLogin(UserLoginRequest userLoginRequest)
        {
            try
            {
                var user = _userRepository.FindAll().Where(row => row.UserName == userLoginRequest.UserName && row.PassWord == userLoginRequest.PassWord).FirstOrDefault();
                if(user == null)
                {
                    return new
                    {
                        resultLogin = false,
                        userInfor = user,
                        description = "Sai tài khoản hoặc mật khẩu!"
                    };
                }
                return new {
                    resultLogin = true,
                    userInfor = user,
                    description = "Đăng nhập thành công!"
                };
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        [Route("UserRegister")]
        public object UserRegister(UserRegisterRequest userRegisterRequest)
        {
            try
            {
                var userCheck = _userRepository.FindAll().Where(row => row.UserName == userRegisterRequest.Email).FirstOrDefault();
                if(userCheck != null)
                {
                    return new
                    {
                        resultRegister = false,
                        userInfor = userCheck,
                        description = "Email da ton tai"
                    };
                }

                var user = new User()
                {
                    Id = 0,
                    Name = userRegisterRequest.Name,
                    PhoneNumber = userRegisterRequest.PhoneNumber,
                    PassWord = userRegisterRequest.PassWord,
                    Address = "HN",
                    UserName = userRegisterRequest.Email,
                };
                _userRepository.Create(user);
                _userRepository.SaveChange();

                return new
                {
                    resultRegister = true,
                    userInfor = user,
                    description = "Dang ky thanh cong"
                };
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [HttpGet]
        [Route("GetUsers")]
        public object GetUsers()
        {
            try
            {
                return _userRepository.FindAll().ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
