var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.Portal>("portal");

builder.AddProject<Projects.BlazorApp1>("blazorapp1");

builder.AddProject<Projects.BlazorApp2>("blazorapp2");

//Class Library isn't added here. Only projects that can be run are added.
//builder.AddProject<Projects.RazorClassLibrary>("razorclasslibrary");

builder.Build().Run();
