// Copyright Information
// ==================================
// AutoLot - AutoLot.Mvc - MakesController.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2020/12/13
// ==================================

namespace AutoLot.Mvc.Areas.Admin.Controllers;

[Area("Admin")]
[Route("Admin/[controller]/[action]")]
public class MakesController : BaseCrudController<Make, MakesController>
{
    public MakesController(IAppLogging<MakesController> appLogging, IMakeRepo baseRepo) : base(appLogging, baseRepo)
    {
    }

    protected override SelectList GetLookupValues()
    {
        return null;
    }

    // GET: Admin/Makes
    [Route("/Admin")]
    [Route("/Admin/[controller]")]
    [Route("/Admin/[controller]/[action]")]

    public override IActionResult Index()
    {
        return base.Index();
    }


}