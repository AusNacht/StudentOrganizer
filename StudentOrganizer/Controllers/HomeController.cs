using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OfficeOpenXml;
using StudentOrganizer.Models;
using StudentOrganizer.Services;
using StudentOrganizer.Services.Interfaces;

namespace StudentOrganizer.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [ActionName("UploadStudents")]
        [HttpGet]
        public IActionResult UploadStudents(string path = "~/Content/SampleData.xlsx")
        {
            // Turn into datatable

            // FIXME: I am using a mac and there's most people use EPPlus to convert an XLSX file to a DataTable:
            //      a) ToDataTable method
            //      b) package.Workbooks.Workbooks.First
            //      c) package.Workbooks.Workbook[0]
            //      d) package.Workbooks.Workbook[1]
            //      e) package.Workbooks.Workbook["Sheet1"]
            // I tried all these solutions and several others. I left the converter I wrote so you could see what I planned on doing.

            // FileInfo fi = new FileInfo(path);
            // ExcelPackage package = new ExcelPackage(fi);
            // DataTable Dt = ToDataTable(package);

            return RedirectToAction("StudentView", "Student");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
