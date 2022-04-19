using YamlBuilder.Builder;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

var fullPath = System.Reflection.Assembly.GetExecutingAssembly().Location + "gitlab.yml";

GitLabYaml
    .Builder(filePath: fullPath) 
    .Default()
        .Image()
            .Name("ruby:3.0")
        .AfterScript(commands: "echo 'something'")
        .Artifacts()
            .Exclude("\bin")
            .Report()
                .Acessibility(report: "report")
                .CoverageReport()
                .CoverageFormat(format: "cobertura")
                .Path(path: "./bin")
                .Terraform(report: "file")
        .BeforeScript(commands: "do something")
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