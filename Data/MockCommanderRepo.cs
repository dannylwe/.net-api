using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data{
    public class MockCommanderRepo : ICommanderRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command{Id=0, HowTo="List files", Line="ls -la", Platform="Linux"},
                new Command{Id=1, HowTo="Delete file", Line="rm -f <filename>", Platform="Linux"},
                new Command{Id=2, HowTo="verify docker install", Line="docker", Platform="Linux"},
                new Command{Id=3, HowTo="New dotnet project", Line="dotnet new -n <project name>", Platform="Dotnet"},
                new Command{Id=4, HowTo="Create new .gitignore file dotnet", Line="dotnet new gitignore", Platform="Dotnet"},
            };
            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command{Id=0, HowTo="List files", Line="ls -la", Platform="Linux"};
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }
    }
}