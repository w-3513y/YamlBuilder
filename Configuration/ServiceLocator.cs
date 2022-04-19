using YamlBuilder.Builder;
using YamlBuilder.Interfaces.GlobalKeywords;
using YamlBuilder.Interfaces.JobsKeywords.Default;
using YamlBuilder.Interfaces.JobsKeywords.Default.Artifact;
using YamlBuilder.Interfaces.JobsKeywords.Default.Artifact.RepostTypes;
using YamlBuilder.Interfaces.JobsKeywords.Default.Cache;
using YamlBuilder.Interfaces.JobsKeywords.Default.Image;
using YamlBuilder.Interfaces.JobsKeywords.Default.Services;

namespace YamlBuilder.Configuration;
public interface IServiceLocator
{
    T GetService<T>();
}

class ServiceLocator : BaseBuilder, IServiceLocator
{
    private IDictionary<object, object> services;

    internal ServiceLocator(string path)
    : base(path)
    {
        services = new Dictionary<object, object>();
        this.services.Add(typeof(IDefault), new Builder.Default.Default(_fullPath));
            this.services.Add(typeof(IDefault_ImageShortSyntax), new Builder.Default.Image.Image(_fullPath));
            this.services.Add(typeof(IDefault_Image), new Builder.Default.Image.Image(_fullPath));
                this.services.Add(typeof(IDefault_Image_EntryPoint), new Builder.Default.Image.Entrypoint(_fullPath));
                this.services.Add(typeof(IDefault_Image_Name), new Builder.Default.Image.Name(_fullPath));
            this.services.Add(typeof(IDefault_AfterScript), new Builder.Default.AfterScript(_fullPath));
            this.services.Add(typeof(IDefault_Artifacts), new Builder.Default.Artifact.Artifacts(_fullPath));
                this.services.Add(typeof(IDefault_Artifacts_Exclude), new Builder.Default.Artifact.Exclude(_fullPath));
                this.services.Add(typeof(IDefault_Artifacts_ExpireIn), new Builder.Default.Artifact.ExpireIn(_fullPath));
                this.services.Add(typeof(IDefault_Artifacts_ExposeAs), new Builder.Default.Artifact.ExposeAs(_fullPath));
                this.services.Add(typeof(IDefault_Artifacts_Name), new Builder.Default.Artifact.Name(_fullPath));
                this.services.Add(typeof(IDefault_Artifacts_Paths), new Builder.Default.Artifact.Paths(_fullPath));
                this.services.Add(typeof(IDefault_Artifacts_Public), new Builder.Default.Artifact.Public(_fullPath));
                this.services.Add(typeof(IDefault_Artifacts_Untracked), new Builder.Default.Artifact.Untracked(_fullPath));
                this.services.Add(typeof(IDefault_Artifacts_When), new Builder.Default.Artifact.When(_fullPath));
                this.services.Add(typeof(IDefault_Artifacts_Report), new Builder.Default.Artifact.Reports.Report(_fullPath));
                    this.services.Add(typeof(IDefault_Artifacts_Report_Acessibility), new Builder.Default.Artifact.Reports.Acessibility(_fullPath));
                    this.services.Add(typeof(IDefault_Artifacts_Report_CodeQuality), new Builder.Default.Artifact.Reports.CodeQuality(_fullPath));
                    this.services.Add(typeof(IDefault_Artifacts_Report_CoverageReport), new Builder.Default.Artifact.Reports.CoverageReport(_fullPath));
                    this.services.Add(typeof(IDefault_Artifacts_Report_CoverageFormat), new Builder.Default.Artifact.Reports.CoverageFormat(_fullPath));
                    this.services.Add(typeof(IDefault_Artifacts_Report_Path), new Builder.Default.Artifact.Reports.Path(_fullPath));
                    this.services.Add(typeof(IDefault_Artifacts_Report_DotEnv), new Builder.Default.Artifact.Reports.DotEnv(_fullPath));
                    this.services.Add(typeof(IDefault_Artifacts_Report_JUnit), new Builder.Default.Artifact.Reports.JUnit(_fullPath));
                    this.services.Add(typeof(IDefault_Artifacts_Report_Sast), new Builder.Default.Artifact.Reports.Sast(_fullPath));
                    this.services.Add(typeof(IDefault_Artifacts_Report_SecretDetection), new Builder.Default.Artifact.Reports.SecretDetection(_fullPath));
                    this.services.Add(typeof(IDefault_Artifacts_Report_Terraform), new Builder.Default.Artifact.Reports.Terraform(_fullPath));
            this.services.Add(typeof(IDefault_BeforeScript), new Builder.Default.BeforeScript(_fullPath));
            this.services.Add(typeof(IDefault_Cache), new Builder.Default.Cache.Cache(_fullPath));
            this.services.Add(typeof(IDefault_Retry), new Builder.Default.Retry(_fullPath));
            this.services.Add(typeof(IDefault_ServicesShortSyntax), new Builder.Default.Services.ServicesShortSyntax(_fullPath));
            this.services.Add(typeof(IDefault_Services), new Builder.Default.Services.Services(_fullPath));
            this.services.Add(typeof(IDefault_Tags), new Builder.Default.Tags(_fullPath));
            this.services.Add(typeof(IDefault_Timeouts), new Builder.Default.TimeOut(_fullPath));
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