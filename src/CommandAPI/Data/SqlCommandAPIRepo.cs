using System.Collections.Generic;
using System.Linq;
using CommandAPI.Models;

namespace CommandAPI.Data
{
    public class SqlCommandAPIRepo : ICommandAPIRepo
    {
        private readonly CommandContext _context;
        public SqlCommandAPIRepo(CommandContext context)
        {
            _context = context;
        }

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
            return _context.CommandItems.ToList();
        }

        public Command GetById(int id)
        {
            return _context.CommandItems.FirstOrDefault(c => c.Id == id);
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