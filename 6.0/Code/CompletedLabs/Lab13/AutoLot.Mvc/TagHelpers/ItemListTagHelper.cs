﻿// Copyright Information
// ==================================
// AutoLot - AutoLot.Mvc - ItemListTagHelper.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2021/08/11
// ==================================

namespace AutoLot.Mvc.TagHelpers;

public class ItemListTagHelper : ItemLinkTagHelperBase
{
    public ItemListTagHelper(IActionContextAccessor contextAccessor, IUrlHelperFactory urlHelperFactory)
        : base(contextAccessor, urlHelperFactory)
    {
        ActionName = "Index";
    }

    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        BuildContent(output,"text-default","Back to List","list");
    }
}