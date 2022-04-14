using YamlBuilder.Implementations;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

var job  = GitLabYaml
    .Builder() 
    .Default()
        .Image("ruby:3.0")
        .After_Script(new string[] {"run a script"})
        .Artifacts()
            .Report()
                .Acessibility("report")
                .CoverageReport()
                .CoverageFormat("cobertura")
                .Path("./bin")
                .Terraform("file")
        .Before_Script(new string[] {"do something"})
    .Include()
        .Local("./WORKDIR")
    .Stages();
app.Run();

