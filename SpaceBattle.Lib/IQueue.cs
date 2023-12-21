namespace SpaceBattle.Lib;
using _ICommand;

public interface IQueue
{
    public void Push(ICommand cmd);
    public ICommand Take();
}