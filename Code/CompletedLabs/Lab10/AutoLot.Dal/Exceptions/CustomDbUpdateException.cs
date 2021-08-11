﻿// Copyright Information
// ==================================
// AutoLot - AutoLot.Dal - CustomDbUpdateException.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2021/08/11
// ==================================

using Microsoft.EntityFrameworkCore;

namespace AutoLot.Dal.Exceptions
{
    public class CustomDbUpdateException : CustomException
    {
        public CustomDbUpdateException()
        {
        }

        public CustomDbUpdateException(string message) : base(message)
        {
        }

        public CustomDbUpdateException(string message, DbUpdateException innerException)
            : base(message, innerException)
        {
        }
    }
}