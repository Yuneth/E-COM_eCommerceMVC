﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eCommerce.Web.Areas.Dashboard.Controllers
{
    public class ReportController : DashboardBaseController
    {
        // GET: Dashboard/Report
        public ActionResult Index()
        {
            return View();
        }
    }
}