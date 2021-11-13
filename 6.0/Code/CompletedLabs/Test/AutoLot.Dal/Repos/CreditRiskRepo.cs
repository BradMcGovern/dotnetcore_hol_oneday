﻿// Copyright Information
// ==================================
// AutoLot - AutoLot.Dal - CreditRiskRepo.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2021/11/12
// ==================================

namespace AutoLot.Dal.Repos;

public class CreditRiskRepo : BaseRepo<CreditRisk>, ICreditRiskRepo
{
    public CreditRiskRepo(ApplicationDbContext context) : base(context)
    {
    }

    internal CreditRiskRepo(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }
}