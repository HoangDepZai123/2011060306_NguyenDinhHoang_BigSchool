﻿using _2011060306_NguyenDinhHoang_BigSchool.Models;
using _2011060306_NguyenDinhHoang_BigSchool.ViewModels;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace _2011060306_NguyenDinhHoang_BigSchool.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _dbContext;
        public HomeController()
        {
            _dbContext = new ApplicationDbContext();
        }
        public ActionResult Index()
        {
            var upcommingCourses = _dbContext.Courses
                                        .Include(c => c.Lecturer)
                                        .Include(c => c.Category)                                     
                                        .Where(c => c.DateTime > DateTime.Now);

            var viewModel = new CoursesViewModel
            {
                UpcomingCourses= upcommingCourses,
                ShowAction =User.Identity.IsAuthenticated
            };
 

            return View(viewModel);
        }
 

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}