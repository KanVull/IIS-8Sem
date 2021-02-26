using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebApplication2
{
    /// <summary>
    /// Сводное описание для WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Чтобы разрешить вызывать веб-службу из скрипта с помощью ASP.NET AJAX, раскомментируйте следующую строку. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        private double ToKm(double value, byte r1)
        {
            switch (r1)
            {
                case 1: return value;
                case 2: return value / 3280.84;
                default: return value * 1.609;
            }
        }
        private double ToFu(double value, byte r1) {
            switch (r1)
            {
                case 1: return value * 3280.84;
                case 2: return value;
                default: return value * 5280;
            }
        }
        private double ToMi(double value, byte r1) {
            switch (r1)
            {
                case 1: return value / 1.609;
                case 2: return value / 5280;
                default: return value;
            }
        }
        [WebMethod]
        public double GetValue(double value, byte r1, byte r2)
        {
            if (r1 == r2) return value;
            switch (r2)
            {
                case 1: return ToKm(value, r1);
                case 2: return ToFu(value, r1);
                default: return ToMi(value, r1);
            }
        }


    }
}
