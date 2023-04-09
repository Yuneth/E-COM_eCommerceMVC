using AuthorizeNet.Api.Controllers.Bases;
using AuthorizeNet.Api.Contracts.V1;
using AuthorizeNet.Api.Controllers;
using eCommerce.Entities;
using eCommerce.Services;
using eCommerce.Shared.Extensions;
using eCommerce.Shared.Helpers;
using eCommerce.Web.ViewModels;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web;
using eCommerce.Shared.Enums;
using eCommerce.Entities.CustomEntities;
using System.Threading;
using eCommerce.Web.Areas.Dashboard.ViewModels;
//@model eCommerce.Web.Areas.Dashboard.ViewModels.ProductsListingViewModel

namespace eCommerce.Web.Controllers
{
    public class ReportController : Controller
    {
        // GET: Report1
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult PrintProducts(int orderID)
        {
            bool showOnlyLowStock = false;

            ProductsListingViewModel model = new ProductsListingViewModel
            {
                SearchTerm = "",
                ShowOnlyLowStock = showOnlyLowStock,
                Categories = CategoriesService.Instance.GetCategories()
            };
            List<int> selectedCategoryIDs = null;
            model.Products = ProductsService.Instance.SearchProducts(selectedCategoryIDs, null, null, null, null, null, 10, activeOnly: false, out int count, 0);



            return PartialView("_PrintProducts", model);
        }

        public ActionResult PrintOrders(int orderID)
        {
            bool showOnlyLowStock = false;

            ProductsListingViewModel model = new ProductsListingViewModel
            {
                SearchTerm = "",
                ShowOnlyLowStock = showOnlyLowStock,
                Categories = CategoriesService.Instance.GetCategories()
            };
            List<int> selectedCategoryIDs = null;
            model.Products = ProductsService.Instance.SearchProducts(selectedCategoryIDs, null, null, null, null, null, 10, activeOnly: false, out int count, 0);



            return PartialView("_PrintOrders", model);
        }

        public ActionResult PrintCategories(int orderID)
        {
            bool showOnlyLowStock = false;

            ProductsListingViewModel model = new ProductsListingViewModel
            {
                SearchTerm = "",
                ShowOnlyLowStock = showOnlyLowStock,
                Categories = CategoriesService.Instance.GetCategories()
            };
            List<int> selectedCategoryIDs = null;
            model.Products = ProductsService.Instance.SearchProducts(selectedCategoryIDs, null, null, null, null, null, 10, activeOnly: false, out int count, 0);



            return PartialView("_PrintCategories", model);
        }
    }
}