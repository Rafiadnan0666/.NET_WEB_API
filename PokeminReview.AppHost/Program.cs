var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.PokeminReview>("pokeminreview");

builder.Build().Run();
