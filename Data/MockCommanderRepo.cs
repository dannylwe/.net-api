using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command{Id=0, HowTo="List files", Line="ls -la", Platform="Linux"},
                new Command{Id=1, HowTo="Delete file", Line="rm -f <filename>", Platform="Linux"},
                new Command{Id=2, HowTo="verify docker install", Line="docker", Platform="Linux"}
            };
            return commands;
        }

        public Command GetCommandById()
        {
            return new Command{Id=0, HowTo="List files", Line="ls -la", Platform="Linux"};
        }
    }
}