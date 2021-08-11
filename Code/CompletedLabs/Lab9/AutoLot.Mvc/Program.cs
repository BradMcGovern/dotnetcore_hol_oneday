// Copyright Information
// ==================================
// AutoLot - AutoLot.Mvc - Program.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2021/08/11
// ==================================

using AutoLot.Mvc;
using AutoLot.Services.Logging;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

CreateHostBuilder(args).Build().Run();

static IHostBuilder CreateHostBuilder(string[] args) =>
    Host.CreateDefaultBuilder(args)
        .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); })
        .ConfigureSerilog();