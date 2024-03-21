using Bookly.Application.Common.Interfaces;
using Bookly.Domain.Entities;
using Bookly.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Bookly.Infrastructure.Repository
{
    public class VillaRepository :Repository<Villa> , IVillaRepository
    {
        private readonly ApplicationDbContext _db;

        public VillaRepository(ApplicationDbContext db):base(db)
        {
            _db = db;
        }


        public void Save()
        {
           _db.SaveChanges();
        }

        public void Update(Villa entity)
        {
            _db.Update(entity);
        }
    }
}
