using Bookly.Application.Common.Interfaces;
using Bookly.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookly.Infrastructure.Repository
{
    public interface IApplicationUserRepository: IRepository<ApplicationUser>
    {
    }
}
