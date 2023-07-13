using BlazorAppModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorAppDataAccess.Interfaces
{
    public interface IUnitOfWork
    {
        IRepository<Property> Properties { get; }
        Task SaveAsync();
    }
}
