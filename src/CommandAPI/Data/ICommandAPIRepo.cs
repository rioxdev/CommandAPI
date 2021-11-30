using System.Collections.Generic;
using CommandAPI.Models;

namespace CommandAPI.Data
{
    public interface ICommandAPIRepo
    {
        bool SaveChanges();
        IEnumerable<Command> GetAll();
        Command GetById(int id);
        void Create(Command entity);
        void Update(Command entity);
        void Delete(Command entity);
    }
}