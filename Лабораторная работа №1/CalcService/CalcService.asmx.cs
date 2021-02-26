using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace CalcService
{
    /// <summary>
    /// Сводное описание для Service1
    /// </summary>
    [WebService(Namespace = "Calc")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Чтобы разрешить вызывать веб-службу из скрипта с помощью ASP.NET AJAX, раскомментируйте следующую строку.
    // [System.Web.Script.Services.ScriptService]
    public class CalcService : System.Web.Services.WebService
    {

        [WebMethod]
        public double Add(double x, double y)
        {
            return x + y;
        }

        [WebMethod]
        public double Sub(double x, double y)
        {
            return x - y;
        }

        [WebMethod]
        public double Mul(double x, double y)
        {
            return x * y;
        }

        [WebMethod]
        public double Div(double x, double y)
        {
            if (y == 0) return -1;
            return x / y;
        }
    }
}