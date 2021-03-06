﻿using AspNetCoreMvcDynamicViews.Views.Shared.Components.DynamicDisplay;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AspNetCoreMvcDynamicViews.Views.Home.ViewComponents
{
    [ViewComponent(Name = "DynamicDisplay")]
    public class DynamicDisplay : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(DynamicDisplayModel dynamicDisplayModel)
        {
            return View(await Task.FromResult(dynamicDisplayModel));
        }
    }
}
