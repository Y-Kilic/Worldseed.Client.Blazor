namespace Worldseed.Client.Blazor.DTOs.Group
{
    public class ChangeMemberRankDto
    {
        public int GroupId { get; set; }
        public int TargetUserId { get; set; }
        public GroupRank NewRank { get; set; }
    }
}
