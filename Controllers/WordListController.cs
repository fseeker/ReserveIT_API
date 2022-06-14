using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReserveIT_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WordListController : ControllerBase
    {

        public static string[] words = Array.Empty<string>();
        public static int pageSize;
        [HttpGet]
        public List<string> Get()
        {
            List<string> res = new List<string>();
            string oneLine = string.Join(" ", words);
            int n = pageSize;
            if (n < 1)
            {
                n = 10;
            }
            string newLine = oneLine;
            while(newLine.Length > n)
            {
                string perLine = newLine.Substring(0, n);
                newLine = newLine.Substring(n);
                res.Add(perLine);
            }
            res.Add(newLine);
            return res;
        }

        [HttpPost]
        public IActionResult Post([FromBody] string[] words)
        {
            Request.Headers.TryGetValue("page-size", out var pageSize);
            Int32.TryParse(pageSize, out int pSize);
            WordListController.words = words;
            WordListController.pageSize = pSize;



            return Created("", "");
        }
    }
}
