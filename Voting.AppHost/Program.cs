var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.Voting_ApiService>("apiservice");

builder.AddProject<Projects.Voting_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService)
    .WaitFor(apiService);

builder.Build().Run();
