using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;
using D02_EF6_CF_V1.Model;

namespace D02_EF6_CF_V1.Model
{
    public partial class Post
    {
        public void CreatePost()
        {
            var db = new BlogContext();

            using (db)
            {
                #region Post
                Post post1 = new Post();
                //Post post2 = new Post();
                //Post post3 = new Post();
                Utility.WriteTitle("\nCreate Post\n");
                Console.Write("\n\nInforme o blog: ");
                int blogid = int.Parse(Console.ReadLine());
                post1.BlogId = blogid;
                Console.Write("Informe o titulo: ");
                string title = Console.ReadLine();
                post1.Title = title;
                Console.Write("Informe o content: ");
                string content = Console.ReadLine();
                post1.Content = content;

                db.Post.Add(post1);
                db.SaveChanges();


                //post1.BlogId = 1;
                //post1.Title = "post10";
                //post1.Content = "post10";


                //post2.BlogId = 1;
                //post2.Title = "post20";
                //post2.Content = "post20";

                //post3.BlogId = 1;
                //post3.Title = "post30";
                //post3.Content = "post30";

                //db.Post.Add(post1);
                //db.Post.Add(post2);
                //db.Post.Add(post3);

                //db.SaveChanges();

                //var queryPost = db.Post.Select(p => p).OrderBy(p => p.PostId);

                //Utility.WriteTitle("Posts");

                //queryPost.ToList().ForEach(p => Console.WriteLine($"{p.PostId} - {p.Title}"));

                #endregion
            }
        }

        public void ReadPost()
        {
            var db = new BlogContext();
            var queryPost = db.Post.Select(p => p).OrderBy(p => p.PostId);

            Utility.WriteTitle("Posts");

            queryPost.ToList().ForEach(p => Console.WriteLine($"{p.PostId} - {p.Title}"));
        }
    }
 }
