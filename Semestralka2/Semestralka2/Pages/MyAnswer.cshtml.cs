using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SemestralkaDataControl.EF;
using SemestralkaDataControl.Models;

namespace Semestralka2.Pages
{
    public class MyAnswerModel : PageModel
    {
        private readonly ApplicationContext _context;
        public MyAnswerModel(ApplicationContext context)
        {
            _context = context;
        }

        public Answer Answer { get; set; }
        public void OnGet(int answerId)
        {
            Answer = _context.Answers.Where(a => a.Id == answerId).FirstOrDefault();
        }
    }
}
