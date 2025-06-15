namespace Worldseed.Client.Blazor.DTOs.Forum
{
    public class ForumCategoryThreadPostDTO
    {
        public int Id { get; set; }
        public int ForumCategoryThreadId { get; set; }
        public int OwnerId { get; set; }
        public string Content { get; set; }
    }
}
