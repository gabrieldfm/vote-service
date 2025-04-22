using Microsoft.EntityFrameworkCore;
using VotingSystem.Application.Entities;

namespace VotingSystem.Infrastructure.ApplicationDbContext;

public class VotingSystemDbContext(DbContextOptions<VotingSystemDbContext> options) : DbContext(options)
{
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<ParticipantVoting>()
            .HasKey(pv => new { pv.Id, pv.VotingId, pv.ParticipantId });

        builder.Entity<Voting>()
            .HasMany(v => v.Participants)
            .WithMany(p => p.Votings)
            .UsingEntity<ParticipantVoting>();

        base.OnModelCreating(builder);
    }

    public DbSet<Voting> Votings { get; set; }
    public DbSet<Participant> Participants { get; set; }
    public DbSet<ParticipantVoting> ParticipantVotings { get; set; }
}
