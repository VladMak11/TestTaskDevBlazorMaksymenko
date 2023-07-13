using BlazorAppDataAccess.Interfaces;
using BlazorAppDataAccess.Repository;
using BlazorAppModels.Models;
using BlazorAppwithIdentity.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorAppDataAccess.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;

        public IRepository<Property> Properties { get; private set; }
        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Properties = new Repository<Property>(_db);
        }
        public async Task SaveAsync()
        {
            await _db.SaveChangesAsync();
        }
    }
}
