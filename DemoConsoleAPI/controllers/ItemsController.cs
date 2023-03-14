using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsoleAPI.controllers
{
    [ApiController]
    [Route("[controller]")]
    public  class ItemsController : ControllerBase
    {
        private static List<string> _items = new List<string>();

        [HttpGet]
        public ActionResult<IEnumerable<string>> Items()
        {
            return _items;
        }

        [HttpPost]
        public ActionResult AddItem([FromBody] string item)
        {
            _items.Add(item);
            return Ok();
        }
    }
}
