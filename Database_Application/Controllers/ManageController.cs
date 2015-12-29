using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using Database_Application.Models;

namespace Database_Application.Controllers
{
    
    public class ManageController : Controller
    {
        public ActionResult testView()
        { return View(); }
    }


}
