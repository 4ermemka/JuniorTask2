using JuniorTask1.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;

namespace JuniorTask2.Data.Services
{
    public class DisplayService : IDisplayService // Сервис обработки вводимой информации
    {
        string str;

        public void SetStr(IFormCollection fc) // Получает строку из формы
        {
            str = fc["str"].ToString();
        }

        public string GetStr() // Возвращает строку
        {
            return str;
        }
    }
}
