﻿// Copyright Information
// ==================================
// AutoLot70 - AutoLot.Mvc - ItemDeleteTagHelper.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2022/11/10
// ==================================

namespace AutoLot.Mvc.TagHelpers;

public class ItemDeleteTagHelper : ItemLinkTagHelperBase
{
    public ItemDeleteTagHelper(IActionContextAccessor contextAccessor, IUrlHelperFactory urlHelperFactory) : base(contextAccessor, urlHelperFactory)
    {
        ActionName = nameof(CarsController.Delete); 
    }

    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        //    <a asp-action="Details" asp-route-id="@item.Id" class="text-info">Details <i class="fas fa-info-circle"></i></a>&nbsp;&nbsp;|&nbsp;&nbsp;
        BuildContent(output,"text-danger","Delete","trash");
    }
}