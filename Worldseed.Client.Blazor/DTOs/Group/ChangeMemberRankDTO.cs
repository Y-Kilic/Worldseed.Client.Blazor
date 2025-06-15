namespace Worldseed.Client.Blazor.DTOs.Group
{
    public class ChangeMemberRankDTO
    {
        public int GroupId { get; set; }
        public int TargetUserId { get; set; }
        public GroupRank NewRank { get; set; }
    }
}
