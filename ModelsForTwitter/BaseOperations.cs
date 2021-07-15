using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ModelsForTwitter
{
    public class BaseOperations
    {
        private DbTwitterCloneContex _dbContex;
        public BaseOperations(DbTwitterCloneContex dbContex) 
        {
            this._dbContex = dbContex;
        }
        static public void CalculateAverageNumberOfLikesPerPost(int userID)
        { 
            using (DbTwitterCloneContex twitterClone = new DbTwitterCloneContex())
            {
                var userPosts = twitterClone.Posts
                                .Where(p => p.UserId == userID)
                                .Include(l =>l.Likes)
                                .ToList();
                var avarageCount = userPosts.Average(p => p.Likes.Count);
                Console.WriteLine(avarageCount);                
            }            
        }
        static public void CalculateMostLikesOnPosts()
        {
            using (DbTwitterCloneContex twitterClone = new DbTwitterCloneContex())
            {
                var countPosts = twitterClone.Posts
                                .Include(p => p.Likes)
                                .ToList();
                                              
                Console.WriteLine(countPosts.Max(p => p.Likes.Count));
            }
        }
        static public void CalculateMostLikesOnAnswers()
        {
            using (DbTwitterCloneContex twitterClone = new DbTwitterCloneContex())
            {
                var countAnswers = twitterClone.Answers
                                .Include(a => a.Likes)
                                .ToList();
                if (countAnswers == null || countAnswers.Count == 0)
                {
                    Console.WriteLine("Answers is empty");
                }
                else
                {
                    Console.WriteLine(countAnswers.Max(a => a.Likes.Count));
                }
            }
        }
        static public void CalculateMostRepostInPost()
        {
            using (DbTwitterCloneContex twitterClone = new DbTwitterCloneContex())
            {
                var countPosts = twitterClone.Posts
                                .Include(p => p.RePosts)
                                .ToList();
                if (countPosts == null || countPosts.Count == 0)
                {
                    Console.WriteLine("Answers is empty");
                }
                else
                {
                    Console.WriteLine(countPosts.Max(a => a.RePosts.Count));
                }
            }
        }
        static public void CalculateMostAnswersInPost()
        {
            using (DbTwitterCloneContex twitterClone = new DbTwitterCloneContex())
            {
                var countAnswers = twitterClone.Posts
                                .Include(p => p.Answers)
                                .ToList();
                if (countAnswers == null || countAnswers.Count == 0)
                {
                    Console.WriteLine("Answers is empty");
                }
                else
                {
                    Console.WriteLine(countAnswers.Max(a => a.RePosts.Count));
                }
            }
        }
        static public void CalculateAverageNumberFollowers()
        {
            using (DbTwitterCloneContex twitterClone = new DbTwitterCloneContex())
            {
                var userFollower = twitterClone.Users                                
                                .Include(f => f.RelationshipsFolower)
                                .ToList();
                var avarageCount = userFollower.Average(f => f.RelationshipsFolower.Count);
                Console.WriteLine(avarageCount);
            }
        }
        static public void TakeSomeMostPopularUsers(int countUser)
        {
            using (DbTwitterCloneContex twitterClone = new DbTwitterCloneContex())
            {
               
            }
        }
        static public void TakeSomeMostPopularPost(int countUser)
        {
            using (DbTwitterCloneContex twitterClone = new DbTwitterCloneContex())
            {

            }
        }
        static public void CalculateAverageNumberFollowed()
        {
            using (DbTwitterCloneContex twitterClone = new DbTwitterCloneContex())
            {
                var userFollower = twitterClone.Users
                                .Include(f => f.RelationshipsFollowed)
                                .ToList();
                var avarageCount = userFollower.Average(f => f.RelationshipsFollowed.Count);
                Console.WriteLine(avarageCount);
            }
        }
        static public void FindPostsWithTag(string tagPost)
        {
            using (DbTwitterCloneContex twitterClone = new DbTwitterCloneContex())
            {
                var tagId = twitterClone.Tags
                                .Where(t => t.TagsText == tagPost)
                                .ToList();
                var postList = twitterClone.Posts
                                    .Include(t => t.TagsPosts)
                                    .ThenInclude(t => t.Tags)
                                    .ToList();
                var postWithTag = (from post in postList
                                   from tags in post.TagsPosts
                                   from tag in tags.Tags
                                   where tag == tagId[0]
                                   select post.Id).ToList();

                foreach (var post in postWithTag)
                {
                    Console.WriteLine(post);
                }                
            }
        }
    }
    
}
