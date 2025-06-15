namespace Worldseed.Client.Blazor.DTOs.Forum
{
    public class CreateForumThreadDTO
    {
        public int ForumCategoryId { get; set; }
        public int OwnerId { get; set; }
        public string Title { get; set; }
    }
}
