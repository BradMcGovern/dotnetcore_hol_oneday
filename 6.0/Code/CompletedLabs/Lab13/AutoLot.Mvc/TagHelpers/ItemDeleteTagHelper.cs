﻿// Copyright Information
// ==================================
// AutoLot - AutoLot.Mvc - ItemDeleteTagHelper.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2021/08/11
// ==================================

namespace AutoLot.Mvc.TagHelpers;

public class ItemDeleteTagHelper : ItemLinkTagHelperBase
{

    public ItemDeleteTagHelper(IActionContextAccessor contextAccessor, IUrlHelperFactory urlHelperFactory)
        : base(contextAccessor, urlHelperFactory)
    {
        ActionName = "Delete";
    }

    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        //    <a asp-action="Details" asp-route-id="@item.Id" class="text-info">Details <i class="fas fa-info-circle"></i></a>&nbsp;&nbsp;|&nbsp;&nbsp;
        BuildContent(output,"text-danger","Delete","trash");
    }
}