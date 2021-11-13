namespace AutoLot.Mvc.ViewComponents;

public class MenuViewComponent : ViewComponent
{
    private readonly IMakeRepo _makeRepo;
    public MenuViewComponent(IMakeRepo makeRepo)
    {
        _makeRepo = makeRepo;
    }
    //public IViewComponentResult Invoke()
    //{
    //    var makes = _makeRepo.GetAll().ToList();
    //    if (!makes.Any())
    //    {
    //        return new ContentViewComponentResult("Unable to get the makes");
    //    }
    //    return View("MenuView", makes);
    //}

    public async Task<IViewComponentResult> InvokeAsync()
    {
        return await Task.Run<IViewComponentResult>(() =>
        {
            var makes = _makeRepo.GetAll();
            if (makes == null)
            {
                return new ContentViewComponentResult("Unable to get the makes");
            }
            return View("MenuView", makes);
        });
    }

}