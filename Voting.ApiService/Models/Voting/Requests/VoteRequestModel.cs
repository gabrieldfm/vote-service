namespace Voting.ApiService.Models.Voting.Requests;

public class VoteRequestModel
{
    public Guid VotingId { get; set; }
    public Guid ParticipantId { get; set; }
}

