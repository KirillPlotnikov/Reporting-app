using Microsoft.EntityFrameworkCore;
using SemestralkaDataControl.EF;
using SemestralkaDataControl.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemestralkaDataControl.Repos
{
    public class QuestionsRepo : IQuestionsRepo
    {
        public readonly DbSet<Question> _table;
        public readonly ApplicationContext _context;

        protected ApplicationContext Context => _context;
        public QuestionsRepo() : this(new ApplicationContext()) { }
        public QuestionsRepo(ApplicationContext context)
        {
            _context = context;
            _table = _context.Set<Question>();
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

        public int GetUnansweredCount()
        {
            return Context.Questions.Where(q => q.Answer == null).Count();
        }

        public async Task<List<Question>> GetUnanswered()
        {
            return await Context.Questions.Where(q => q.Answer == null).OrderByDescending(q => q.DateTimeOfCreation).ToListAsync<Question>();
        }

        public async Task<int> Add(Question q)
        {
            Context.Questions.Add(q);
            return await Context.SaveChangesAsync();
        }
    }
}
