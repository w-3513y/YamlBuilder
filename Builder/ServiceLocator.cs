using YamlBuilder.Interfaces.GlobalKeywords;
using YamlBuilder.Interfaces.JobsKeywords.Default;
using YamlBuilder.Interfaces.JobsKeywords.Default.Image;

namespace YamlBuilder.Builder;
public interface IServiceLocator
{
    T GetService<T>();
}

class ServiceLocator : BaseBuilder, IServiceLocator
{
// mapa que contém pares de interfaces e
// referencias para as implementações concretas
    private IDictionary<object, object> services;

    internal ServiceLocator(string path)
    : base(path)
    {
        services = new Dictionary<object, object>();
        this.services.Add(typeof(IDefault), new Default.Default(_fullPath));
            this.services.Add(typeof(IDefault_Image), new Default.Image.Image(_fullPath));
                this.services.Add(typeof(IDefault_Image_EntryPoint), new Default.Image.Entrypoint(_fullPath));
                this.services.Add(typeof(IDefault_Image_Name), new Default.Image.Name(_fullPath));
            this.services.Add(typeof(IDefault_AfterScript), new Default.AfterScript(_fullPath));
            this.services.Add(typeof(IDefault_AfterScript), new Default.Artifacts(_fullPath));
            this.services.Add(typeof(IDefault_BeforeScript), new Default.BeforeScript(_fullPath));
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