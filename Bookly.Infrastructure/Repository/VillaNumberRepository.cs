using Bookly.Application.Common.Interfaces;
using Bookly.Domain.Entities;
using Bookly.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Bookly.Infrastructure.Repository
{
    public class VillaNumberRepository :Repository<VillaNumber>, IVillaNumberRepository
    {

        private readonly ApplicationDbContext _db;

        public VillaNumberRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }


      

        public void Update(VillaNumber entity)
        {
            _db.Update(entity);
        }
    }
}
