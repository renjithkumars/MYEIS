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
        public Object getWeather()
        {
            string url ="http://api.openweathermap.org/data/2.5/weather?q=Dublin&APPID=e911d33d2a09374dae45a32724aef3fe&unit=imperial";
            var client = new WebClient();
            var content = client.DownloadString(url);
            var serializer = new JavaScriptSerializer();
            var jsonContent = serializer.Deserialize<Object>(content);
            return jsonContent;
        }
    }
           
}

