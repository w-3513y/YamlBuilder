namespace YamlBuilder.Interfaces.Keywords.Default.IServices;

public interface ICommand{
}

public interface ICommandNavigation{
    public ICommand Command(string command);
}