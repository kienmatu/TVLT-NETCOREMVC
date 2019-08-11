using Microsoft.EntityFrameworkCore;
using NewsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsApp
{
    public class CateRepository : IRepository<Category>
    {
        private NewsContext context;
        
        public CateRepository(NewsContext _context)
        {
            this.context = _context;
        }
        public async Task Add(Category entity)
        {
            await context.AddAsync(entity);
        }

        public bool Exist(int id)
        {
            Category category = context.Categories.Find(id);
            if(category != null)
            {
                return true;
            }
            return false;
        }

        public Category FindByID(int id)
        {
            return context.Categories.Find(id);
        }

        public List<Category> GetAll()
        {
            return  context.Categories.ToList();
        }

        public async Task Remove(int id)
        {
            Category category = await context.Categories.FindAsync(id);
             context.Categories.Remove(category);
        }

        public async Task Update(Category entity)
        {
            Category category = await context.Categories.FindAsync(entity.ID);
            category = entity;
            // context.SaveChangesAsync();

        }
    }
}
