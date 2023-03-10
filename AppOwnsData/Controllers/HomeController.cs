// ----------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.
// ----------------------------------------------------------------------------

namespace AppOwnsData.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Reporting.WebForms;
    using System;

    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
