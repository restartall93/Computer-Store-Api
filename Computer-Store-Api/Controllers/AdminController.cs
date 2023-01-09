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
    public class AdminController : ControllerBase
    {
        UserRepository _userRepository;
        AdminRepository _adminRepository;
        public AdminController(DatabaseContext databaseContext, ApiOption apiConfig)
        {
            _userRepository = new UserRepository( apiConfig, databaseContext);
            _adminRepository = new AdminRepository( apiConfig, databaseContext);
        }

        /// <summary>
        /// Get achievement list of user
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("AdminLogin")]
        public object AdminLogin(UserLoginRequest adminLoginRequest)
        {
            try
            {
                var admin = _adminRepository.FindAll().Where(row => row.UserName == adminLoginRequest.UserName && row.PassWord == adminLoginRequest.PassWord).FirstOrDefault();
                if(admin == null)
                {
                    return new
                    {
                        resultLogin = false,
                        adminInfor = admin,
                        description = "Sai tài khoản hoặc mật khẩu!"
                    };
                }
                return new {
                    resultLogin = true,
                    adminInfor = admin,
                    description = "Đăng nhập thành công!"
                };
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
