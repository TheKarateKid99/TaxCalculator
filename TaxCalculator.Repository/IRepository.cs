using System;
using System.Collections.Generic;
using System.Text;

namespace TaxCalculator.Repository
{
    public interface IRepository<TEntity> where TEntity : class, new()
    {
        TEntity Add(TEntity entity);
    }
}
