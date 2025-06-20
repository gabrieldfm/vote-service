﻿namespace VotingSystem.Application.Entities;

public class Participant
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public List<Voting>? Votings { get; set; }
}
