﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Student_Evaluation_3.Data;
using Student_Evaluation_3.Security;
using Student_Evaluation_3.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace Student_Evaluation_3.Controllers
{
    public class AdminController : Controller
    {
        private SchoolContext db;
        public AdminController(SchoolContext context)
        {
            db = context;
        }
        [HttpGet]
        public IActionResult CreateStudent()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateStudent(Student input)
        {
            db.Students.Add(input);
            db.SaveChangesAsync();
            return View();
        }

        [HttpPost]
        public IActionResult Toolbar()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CreateInstructor()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateInstructor(Instructor instructor)
        {
            db.Instructors.Add(instructor);
            db.SaveChangesAsync();
            return View();
        }
    }
}