using Microsoft.AspNetCore.Http;
using System.Collections;
using System.Collections.Generic;

namespace JuniorTask2.Data.Services
{
    public interface IDisplayService
    {
        public void SetStr(IFormCollection fc);
        public string GetStr();
    }
}
