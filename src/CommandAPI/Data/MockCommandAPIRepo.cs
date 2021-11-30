using System.Collections.Generic;
using CommandAPI.Models;

namespace CommandAPI.Data
{
    public class MockCommandAPIRepo : ICommandAPIRepo
    {
        public void Create(Command entity)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(Command entity)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAll()
        {
            return new List<Command>{
                new Command{
                    Id =0, 
                    HowTo = "How to generate a migration",
                    CommandLine ="dotnet ef migrations add <Name of Migrations>",
                    Platform = ".Net Core EF"
                },    

                new Command{
                    Id = 1, HowTo="Run Migrations",
                    CommandLine="dotnet ef database update",
                    Platform = ".Net Core EF"
                }

            };
        }

        public Command GetById(int id)
        {
           return  new Command{
                    Id =0, 
                    HowTo = "How to generate a migration",
                    CommandLine ="dotnet ef migrations add <Name of Migrations>",
                    Platform = ".Net Core EF"
                };
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void Update(Command entity)
        {
            throw new System.NotImplementedException();
        }
    }
}