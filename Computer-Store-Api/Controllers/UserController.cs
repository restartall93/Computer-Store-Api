using AutoMapper;
using AutoMapper.Configuration;
using BaseApi.Repositories;
using Computer_Store_Api.Common;
using Computer_Store_Api.Database;
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
                        description = "Sai"
                    };
                }
                return new {
                    resultLogin = true,
                    userInfor = user,
                    description = "Dung"
                };
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
