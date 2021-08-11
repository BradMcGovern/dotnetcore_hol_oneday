﻿// Copyright Information
// ==================================
// AutoLot - AutoLot.Dal - IMakeRepo.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2021/08/11
// ==================================

using System.Collections.Generic;
using AutoLot.Models.Entities;
using AutoLot.Dal.Repos.Base;

namespace AutoLot.Dal.Repos.Interfaces
{
    public interface IMakeRepo : IRepo<Make>
    {
        IEnumerable<Make> GetOrderByMake();
    }
}