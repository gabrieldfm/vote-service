var builder = DistributedApplication.CreateBuilder(args);

var db = builder.AddPostgres("postgres")
    .WithDataVolume();

var postgresdb = db.AddDatabase("votingdb");

var apiService = builder.AddProject<Projects.Voting_ApiService>("apiservice")
    .WithReference(postgresdb);

builder.AddProject<Projects.Voting_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService)
    .WaitFor(apiService);

builder.Build().Run();
