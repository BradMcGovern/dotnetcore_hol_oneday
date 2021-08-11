﻿// Copyright Information
// ==================================
// AutoLot - AutoLot.Dal - OrderRepo.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2021/08/11
// ==================================

using AutoLot.Dal.EfStructures;
using AutoLot.Models.Entities;
using AutoLot.Dal.Repos.Base;
using AutoLot.Dal.Repos.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AutoLot.Dal.Repos
{
    public class OrderRepo : BaseRepo<Order>, IOrderRepo
    {
        public OrderRepo(ApplicationDbContext context) : base(context)
        {
        }

        internal OrderRepo(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
    }
}