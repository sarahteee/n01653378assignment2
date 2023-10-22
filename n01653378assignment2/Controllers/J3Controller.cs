using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Authentication;
using System.Web.Http;

namespace n01653378assignment2.Controllers
{
    public class J3Controller : ApiController
    {
        /// <summary>
        /// Recieves a series of words and outputs the minimum number of seconds required to type it, stops reading input when "halt" is entered
        /// </summary>
        /// <returns>
        ///     GET api/route/J3/Messaging/a/dada/bob/abba/cell/www/halt -> 
        ///     1
        ///     4
        ///     7
        ///     12
        ///     13
        ///     7
        /// </returns>

        [HttpGet]
        [Route("api/route/J3/Messaging/")]
        public IEnumerable<int> Get()
        {
            List<char, int> Keys = new List<char, int>();
            {
                Keys.Add("a", "2"); Keys.Add("b", "22"); Keys.Add("c", "222");
                Keys.Add("d", "3"); Keys.Add("e", "33"); Keys.Add("f", "333");
                Keys.Add("g", "4"); Keys.Add("h", "44"); Keys.Add("i", "444");
                Keys.Add("j", "5"); Keys.Add("k", "55"); Keys.Add("l", "555");
                Keys.Add("m", "6"); Keys.Add("n", "66"); Keys.Add("o", "666");
                Keys.Add("p", "7"); Keys.Add("q", "77"); Keys.Add("r", "777");
                Keys.Add("s", "7777"); Keys.Add("t", "8"); Keys.Add("u", "88");
                Keys.Add("v", "888"); Keys.Add("w", "9"); Keys.Add("x", "99");
                Keys.Add("y", "999"); Keys.Add("z", "9999");

                    string word = "";
                int second = 0;
                char letter = "";

                for (int i = 0; i < N; i++)
            }
        }
    }
}
