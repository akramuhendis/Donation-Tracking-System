using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using DonationTrackingSystem.Domain.Common;

namespace DonationTrackingSystem.Domain.Repositories
{
    /// <summary>
    /// Tüm repository'ler için temel arayüz
    /// </summary>
    /// <typeparam name="T">Entity tipi</typeparam>
    public interface IRepository<T> where T : BaseEntity
    {
        /// <summary>
        /// Varlığı ID'ye göre getirir
        /// </summary>
        Task<T?> GetByIdAsync(Guid id);

        /// <summary>
        /// Tüm varlıkları getirir
        /// </summary>
        Task<IEnumerable<T>> GetAllAsync();

        /// <summary>
        /// Koşula göre varlıkları getirir
        /// </summary>
        Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate);

        /// <summary>
        /// Varlık ekler
        /// </summary>
        Task<T> AddAsync(T entity);

        /// <summary>
        /// Varlık günceller
        /// </summary>
        Task UpdateAsync(T entity);

        /// <summary>
        /// Varlık siler
        /// </summary>
        Task DeleteAsync(Guid id);

        /// <summary>
        /// Varlığın var olup olmadığını kontrol eder
        /// </summary>
        Task<bool> ExistsAsync(Guid id);
    }
} 