using System.Collections.Generic;

namespace ModelsForTwitter
{
    public class Relationships_user
    {
        public int Id { get; set; }
        public int FolowerId { get; set; }
        public int FollowedId { get; set; }
    }
}
