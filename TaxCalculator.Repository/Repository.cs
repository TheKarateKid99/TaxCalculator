using System;
using System.Collections.Generic;
using System.Text;

namespace TaxCalculator.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class, new()
    {
        protected readonly IncomeTaxContext _incomeTaxContext;

        public Repository(IncomeTaxContext incomeTaxContext)
        {
            _incomeTaxContext = incomeTaxContext;
        }

        public TEntity Add(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException($"{nameof(Add)} entity must not be null");
            }

            try
            {
                var result = _incomeTaxContext.Add(entity);
                var outcome = _incomeTaxContext.SaveChanges();

                return entity;
            }
            catch (Exception ex)
            {
                throw new Exception($"{nameof(entity)} could not be saved: {ex.Message}");
            }
        }
    }
}
