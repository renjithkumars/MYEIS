using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Script.Serialization;

namespace Login.Models
{
    public class Weather
    {
        public Object getWeather(string data)
        {
            string url = data;
            var client = new WebClient();
            var content = client.DownloadString(url);
            var serializer = new JavaScriptSerializer();
            var jsonContent = serializer.Deserialize<Object>(content);
            return jsonContent;
        }
    }
        public class URL
        {
            public string url { get; set; }
        }
    
}

