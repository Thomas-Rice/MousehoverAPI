using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using MouseHoverAPI.Models;

namespace MouseHoverAPI.Controllers
{
    [Route("api/[controller]")]
    public class MouseHoverController : Controller
    {
        [HttpGet]
        public string DefaultAction()
        {
            return MovementCalculator.Move("0,0 N; M");
        }

        [HttpGet("{arg}")]
        public string ActionWithArgs(string arg)
        {
            return MovementCalculator.Move(arg); ;
        }


    }
}