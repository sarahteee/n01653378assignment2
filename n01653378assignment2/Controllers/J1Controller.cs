using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01653378assignment2.Controllers
{
    public class J1Controller : ApiController
    {
        /// <summary>
        /// Recieve three numbers representing angles and output the type of triangle
        /// </summary>
        /// <param name="angle1">The first angle of a triangle</param>
        /// <param name="angle2">The second angle of a triangle</param>
        /// <param name="angle3">The third angle of a triangle</param>
        /// <returns>
        ///     GET api/route/J1/Triangle/60/60/60 -> "Equilateral"
        ///     GET api/route/J1/Triangle/100/40/40 -> "Isosceles"
        ///     GET api/route/J1/Triangle/60/70/50 -> "Scalene"
        ///     GET api/route/J1/Triangle/60/75/55 -> "Error"
        /// </returns>

        [HttpGet]
        [Route("api/route/J1/Triangle/{angle1}/{angle2}/{angle3}")]
        public string Triangle (int angle1, int angle2, int angle3)
        {

            string Triangle = "";

            if (angle1 == 60 && angle2 == 60 && angle3 == 60)
            {
                Triangle = "Equilateral";
            }
            else if (angle1 == angle2 && angle3 == 180 - angle1 - angle2)
            {
                Triangle = "Isosceles";
            }
            else if (angle1 != angle2 && angle1 != angle3 && angle2 != angle3 && angle1 + angle2 + angle3 == 180)
            {
                Triangle = "Scalene";
            }
            else
            {
                Triangle = "Error";
            }

            return Triangle;
        }
    }
}
