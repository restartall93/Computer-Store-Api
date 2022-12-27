using AutoMapper;
using BaseApi.Respositories;
using Computer_Store_Api.Common;
using Computer_Store_Api.Database;
using Computer_Store_Api.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace BaseApi.Repositories
{
    public class OrderDetailRepository : BaseRepository<OrderDetail>
    {
        public OrderDetailRepository(ApiOption apiConfig, DatabaseContext databaseContext) : base(apiConfig, databaseContext)
        {
        }
    }
}
