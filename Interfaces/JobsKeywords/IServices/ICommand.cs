namespace YamlBuilder.Interfaces.Keywords.IServices;

public interface ICommand{
}

public interface ICommandNavigation{
    public ICommand Command(string command);
}