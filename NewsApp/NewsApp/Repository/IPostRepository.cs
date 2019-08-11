using Microsoft.EntityFrameworkCore;
using NewsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsApp
{
    public interface IPostRepository
    {
        Task Add(Post post);
        bool Exist(int id);
        Task Update(Post post);
        Task Remove(int id);
        Post FindByID(int id);
        List<Post> GetAll();
    }
    public class PostRepository : IPostRepository
    {
        private NewsContext context;
        public PostRepository(NewsContext _context)
        {
            this.context = _context;
        }
        public async Task Add(Post post)
        {
            await context.AddAsync(post);
        }

        public bool Exist(int id)
        {
            Post post = context.Posts.Find(id);
            if(post != null)
            {
                return true;
            }
            return false;
        }

        public Post FindByID(int id)
        {
            Post post =  context.Posts.Find(id);
            return  post;
        }

        public List<Post> GetAll()
        {
            return  context.Posts.ToList();
        }

        public async Task Remove(int id)
        {
            Post post = await context.Posts.FindAsync(id);
            context.Posts.Remove(post);
           // await context.SaveChangesAsync();
        }

        public async Task Update(Post post)
        {
            Post postnew = await context.Posts.FindAsync(post.ID);
            postnew = post;
            //await context.SaveChangesAsync();

        }
    }
}
