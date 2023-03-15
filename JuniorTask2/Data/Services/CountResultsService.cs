using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;

namespace JuniorTask2.Data.Services
{
    public class CountResultsService : ICountResultsService // Сервис обработки строки (определения палиндрома)
    {
        public const string RusAlph = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЬЫЪЭЮЯабвгдеёжзийклмнопрстуфхцчшщьыъэюя"; // Русский алфавит для сравнения символов
        public bool CountTask(string data)
        {
            foreach (char c in data) 
                if(!Char.IsLetter(c) || !IsRusLetter(c)) data = data.Replace(c.ToString(), String.Empty); // Убрать все кроме букв
            data = data.ToUpper(); // Сделать все буквы заглавными 

            for (int i = 0; i < data.Length / 2; i++) // Пробежать строку на половину
                if (data[i] != data[data.Length - 1 - i]) return false; //Если противоположенные символы не равны - не палиндром
            return true; // иначе строка симметрична, палиндром
        }

        public bool IsRusLetter(char c) // Проверка на букву русского алфавита, аналог IsLetter
        {
            return RusAlph.Contains(c);// Если буква есть в алфавите, вернуть True
        }
    }
}
