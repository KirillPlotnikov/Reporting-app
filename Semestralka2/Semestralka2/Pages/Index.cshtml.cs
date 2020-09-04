using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Logging;
using Semestralka2.Hubs;
using SemestralkaDataControl.Models;
using SemestralkaDataControl.Repos;

namespace Semestralka2.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IQuestionsRepo _repo;
        private readonly IHubContext<MainHub> _hubContext;

        public int UnansweredCount { get; set; }
        public List<Question> OldestTenQuestions { get; set; } = new List<Question>();
        public IndexModel(ILogger<IndexModel> logger, IQuestionsRepo repo, IHubContext<MainHub> hubContext)
        {
            _logger = logger;
            _repo = repo;
            _hubContext = hubContext;
        }

        public async Task<IActionResult> OnGetAsync()
        {
            OldestTenQuestions = await _repo.GetUnanswered();
            UnansweredCount = _repo.GetUnansweredCount();

            return Page();
        }

        public async Task<IActionResult> OnGetPartialAsync()
        {
            var questions = await _repo.GetUnanswered();
            return new PartialViewResult
            {
                ViewName = "_QuestionsPartial",
                ViewData = new ViewDataDictionary<List<Question>>(ViewData, questions)
            };
        }
    }
}
