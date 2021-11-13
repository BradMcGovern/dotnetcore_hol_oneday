﻿// Copyright Information
// ==================================
// AutoLot - AutoLot.Models - Person.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2021/11/06
// ==================================

namespace AutoLot.Models.Entities.Owned;

[Owned]
public class Person
{
    [Required, StringLength(50)]
    public string FirstName { get; set; }

    [Required, StringLength(50)]
    public string LastName { get; set; }

    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public string FullName { get; set; }
}
