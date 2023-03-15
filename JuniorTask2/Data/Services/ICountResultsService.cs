using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace JuniorTask2.Data.Services
{
    public interface ICountResultsService
    {
        public bool CountTask(string data);

        public bool IsRusLetter(char c);
    }
}
