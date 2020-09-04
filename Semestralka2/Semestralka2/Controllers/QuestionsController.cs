using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Semestralka2.Hubs;
using SemestralkaDataControl.Models;
using SemestralkaDataControl.Repos;

namespace Semestralka2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionsController : ControllerBase
    {
        private readonly IQuestionsRepo _repo;
        private readonly IWebHostEnvironment hostingEnvironment;
        private readonly IHubContext<MainHub> _hubContext;

        public QuestionsController(IQuestionsRepo repo, IWebHostEnvironment environment, IHubContext<MainHub> hubContext)
        {
            _repo = repo;
            hostingEnvironment = environment;
            _hubContext = hubContext;
        }

        [HttpPost]
        public async Task<ActionResult<Question>> PostQuestion([FromForm][Bind("Text", "Email", "File", "ProductId")] Question q)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (q.File != null)
            {
                var uniqueFileName = Path.GetRandomFileName().Substring(0,8) + Path.GetExtension(q.File.FileName);
              
                var questionsFiles = Path.Combine(hostingEnvironment.ContentRootPath, @"Files\questionFiles");
                var filePath = Path.Combine(questionsFiles, uniqueFileName);
                q.FileName = uniqueFileName;
                using (var stream = System.IO.File.Create(filePath))
                {
                    await q.File.CopyToAsync(stream);
                }
               
            }

            q.DateTimeOfCreation = DateTime.Now;

            await _repo.Add(q);
            q.File = null;
            await _hubContext.Clients.All.SendAsync("Added");
            return Ok(q);
        }


        
    }
}