using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLib.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public ActionResult Input() { return View(); }
        [Route("/output")]
        public ActionResult Output(string noun1, string noun2, string verb1, string verb2, string verb3)
        {
            InputVariable newInputVariable = new InputVariable();
            newInputVariable.SetNoun1(noun1);
            newInputVariable.SetNoun2(noun2);
            newInputVariable.SetVerb1(verb1);
            newInputVariable.SetVerb2(verb2);
            newInputVariable.SetVerb3(verb3);
            return View(newInputVariable);
        }
    }
}