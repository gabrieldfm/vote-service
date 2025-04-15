namespace Voting.ApiService.Models.Voting.Requests;

public class CreateVotigRequestModel
{
    public IEnumerable<Guid> ParticipantsId { get; set; } = new List<Guid>();
}

