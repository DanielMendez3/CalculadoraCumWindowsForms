using CalculadoraCumDAL.Domain;
using CalculadoraCumDAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CalculadoraCumDAL.Repositories
{
    public abstract class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly CumCalculatorDBContext _context;
        public GenericRepository()
        {
            _context = new CumCalculatorDBContext();
        }
        protected IQueryable<T> PrepareQuery(
            IQueryable<T> query,
            Expression<Func<T, bool>> predicate = null,
            Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            int? take = null
        )
        {
            if (include != null)
                query = include(query);

            if (predicate != null)
                query = query.Where(predicate);

            if (orderBy != null)
                query = orderBy(query);

            if (take.HasValue)
                query = query.Take(Convert.ToInt32(take));

            return query;
        }

        #region Extras
        public virtual async Task<decimal?> SumAsync(
            Expression<Func<T, bool>> predicate = null
        )
        {
            var query = _context.Set<T>().AsQueryable();

            query = PrepareQuery(query, predicate);

            return await ((IQueryable<decimal?>)query).SumAsync();
        }

        public virtual decimal? Sum(
            Expression<Func<T, bool>> predicate = null
        )
        {
            var query = _context.Set<T>().AsQueryable();

            query = PrepareQuery(query, predicate);

            return ((IQueryable<decimal?>)query).Sum();
        }

        public virtual async Task<int> CountAsync(
            Expression<Func<T, bool>> predicate = null
        )
        {
            var query = _context.Set<T>().AsQueryable();

            query = PrepareQuery(query, predicate);

            return await query.CountAsync();
        }

        public virtual int Count(
            Expression<Func<T, bool>> predicate = null
        )
        {
            var query = _context.Set<T>().AsQueryable();

            query = PrepareQuery(query, predicate);

            return query.Count();
        }
        #endregion

        #region Get All
        public virtual IEnumerable<T> GetAll(
            Expression<Func<T, bool>> predicate = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            int? take = null,
            Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null
        )
        {
            var query = _context.Set<T>().AsQueryable();

            query = PrepareQuery(query, predicate, include, orderBy, take);

            return query.ToList();
        }
        public virtual IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public virtual async Task<IEnumerable<T>> GetAllAsync(
            Expression<Func<T, bool>> predicate = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            int? take = null,
            Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null
        )
        {
            var query = _context.Set<T>().AsQueryable();

            query = PrepareQuery(query, predicate, include, orderBy, take);

            return await query.ToListAsync();
        }

        public virtual async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }
        #endregion

        #region First
        public virtual T First(
            Expression<Func<T, bool>> predicate,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null
        )
        {
            var query = _context.Set<T>().AsQueryable();

            query = PrepareQuery(query, predicate, include, orderBy);

            return query.First();
        }

        public virtual async Task<T> FirstAsync(
            Expression<Func<T, bool>> predicate,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null
        )
        {
            var query = _context.Set<T>().AsQueryable();

            query = PrepareQuery(query, predicate, include, orderBy);

            return await query.FirstAsync();
        }

        public virtual T FirstOrDefault(
            Expression<Func<T, bool>> predicate,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null
        )
        {
            var query = _context.Set<T>().AsQueryable();

            query = PrepareQuery(query, predicate, include, orderBy);

            return query.FirstOrDefault();
        }

        public virtual async Task<T> FirstOrDefaultAsync(
            Expression<Func<T, bool>> predicate,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null
        )
        {
            var query = _context.Set<T>().AsQueryable();

            query = PrepareQuery(query, predicate, include, orderBy);

            return await query.FirstOrDefaultAsync();
        }
        #endregion

        #region Single
        public virtual T Single(
            Expression<Func<T, bool>> predicate,
            Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null
        )
        {
            var query = _context.Set<T>().AsQueryable();

            query = PrepareQuery(query, predicate, include);

            return query.Single();
        }

        public virtual async Task<T> SingleAsync(
            Expression<Func<T, bool>> predicate,
            Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null
        )
        {
            var query = _context.Set<T>().AsQueryable();

            query = PrepareQuery(query, predicate, include);

            return await query.SingleAsync();
        }

        public virtual T SingleOrDefault(
            Expression<Func<T, bool>> predicate,
            Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null
        )
        {
            var query = _context.Set<T>().AsQueryable();

            query = PrepareQuery(query, predicate, include);

            return query.SingleOrDefault();
        }

        public virtual async Task<T> SingleOrDefaultAsync(
            Expression<Func<T, bool>> predicate,
            Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null
        )
        {
            var query = _context.Set<T>().AsQueryable();

            query = PrepareQuery(query, predicate, include);

            return await query.SingleOrDefaultAsync();
        }
        #endregion

        #region Add
        public virtual void Add(T t)
        {
            _context.Add(t);
            _context.SaveChanges();
        }

        public virtual void Add(IEnumerable<T> t)
        {
            _context.AddRange(t);
            _context.SaveChanges();
        }

        public virtual async Task AddAsync(T t)
        {
            await _context.AddAsync(t);
            await  _context.SaveChangesAsync();
        }

        public virtual async Task AddAsync(IEnumerable<T> t)
        {
            await _context.AddRangeAsync(t);
            await _context.SaveChangesAsync();
        }
        #endregion

        #region Remove
        public virtual void Remove(T t)
        {
            _context.Remove(t);
            _context.SaveChanges();
        }

        public virtual void Remove(IEnumerable<T> t)
        {
            _context.RemoveRange(t);
            _context.SaveChanges();
        }
        #endregion

        #region Update
        public virtual void Update(T t)
        {
            _context.Update(t);
            _context.SaveChanges();
        }

        public virtual void Update(IEnumerable<T> t)
        {
            _context.UpdateRange(t);
            _context.SaveChanges();
        }
        #endregion
    }
}
