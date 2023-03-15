using JuniorTask2.Data.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace JuniorTask2.Controllers
{
    public class CountResultsController : Controller //Контроллер определения палиндрома
    {
        private readonly ICountResultsService _countResultsService; // Сервис определения палиндрома

        public CountResultsController(ICountResultsService countResultsService)
        {
            _countResultsService = countResultsService;
        }

        public IActionResult CountResults(string json) // Получение строки в формате JSON
        {
            bool result = _countResultsService.CountTask(JsonConvert.DeserializeObject<string>(json)); // Обработка результата 
            return RedirectToAction("ShowResults", "Display",
                new { json = GetBoolInJson(result).Value.ToString() }); // Отправление в контроллер отображения для вывода результатов
        }
        public JsonResult GetBoolInJson(bool data)
        {
            var json = JsonConvert.SerializeObject(data);
            return Json(json);
        }
    }
}
