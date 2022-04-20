using YamlBuilder.Builder;
using YamlBuilder.Configuration;
using YamlBuilder.Enums;

var fullPath = System.Reflection.Assembly.GetExecutingAssembly().Location + "gitlab-ci.yml";

IServiceLocator servicelocator = new ServiceLocator(fullPath);

GitLabYaml
    .Builder(fullPath, servicelocator) 
    .Default()
        .Image()
            .Name("mcr.microsoft.com/dotnet/sdk:latest")
            .Entrypoint("/bin/bash")
        .BeforeScript("rspec --format RspecJunitFormatter --out rspec.xml")
        .AfterScript("echo \"Execute this command before any 'script:' commands.\"")
        .Artifacts()
            .Public(false)
            .Untracked(true)
            .When(JobGlobal.always)
            .Name("job1-artifacts-file")
            .ExposeAs("artifact_UI")
            .Paths(new string[] {"bin/"})
            .Exclude("bin/**/*.json")
            .Report()
                .Acessibility(report: "report")
                .CoverageReport()
                .CoverageFormat(format: "cobertura")
                .Path(path: "./bin")
                .JUnit("rspec.xml")
                .Terraform(report: "file")
            .ExpireIn("1 week")
        .Cache()
            .Untracked(true)
            .Key("binaries/*.apk")
            .Paths(new string[] {"binaries/*.apk", ".config"})
            .Policy(GitCommand.push)
            .When(JobGlobal.on_failure)
        .Interruptible(true)
        .Retry(Retry.Two) //copy retry from job, default retry is incomplete
        .Services()
            .Name("my-postgres:11.7") //service that will be run into docker
            .Alias("db-postgres")
            .Entrypoint("/usr/local/bin/db-postgres")
            .Command("start")
        .Tags(new string[] {"dotnet"}) //elect a specific runner from the list of all runners that are available for the project.
        .Timeouts("3h 30m") //If the job runs for longer than the timeout, the job fails.        
    .Include()
        .Remote("https://raw.githubusercontent.com/w-3513y/gitlabAux/main/.child.yml")
    .Stages(new string[] { "build", "test", "deploy" })
    .Variables()
        .Key("DEPLOY_ENVIRONMENT")
        .Value(".pre")
        .Description("The deployment target. Change this variable to 'canary' or 'production' if needed.")
        .Key("DEVELOPER")
        .Value("tester")
        .Description("change the value of this variable to save your user as a artifact.");
