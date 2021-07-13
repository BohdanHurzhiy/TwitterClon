using System.Collections.Generic;

namespace ModelsForTwitter
{
    public class Tags_post
    {
        public int Id { get; set; }
        //public int PostId { get; set; }
        public int TagId { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }
    }
}
