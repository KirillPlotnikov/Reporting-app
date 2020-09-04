using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Semestralka2.Pages
{
    public class GetFileModel : PageModel
    {
        public IActionResult OnGet(string filename, bool question)
        {
            var path = String.Empty;
            if (question)
            {
                path = Path.GetFullPath($"Files/questionFiles/{filename}");
            }
            else
            {
                path = Path.GetFullPath($"Files/answerFiles/{filename}");
            }
            

            FileStream fs = new FileStream(path, FileMode.Open);

            return new FileStreamResult(fs, "application/octet-stream")
            {
                FileDownloadName = filename
            };
        }
    }
}
