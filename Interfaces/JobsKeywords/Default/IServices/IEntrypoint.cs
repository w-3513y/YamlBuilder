namespace YamlBuilder.Interfaces.Keywords.Default.IServices;

public interface IEntryPoint:
    //going down 1 level(s)
    ICommandNavigation
{}

public interface IEntryPointNavigation{
    public IEntryPoint Entrypoint(string entrypoint);
}