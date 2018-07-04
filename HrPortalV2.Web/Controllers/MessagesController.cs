﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HrPortalV2.Models;
using HrPortalV2.Service;
using Microsoft.AspNetCore.Mvc;

namespace HrPortalV2.Web.Controllers
{
    public class MessagesController : Controller
    {
        private readonly IMessageService messageService;
        private readonly ICompanyService companyService;
        private readonly IResumeService resumeService;
        public MessagesController(IMessageService messageService, ICompanyService companyService, IResumeService resumeService)
        {
            this.messageService = messageService;
            this.companyService = companyService;
            this.resumeService = resumeService;
        }
        public IActionResult MyMessagesSentToMyCompanies()
        {
            var mycompanies = companyService.GetByUserName(User.Identity.Name).Select(c=>c.Id).ToList();
            var mymessages = messageService.GetByTo(mycompanies);
            return View(mymessages);
        }
        public IActionResult MyMessagesSentToMyResumes()
        {
            var myresumes = resumeService.GetByUserName(User.Identity.Name).Select(c => c.Id).ToList(); // resumes
            var mymessages = messageService.GetByTo(myresumes);
            return View(mymessages);
        }
        public IActionResult Create(string to)
           
        {
            var message = new Message(){ To = to };
            return View(message);
        }
    }
}