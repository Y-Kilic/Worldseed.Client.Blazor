namespace Worldseed.Client.Blazor.DTOs.Forum
{
    public class CreateForumPostDTO
    {
        public int ForumCategoryThreadId { get; set; }
        public int OwnerId { get; set; }
        public string Content { get; set; }
    }
}
