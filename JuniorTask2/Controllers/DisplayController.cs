using JuniorTask2.Data.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JuniorTask2.Controllers
{
    public class DisplayController : Controller // Контроллер отображаемой информации
    {
        private readonly IDisplayService _displayService; // Сервис обработки ввода
        public DisplayController(IDisplayService displayService)
        {
            _displayService = displayService;
        }

        public IActionResult InputValues() // Вход в представление с вводом строки
        {
            return View();
        }

        [HttpPost]
        public IActionResult InputValues(IFormCollection fc) // Получение результатов из формы
        {
            _displayService.SetStr(fc); // Задать результаты в сервис
            return RedirectToAction("CountResults", "CountResults", 
                new { json = GetStrInJson(_displayService.GetStr()).Value.ToString()});// Отправить на обработку в контроллер определения палиндрома
        }

        [HttpGet]
        public IActionResult ShowResults(string json) // Вывод результатов из полученной строки в формате JSON
        {
            bool data = JsonConvert.DeserializeObject<bool>(json);
            return View(data);
        }

        public JsonResult GetStrInJson(string data)
        {
            var json = JsonConvert.SerializeObject(data);
            return Json(json);
        }
    }
}
