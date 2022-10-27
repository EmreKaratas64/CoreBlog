using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CoreBlog.Controllers
{
    [Authorize(Roles ="Admin")]
    public class EmployeeApiController : Controller
    {
        public async Task<IActionResult> ApiEmployee()
        {
            var httpclient = new HttpClient();
            var responseMessage = await httpclient.GetAsync("https://localhost:44334/api/Default");
            var jsonString = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<Employee2>>(jsonString);
            return View(values);
        }

        [HttpGet]
        public IActionResult AddApiEmployee()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddApiEmployee(Employee2 employee)
        {
            var httpclient = new HttpClient();
            var jsonemployee = JsonConvert.SerializeObject(employee);
            StringContent stringContent = new StringContent(jsonemployee, Encoding.UTF8, "application/json");
            var responsemessage = await httpclient.PostAsync("https://localhost:44334/api/Default", stringContent);
            if (responsemessage.IsSuccessStatusCode)
            {
                return RedirectToAction("ApiEmployee");
            }
            return View(employee);
        }

        [HttpGet]
        public async Task<IActionResult> EditEmployee(int id)
        {
            var httpclient = new HttpClient();
            var responsemessage = await httpclient.GetAsync("https://localhost:44334/api/Default/" + id);
            if (responsemessage.IsSuccessStatusCode)
            {
                var jsonemployee = await responsemessage.Content.ReadAsStringAsync();
                var value = JsonConvert.DeserializeObject<Employee2>(jsonemployee);
                return View(value);
            }
            return RedirectToAction("ApiEmployee");
        }

        [HttpPost]
        public async Task<IActionResult> EditEmployee(Employee2 employee)
        {
            var httpclient = new HttpClient();
            var jsonemployee = JsonConvert.SerializeObject(employee);
            StringContent content = new StringContent(jsonemployee, Encoding.UTF8, "application/json");
            var responsemessage = await httpclient.PutAsync("https://localhost:44334/api/Default", content);
            if (responsemessage.IsSuccessStatusCode)
            {
                return RedirectToAction("ApiEmployee");
            }

            return View(employee);
        }

        public async Task<IActionResult> DeleteEmployee(int id)
        {
            var httpclient = new HttpClient();
            var responsemessage = await httpclient.DeleteAsync("https://localhost:44334/api/Default/" + id);
            if (responsemessage.IsSuccessStatusCode)
            {
                TempData["Calisansilmebasari"] = "Çalışan başarıyla silindi";
                return RedirectToAction("ApiEmployee");
            }
            return View();
        }

    }

    public class Employee2
    {
        public int ID { get; set; }

        public string Name { get; set; }
    }
}
