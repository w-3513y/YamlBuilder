using YamlBuilder.Interfaces.GlobalKeywords;
using YamlBuilder.Interfaces.JobsKeywords.Default;
using YamlBuilder.Interfaces.JobsKeywords.Default.Artifact;
using YamlBuilder.Interfaces.JobsKeywords.Default.Artifact.RepostTypes;
using YamlBuilder.Interfaces.JobsKeywords.Default.Cache;
using YamlBuilder.Interfaces.JobsKeywords.Default.Image;
using YamlBuilder.Interfaces.JobsKeywords.Default.Services;
using YamlBuilder.Interfaces.JobsKeywords.Include;
using YamlBuilder.Interfaces.JobsKeywords.Variables;

namespace YamlBuilder.Configuration;
public interface IServiceLocator
{
    T GetService<T>();
}

class ServiceLocator : IServiceLocator
{
    private IDictionary<object, object> services;

    internal ServiceLocator(string path)
    {
        services = new Dictionary<object, object>();
        this.services.Add(typeof(IDefault), new Builder.Default.Default(path, this));
            this.services.Add(typeof(IDefault_ImageShortSyntax), new Builder.Default.Image.Image(path, this));
            this.services.Add(typeof(IDefault_Image), new Builder.Default.Image.Image(path, this));
                this.services.Add(typeof(IDefault_Image_EntryPoint), new Builder.Default.Image.Entrypoint(path, this));
                this.services.Add(typeof(IDefault_Image_Name), new Builder.Default.Image.Name(path, this));
            this.services.Add(typeof(IDefault_AfterScript), new Builder.Default.AfterScript(path, this));
            this.services.Add(typeof(IDefault_Artifacts), new Builder.Default.Artifact.Artifacts(path, this));
                this.services.Add(typeof(IDefault_Artifacts_Exclude), new Builder.Default.Artifact.Exclude(path, this));
                this.services.Add(typeof(IDefault_Artifacts_ExpireIn), new Builder.Default.Artifact.ExpireIn(path, this));
                this.services.Add(typeof(IDefault_Artifacts_ExposeAs), new Builder.Default.Artifact.ExposeAs(path, this));
                this.services.Add(typeof(IDefault_Artifacts_Name), new Builder.Default.Artifact.Name(path, this));
                this.services.Add(typeof(IDefault_Artifacts_Paths), new Builder.Default.Artifact.Paths(path, this));
                this.services.Add(typeof(IDefault_Artifacts_Public), new Builder.Default.Artifact.Public(path, this));
                this.services.Add(typeof(IDefault_Artifacts_Untracked), new Builder.Default.Artifact.Untracked(path, this));
                this.services.Add(typeof(IDefault_Artifacts_When), new Builder.Default.Artifact.When(path, this));
                this.services.Add(typeof(IDefault_Artifacts_Report), new Builder.Default.Artifact.Reports.Report(path, this));
                    this.services.Add(typeof(IDefault_Artifacts_Report_Acessibility), new Builder.Default.Artifact.Reports.Acessibility(path, this));
                    this.services.Add(typeof(IDefault_Artifacts_Report_CodeQuality), new Builder.Default.Artifact.Reports.CodeQuality(path, this));
                    this.services.Add(typeof(IDefault_Artifacts_Report_CoverageReport), new Builder.Default.Artifact.Reports.CoverageReport(path, this));
                    this.services.Add(typeof(IDefault_Artifacts_Report_CoverageFormat), new Builder.Default.Artifact.Reports.CoverageFormat(path, this));
                    this.services.Add(typeof(IDefault_Artifacts_Report_Path), new Builder.Default.Artifact.Reports.Path(path, this));
                    this.services.Add(typeof(IDefault_Artifacts_Report_DotEnv), new Builder.Default.Artifact.Reports.DotEnv(path, this));
                    this.services.Add(typeof(IDefault_Artifacts_Report_JUnit), new Builder.Default.Artifact.Reports.JUnit(path, this));
                    this.services.Add(typeof(IDefault_Artifacts_Report_Sast), new Builder.Default.Artifact.Reports.Sast(path, this));
                    this.services.Add(typeof(IDefault_Artifacts_Report_SecretDetection), new Builder.Default.Artifact.Reports.SecretDetection(path, this));
                    this.services.Add(typeof(IDefault_Artifacts_Report_Terraform), new Builder.Default.Artifact.Reports.Terraform(path, this));
            this.services.Add(typeof(IDefault_BeforeScript), new Builder.Default.BeforeScript(path, this));
            this.services.Add(typeof(IDefault_Cache), new Builder.Default.Cache.Cache(path, this));
                this.services.Add(typeof(IDefault_Cache_Files), new Builder.Default.Cache.Files(path, this));
                this.services.Add(typeof(IDefault_Cache_Key), new Builder.Default.Cache.Key(path, this));
                this.services.Add(typeof(IDefault_Cache_Paths), new Builder.Default.Cache.Paths(path, this));
                this.services.Add(typeof(IDefault_Cache_Policy), new Builder.Default.Cache.Policy(path, this));
                this.services.Add(typeof(IDefault_Cache_Prefix), new Builder.Default.Cache.Prefix(path, this));
                this.services.Add(typeof(IDefault_Cache_Untracked), new Builder.Default.Cache.Untracked(path, this));
                this.services.Add(typeof(IDefault_Cache_When), new Builder.Default.Cache.When(path, this));
            this.services.Add(typeof(IDefault_Retry), new Builder.Default.Retry(path, this));
            this.services.Add(typeof(IDefault_ServicesShortSyntax), new Builder.Default.Services.ServicesShortSyntax(path, this));
            this.services.Add(typeof(IDefault_Services), new Builder.Default.Services.Services(path, this));
                this.services.Add(typeof(IDefault_Services_Name), new Builder.Default.Services.Name(path, this));
                this.services.Add(typeof(IDefault_Services_Alias), new Builder.Default.Services.Alias(path, this));
                this.services.Add(typeof(IDefault_Services_EntryPoint), new Builder.Default.Services.Entrypoint(path, this));
                this.services.Add(typeof(IDefault_Services_Command), new Builder.Default.Services.Command(path, this));
            this.services.Add(typeof(IDefault_Tags), new Builder.Default.Tags(path, this));
            this.services.Add(typeof(IDefault_Timeouts), new Builder.Default.TimeOut(path, this));
        this.services.Add(typeof(IIncludeShortSyntax), new Builder.Include.IncludeShortSyntax(path, this));
        this.services.Add(typeof(IInclude), new Builder.Include.Include(path, this));
            this.services.Add(typeof(IInclude_File), new Builder.Include.File(path, this));
            this.services.Add(typeof(IInclude_Local), new Builder.Include.Local(path, this));
            this.services.Add(typeof(IInclude_Project), new Builder.Include.Project(path, this));
            this.services.Add(typeof(IInclude_Ref), new Builder.Include.Ref(path, this));
            this.services.Add(typeof(IInclude_Remote), new Builder.Include.Remote(path, this));
            this.services.Add(typeof(IInclude_Template), new Builder.Include.Template(path, this));
        this.services.Add(typeof(IStages), new Builder.Stages.Stages(path, this));
        this.services.Add(typeof(IVariablesShortSyntax), new Builder.Variables.VariablesShortSyntax(path, this));
        this.services.Add(typeof(IVariables), new Builder.Variables.Variables(path, this));
            this.services.Add(typeof(IVariables_Key), new Builder.Variables.Key(path, this));
            this.services.Add(typeof(IVariables_Value), new Builder.Variables.Value(path, this));
            this.services.Add(typeof(IVariables_Description), new Builder.Variables.Description(path, this));
    }

    public T GetService<T>()
    {
        try
        {
            return (T)services[typeof(T)];
        }
        catch (KeyNotFoundException)
        {
            throw new ApplicationException("the requested service wasn't implemented.");
        }
    }
}