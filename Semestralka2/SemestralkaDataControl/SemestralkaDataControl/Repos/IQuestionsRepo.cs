using SemestralkaDataControl.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SemestralkaDataControl.Repos
{
    public interface IQuestionsRepo : IDisposable
    {
        int GetUnansweredCount();
        Task<List<Question>> GetUnanswered();
        Task<int> Add(Question q);
    }
}
