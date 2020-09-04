using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using Semestralka2.Hubs;
using Semestralka2.Services;
using SemestralkaDataControl.EF;
using SemestralkaDataControl.Models;
using SemestralkaDataControl.Repos;

namespace Semestralka2.Pages
{
    [ValidateAntiForgeryToken]
    public class AnswerModel : PageModel
    {
        private readonly ApplicationContext _context;
        private readonly IHubContext<MainHub> _hubContext;
        private readonly IWebHostEnvironment _environment;

        public AnswerModel(ApplicationContext context, IHubContext<MainHub> hubContext, IWebHostEnvironment environment)
        {
            _context = context;
            _hubContext = hubContext;
            _environment = environment;
        }

        public string Message { get; set; }
        public Question oldestUnanswered { get; set; }

        
        [BindProperty]
        public Answer Answer { get; set; }


        public void OnGet()
        {
            oldestUnanswered = _context.Questions.Where(q => q.Answer == null).OrderBy(q => q.DateTimeOfCreation).FirstOrDefault();
        }

        
        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                if (Answer.File != null)
                {
                    var uniqueFileName = Path.GetRandomFileName().Substring(0, 8) + Path.GetExtension(Answer.File.FileName);

                    var questionsFiles = Path.Combine(_environment.ContentRootPath, @"Files\answerFiles");
                    var filePath = Path.Combine(questionsFiles, uniqueFileName);
                    Answer.FileName = uniqueFileName;
                    using (var stream = System.IO.File.Create(filePath))
                    {
                        await Answer.File.CopyToAsync(stream);
                    }

                }

                Answer.DateTimeOfCreation = DateTime.Now;
                 _context.Answers.Add(Answer);
                await _context.SaveChangesAsync();
                var question = _context.Questions.Where(q => q.Id == Answer.QuestionId).FirstOrDefault();
                EmailService emailService = new EmailService();
                var callbackUrl = Url.Page(
                        "MyAnswer",
                        "",
                        new { answerId = Answer.Id },
                        protocol: HttpContext.Request.Scheme);
                await emailService.SendEmailAsync(Answer.Question.Email, "Check answer for your report",
                        $"Your report has been answered. Visit link: <a href='{callbackUrl}'>Read the answer</a>");
                await _hubContext.Clients.All.SendAsync("Answered");
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
