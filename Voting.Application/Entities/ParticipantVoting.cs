namespace Voting.Application.Entities;

public class ParticipantVoting
{
    public Guid Id { get; set; }
    public required Guid UserId { get; set; }
    public required Guid ParticipantId { get; set; }
    public virtual Participant Participant { get; set; } = null!;
    public required Guid VotingId { get; set; }
    public virtual Voting Voting { get; set; } = null!;
}
