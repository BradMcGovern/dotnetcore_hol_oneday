﻿// Copyright Information
// ==================================
// AutoLot - AutoLot.Mvc - ItemCreateTagHelper.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2021/08/11
// ==================================

namespace AutoLot.Mvc.TagHelpers;

public class ItemCreateTagHelper : ItemLinkTagHelperBase
{
    public ItemCreateTagHelper(IActionContextAccessor contextAccessor, IUrlHelperFactory urlHelperFactory) 
        : base(contextAccessor, urlHelperFactory)
    {
        ActionName = "Create";
    }

    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        BuildContent(output,"text-success","Create New","plus");
    }
}