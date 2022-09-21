using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HelloASPDotNET.Controllers
{
    [Route("/helloworld")]
    public class HelloController : Controller
    {
        // GET: /<controller>/

        [HttpGet]
        public IActionResult Index()
        {
            string html = "<form method='post' action='/helloworld/greeting'>" +
                "<input type='text' name='name' />" +

                "<select name='language'>" +
                    "<option value='english' selected>English</option>" +
                    "<option value='spanish'>Spanish</option>" +
                    "<option value='german'>German</option>" +
                    "<option value='italian'>Italian</option>" +
                    "<option value='french'>French</option></select>" +

                "<input type='submit' value='Greet Me!' />" +
                "</form>";

            return Content(html, "text/html");
        }

     
        /*[HttpGet("welcome/{name?}")]
        [HttpPost("welcome")]
        public IActionResult Welcome(string name = "World")
        {
            return Content("<h1>Welcome to my app, " + name + "!</h1>", "text/html");
        }
        */

        [HttpGet("greeting/{language?}")]
        [HttpPost("greeting")]
        public IActionResult Greeting(string name, string language = "English")
        { 
            return Content(CreateMessage(name, language), "text/html");
        }

   

        public static string CreateMessage(string name, string language)
        {
            string helloTranslation = "";
            switch (language)
            {

                case "english":
                    helloTranslation = "Hello";
                    break;
                case "spanish":
                    helloTranslation = "Hola";
                    break;
                case "german":
                    helloTranslation = "Hallo";
                    break;
                case "italian":
                    helloTranslation = "Ciao";
                    break;
                case "french":
                    helloTranslation = "Bonjour";
                    break;

            }
            //return helloTranslation + name;
            //Bonus Mission:
            return ($"<h1 style='font-family: system-ui; font-size: 36px; font-style: oblique; color: midnightblue;'>{helloTranslation}, {name}!");
        }


        

    } 
}

