﻿using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.Default
{
    public class _PopularDestinations: ViewComponent
    {
        DestinationManager destinationManager = new 

            DestinationManager(new EFDestinationDal());
        public IViewComponentResult Invoke()
        {
            var values = destinationManager.TGetList();

            return View(values);
        }
    }
}
