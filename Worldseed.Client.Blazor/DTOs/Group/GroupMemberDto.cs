using Worldseed.Client.Blazor.DTOs.Group;

namespace Worldseed.Client.Blazor.DTOs.Group
{
    public class GroupMemberDto
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public GroupRank Rank { get; set; }
    }
}
