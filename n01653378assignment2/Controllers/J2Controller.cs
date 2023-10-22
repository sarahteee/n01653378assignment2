using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Web.Http;
using System.Web.Mvc.Html;
using System.Web.UI.WebControls;

namespace n01653378assignment2.Controllers
{
    public class J2Controller : ApiController
    {

        /// <summary>
        /// Recieves number of peppers and pepper names, outputs total spiciness
        /// </summary>
        /// <returns>
        ///     GET api/route/J2/Pepper/4/Poblano/Cayenne/Thai/Poblano -> 118000
        /// </returns>


        [HttpGet]
        [Route("api/J2/Peppers/{N}")]
        public string Peppers()
        {
            int T = 0;
            int N = 0;
            string pepperInput = "";

            int Poblano = 1500;
            int Mirasol = 6000;
            int Serrano = 15500;
            int Cayenne = 40000;
            int Thai = 75000;
            int Habanero = 125000;

            for (int i = 0; i < N; i++)
            {
                int SHU = 0;

                switch (pepperInput)
                {
                    case "Poblano":
                        SHU = Poblano;
                        break;
                    case "Mirasol":
                        SHU = Mirasol;
                        break;
                    case "Serrano":
                        SHU = Serrano;
                        break;
                    case "Cayenne":
                        SHU = Cayenne;
                        break;
                    case "Thai":
                        SHU = Thai;
                        break;
                    case "Habanero":
                        SHU = Habanero;
                        break;
                }
                T = T + SHU;
            }
            return T;

        }
    }
}

    
