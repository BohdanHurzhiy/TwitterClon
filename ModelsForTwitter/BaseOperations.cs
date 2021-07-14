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
        public void CalculateAverageNumberOfLikesPerPost(int userID)
        {
            var userPosts = _dbContex.Posts.Where(p => p.UserId == userID);
        }
    }
    
}
