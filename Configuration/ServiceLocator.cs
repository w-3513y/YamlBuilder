using YamlBuilder.Builder;
using YamlBuilder.Interfaces.GlobalKeywords;
using YamlBuilder.Interfaces.JobsKeywords.Default;
using YamlBuilder.Interfaces.JobsKeywords.Default.Artifact;
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