﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using JobRegistrationSubmisson.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace WebClient.Controllers
{
    public class EmployeesController : Controller
    {
        readonly HttpClient client = new HttpClient
        {
            BaseAddress = new Uri("https://localhost:44303/api/")
        };

        public IActionResult Index()
        {
            return View("~/Views/Employees/Index.cshtml");
        }

        public IActionResult LoadJobSeeker()
        {
            IEnumerable<JobSeekerVM> emp = null;
            //var token = HttpContext.Session.GetString("token");
            //client.DefaultRequestHeaders.Add("Authorization", token);
            var resTask = client.GetAsync("jobseekers");
            resTask.Wait();

            var result = resTask.Result;
            if (result.IsSuccessStatusCode)
            {
                var readTask = result.Content.ReadAsAsync<List<JobSeekerVM>>();
                readTask.Wait();
                emp = readTask.Result;
            }
            else
            {
                emp = Enumerable.Empty<JobSeekerVM>();
                ModelState.AddModelError(string.Empty, "Server Error try after sometimes.");
            }
            return Json(emp);

        }

        public IActionResult GetById(string Id)
        {
            JobSeekerVM emp = null;
            //var token = HttpContext.Session.GetString("token");
            //client.DefaultRequestHeaders.Add("Authorization", token);
            var resTask = client.GetAsync("jobseekers/" + Id);
            resTask.Wait();

            var result = resTask.Result;
            if (result.IsSuccessStatusCode)
            {
                var json = JsonConvert.DeserializeObject(result.Content.ReadAsStringAsync().Result).ToString();
                emp = JsonConvert.DeserializeObject<JobSeekerVM>(json);
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Server Error.");
            }
            return Json(emp);
        }

        public IActionResult Delete(string id)
        {
            //var token = HttpContext.Session.GetString("token");
            //client.DefaultRequestHeaders.Add("Authorization", token);
            var result = client.DeleteAsync("jobseekers/" + id).Result;
            return Json(result);
        }

        public IActionResult Approve(UserVM userVM)
        {
            var json = JsonConvert.SerializeObject(userVM);
            var buffer = System.Text.Encoding.UTF8.GetBytes(json);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            HttpResponseMessage result = null;
            if (userVM.Id != null)
            {
                result = client.PostAsync("employees/Approve/", byteContent).Result;
                return Json(result);
            }
            return Json(404);
        }

        public IActionResult Reject(UserVM userVM)
        {
            var json = JsonConvert.SerializeObject(userVM);
            var buffer = System.Text.Encoding.UTF8.GetBytes(json);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            HttpResponseMessage result = null;
            if (userVM.Id != null)
            {
                result = client.PostAsync("employees/Reject/", byteContent).Result;
                return Json(result);
            }
            return Json(404);
        }
    }
}