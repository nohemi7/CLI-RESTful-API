using Commander.Models;

namespace Commander.Data
{
    public interface ICommnanderRepo
    {
        IEnumerable<Command> GetAppCommands();
        Command GetCommandById(int id);
    }
}