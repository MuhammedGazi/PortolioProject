﻿using Microsoft.AspNetCore.Mvc;
using PortolioProject.DAL.Context;

namespace PortolioProject.ViewComponents
{
    public class _FeatureComponentPartial:ViewComponent
    {
        PortfolioContext portfolioContext=new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values=portfolioContext.Features.ToList();
            return View(values);
        }
    }
}
