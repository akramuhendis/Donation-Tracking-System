using System;
using System.Linq.Expressions;
using DonationTrackingSystem.Domain.Common;

namespace DonationTrackingSystem.Domain.Specifications
{
    /// <summary>
    /// Specification pattern için temel arayüz
    /// </summary>
    /// <typeparam name="T">Entity tipi</typeparam>
    public interface ISpecification<T> where T : BaseEntity
    {
        /// <summary>
        /// Specification'ın karşılanıp karşılanmadığını kontrol eden expression
        /// </summary>
        Expression<Func<T, bool>> Criteria { get; }

        /// <summary>
        /// Include edilecek navigation property'ler
        /// </summary>
        List<Expression<Func<T, object>>> Includes { get; }

        /// <summary>
        /// Sıralama expression'ı
        /// </summary>
        Expression<Func<T, object>>? OrderBy { get; }

        /// <summary>
        /// Ters sıralama expression'ı
        /// </summary>
        Expression<Func<T, object>>? OrderByDescending { get; }

        /// <summary>
        /// Sayfalama için atlanacak kayıt sayısı
        /// </summary>
        int Skip { get; }

        /// <summary>
        /// Sayfalama için alınacak kayıt sayısı
        /// </summary>
        int Take { get; }

        /// <summary>
        /// Sayfalama kullanılıp kullanılmayacağı
        /// </summary>
        bool IsPagingEnabled { get; }
    }
} 