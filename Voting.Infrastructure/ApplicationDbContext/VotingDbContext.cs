using Microsoft.EntityFrameworkCore;
using Voting.Application.Entities;
using VotingEntity = Voting.Application.Entities.Voting;

namespace Voting.Infrastructure.ApplicationDbContext;

public class VotingDbContext(DbContextOptions<VotingDbContext> options) : DbContext(options)
{
    public DbSet<VotingEntity> Votings { get; set; }
    public DbSet<Participant> Participants { get; set; }
    public DbSet<ParticipantVoting> ParticipantVotings { get; set; }
}
