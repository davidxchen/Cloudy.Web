﻿using Cloudy.CMS.SingletonSupport;
using CloudyWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CloudyWeb.Controllers
{
    public class ContentController : Controller
    {
        ISingletonGetter SingletonGetter { get; }

        public ContentController(ISingletonGetter singletonGetter)
        {
            SingletonGetter = singletonGetter;
        }

        public ActionResult StartPage()
        {
            var page = SingletonGetter.Get<StartPage>(null);

            return Content(page.Name);
        }
    }
}
