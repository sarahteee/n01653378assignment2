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
        /// <param name="N">the number of peppers</param>
        /// <returns>
        ///     GET api/route/J2/Pepper/4/Poblano/Cayenne/Thai/Poblano -> 118000
        /// </returns>


        [HttpGet]
        [Route("api/J2/Peppers/{N}/{*pepperInput}")]
        public string Peppers(int N)
        {
            int Poblano = 1500;
            int Mirasol = 6000;
            int Serrano = 15500;
            int Cayenne = 40000;
            int Thai = 75000;
            int Habanero = 125000;
            int T = 0;
            string pepperInput = "";

                if (pepperInput == "Poblano") 
                {
                    T += Poblano;
                }
                else if (pepperInput == "Mirasol")
                {
                    T += Mirasol;
                }
                else if (pepperInput == "Serrano")
                {
                    T += Serrano;
                }
                else if (pepperInput == "Cayenne")
                {
                    T += Cayenne;
                }
                else if (pepperInput == "Thai")
                {
                    T += Thai;
                }
                else if (pepperInput == "Habanero")
                {
                    T += Habanero;
                }

            T = T + pepperInput;

                    return T;

                }
            }

        }

    
