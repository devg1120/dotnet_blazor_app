var builder = DistributedApplication.CreateBuilder(args);


var api = builder.AddProject<Projects.BackendWebApi>("backend");

builder.AddProject<Projects.FrontBlazor>("frontend")
    .WithReference(api);


builder.Build().Run();
