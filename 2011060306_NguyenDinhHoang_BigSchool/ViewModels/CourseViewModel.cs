﻿using _2011060306_NguyenDinhHoang_BigSchool.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _2011060306_NguyenDinhHoang_BigSchool.ViewModels
{
    public class CourseViewModel
    {

        [Required]
        public String Place { get; set; }


        [Required]
        [FutureDate]
        public String Date { get; set; }


        [Required]
        [ValidTime]
        public String Time { get; set; }

        [Required]
        public byte Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public DateTime GetDateTme()
        {
            return DateTime.Parse(string.Format("{0} {1}", Date, Time));
        }


    }
}