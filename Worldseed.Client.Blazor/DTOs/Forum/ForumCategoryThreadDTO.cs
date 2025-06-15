namespace Worldseed.Client.Blazor.DTOs.Forum
{
    public class ForumCategoryThreadDTO
    {
        public int Id { get; set; }
        public int ForumCategoryId { get; set; }
        public int OwnerId { get; set; }
        public string Title { get; set; }
    }
}
