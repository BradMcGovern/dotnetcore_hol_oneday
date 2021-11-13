// Copyright Information
// ==================================
// AutoLot - AutoLot.Mvc - CarsController.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2021/11/13
// ==================================

namespace AutoLot.Mvc.Controllers;

public class CarsController : BaseCrudController<Car,CarsController>
{
    private readonly IMakeRepo _makeRepo;
    public CarsController(IAppLogging<CarsController> logging,ICarRepo repo, IMakeRepo makeRepo) :base(logging,repo)
    {
        _makeRepo = makeRepo;
    }
    protected override SelectList GetLookupValues()
            => new SelectList(_makeRepo.GetAll(), nameof(Make.Id), nameof(Make.Name));


    [HttpGet("{makeId}/{makeName}")]
    public IActionResult ByMake(int makeId, string makeName)
    {
        ViewBag.MakeName = makeName;
        return View(((ICarRepo)BaseRepoInstance).GetAllBy(makeId));
    }

}