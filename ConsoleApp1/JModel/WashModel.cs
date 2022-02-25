using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace ConsoleApp1.JModel
{
    public class WashModel
    {
        public string Brand { get; set; }
        public string ProductName { get; set; }
        public string Model { get; set; }
        public string Price { get; set; }

        public string GetJson()
        {
           return JsonConvert.SerializeObject(this);
        }
    }
}
