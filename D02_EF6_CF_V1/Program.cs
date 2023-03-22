using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D02_EF6_CF_V1.Model;
using D00_Utility;

namespace D02_EF6_CF_V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUnicodeConsole();

            Blog blog= new Blog();
            Post post= new Post();

            string option = "";
            Console.Write("Option: ");
            option = Console.ReadLine();
            while (option != "1")
            {
                
                blog.CreateBlog();
                blog.ReadBlog();
                post.CreatePost();
                post.ReadPost();
                Console.Write("\nOption: ");
                option = Console.ReadLine();
            }    
            
            //var db = new BlogContext();

            //using(db) 
            //{
            //    // Criar e gravar um novo Blog

            //    #region Blog
            //    Blog blog1 = new Blog();

            //    //blog1.BlogId = 1; NÃO É PRECISO PQ PELA CONVENÇÃO A EF FARÁ ISSO
            //    blog1.Name = "EF6";

            //    db.Blog.Add(blog1);
            //    db.SaveChanges();

            //    var queryBlogs = db.Blog.Select(b => b).OrderBy(b => b.Name);                              

            //    Utility.WriteTitle("Blogs");

            //    queryBlogs.ToList().ForEach(b => Console.WriteLine($"{b.BlogId} - {b.Name}"));
            //    #endregion

            //    #region Post
            //    Post post1 = new Post();
            //    Post post2 = new Post();
            //    Post post3 = new Post();

            //    post1.BlogId = 1;
            //    post1.Title = "post1";
            //    post1.Content = "post1";

            //    post2.BlogId = 1;
            //    post2.Title = "post2";
            //    post2.Content = "post2";

            //    post3.BlogId = 1;
            //    post3.Title = "post3";
            //    post3.Content = "post3";

            //    db.Post.Add(post1);
            //    db.Post.Add(post2);
            //    db.Post.Add(post3);

            //    db.SaveChanges();

            //    var queryPost = db.Post.Select(p => p).OrderBy(p => p.PostId);

            //    Utility.WriteTitle("Posts");

            //    queryPost.ToList().ForEach(p => Console.WriteLine($"{p.PostId} - {p.Title}"));

            //    #endregion

            //}

            Utility.TerminateConsole();
        }
    }
}
