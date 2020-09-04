using Microsoft.EntityFrameworkCore;
using SemestralkaDataControl.EF;
using SemestralkaDataControl.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SemestralkaDataControl.Repos
{
    public class AnswersRepo : IAnswersRepo
    {
        public readonly ApplicationContext _context;

        protected ApplicationContext Context => _context;
        public AnswersRepo() : this(new ApplicationContext()) { }
        public AnswersRepo(ApplicationContext context)
        {
            _context = context;
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public async Task<int> Add(Answer a)
        {
            Context.Answers.Add(a);
            return await Context.SaveChangesAsync();
        }
    }
}
