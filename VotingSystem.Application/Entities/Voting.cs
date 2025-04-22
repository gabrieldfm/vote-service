namespace VotingSystem.Application.Entities;

public class Voting
{
    public Guid Id { get; set; }
    public string Description { get; private set; } = string.Empty;
    public bool IsActive { get; private set; }
    public required List<Participant> Participants { get; set; }

    public Voting()
    {
    }

    public Voting(string description, IList<Participant> participants)
    {
        SetParticipants(participants);
        Description = description;
    }

    public void FinishVoting()
    {
        IsActive = false;
    }

    private void SetParticipants(IList<Participant> participants)
    {
        if (participants is not null && participants.Count > 1)
        {
            Participants = [.. participants];
        }
        else
        {
            throw new ApplicationException("Invalid participants for this voting");
        }
    }
}
