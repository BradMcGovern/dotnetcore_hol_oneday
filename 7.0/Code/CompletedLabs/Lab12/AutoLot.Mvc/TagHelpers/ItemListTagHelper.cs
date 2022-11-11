﻿// Copyright Information
// ==================================
// AutoLot70 - AutoLot.Mvc - ItemListTagHelper.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2022/11/10
// ==================================

namespace AutoLot.Mvc.TagHelpers;

public class ItemListTagHelper : ItemLinkTagHelperBase
{
    public ItemListTagHelper(IActionContextAccessor contextAccessor, IUrlHelperFactory urlHelperFactory) : base(contextAccessor, urlHelperFactory)
    {
        ActionName = nameof(CarsController.Index);
    }

    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        BuildContent(output,"text-default","Back to List","list");
    }
}