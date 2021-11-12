// Copyright Information
// ==================================
// AutoLot - AutoLot.Mvc - ItemLinkTagHelperBase.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2021/08/11
// ==================================

namespace AutoLot.Mvc.TagHelpers.Base;

public abstract class ItemLinkTagHelperBase : TagHelper
{
    protected readonly IUrlHelper UrlHelper;
    public int? ItemId { get; set; }
    protected string ControllerName { get; set; }
    protected string ActionName { get; set; }

    protected ItemLinkTagHelperBase(IActionContextAccessor contextAccessor, IUrlHelperFactory urlHelperFactory)
    {
        UrlHelper = urlHelperFactory.GetUrlHelper(contextAccessor.ActionContext);
        ControllerName = contextAccessor.ActionContext.ActionDescriptor.RouteValues["controller"];
    }

    protected void BuildContent(TagHelperOutput output,string className, string displayText, string fontAwesomeName)
    {
        output.TagName = "a"; // Replaces <email> with <a> tag
        var target = (ItemId.HasValue)
            ? UrlHelper.Action(ActionName, ControllerName, new {id = ItemId})
            : UrlHelper.Action(ActionName, ControllerName);
        output.Attributes.SetAttribute("href", target);
        output.Attributes.Add("class",className);
        output.Content.AppendHtml($@"{displayText} <i class=""fas fa-{fontAwesomeName}""></i>");
    }
}