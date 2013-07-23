﻿using GiveIT.UI.Web.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebMatrix.WebData;

namespace GiveIT.UI.Web.Controllers
{
    public class VolunteerController : Controller
    {
        //
        // GET: /Volunteer/

        UIWebDbContext db = new UIWebDbContext();

        [HttpGet]
        [AllowAnonymous]
        public ActionResult RegisterVolunteer()
        {
            return View();
        }     

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult RegisterVolunteer(HttpPostedFileBase file)
        {
           
            if (file != null && file.ContentLength > 0)
            {
                var fileName = Path.GetFileName(file.FileName);
                var path = Path.Combine(Server.MapPath("~/App_Data/uploads"), fileName);
                file.SaveAs(path);
            }
    
            //if (ModelState.IsValid)
            //{
            //    WebSecurity.CreateUserAndAccount(model.UserName, model.Password,
            //        propertyValues: new
            //        {
            //            ContactFirstName = model.ContactFirstName,
            //            ContactLastName = model.ContactLastName,
            //            VolunteerHours = model.VolunteerHours,
            //            PhoneNumber = model.PhoneNumber,
            //            PhoneNoExtension = model.PhoneNoExtension,
            //            EmailAddress = model.EmailAddress
            //        });

            //}
            return View();
        }
    }
}