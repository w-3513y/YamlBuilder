using YamlBuilder.Builder;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

GitLabYaml
    .Builder() 
    .Default()
        .Image()
        .Name("")
        .After_Script(new string[] {"echo 'something'"})
        .Artifacts()
            .Report()
                .Acessibility("report")
                .CoverageReport()
                .CoverageFormat("cobertura")
                .Path("./bin")
                .Terraform("file")
        .Before_Script(new string[] {"do something"})
        .Services()
        .Name("teste")
        .Alias("teste")
        .Name("teste2")
        .Alias("teste2")
    .Include()
        .Local("./WORKDIR")
    .Stages(new string[] {"build", "test", "deploy"})
    .Variables(new Dictionary<string, string>(){{"JOB_NAME", "TEST"}, {"ALIAS", "NEW_NAME"}});
app.Run();

