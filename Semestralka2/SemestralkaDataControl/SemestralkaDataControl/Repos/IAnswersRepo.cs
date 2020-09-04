using SemestralkaDataControl.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SemestralkaDataControl.Repos
{
    public interface IAnswersRepo : IDisposable
    {
        Task<int> Add(Answer a);
    }
}
