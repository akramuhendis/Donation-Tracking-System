using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DonationTrackingSystem.Domain.Entities;
using DonationTrackingSystem.Domain.Enums;

namespace DonationTrackingSystem.Domain.Repositories
{
    /// <summary>
    /// Bağış işlemleri için özel repository arayüzü
    /// </summary>
    public interface IBagisRepository : IRepository<Bagis>
    {
        /// <summary>
        /// Belirli bir bağışçının tüm bağışlarını getirir
        /// </summary>
        Task<IEnumerable<Bagis>> GetBagislarByBagisciIdAsync(Guid bagisciId);

        /// <summary>
        /// Belirli bir tarih aralığındaki bağışları getirir
        /// </summary>
        Task<IEnumerable<Bagis>> GetBagislarByDateRangeAsync(DateTime startDate, DateTime endDate);

        /// <summary>
        /// Belirli bir bağış türündeki bağışları getirir
        /// </summary>
        Task<IEnumerable<Bagis>> GetBagislarByTypeAsync(BagisTuru bagisTuru);

        /// <summary>
        /// Toplam bağış miktarını hesaplar
        /// </summary>
        Task<decimal> GetTotalBagisAmountAsync();

        /// <summary>
        /// Belirli bir bağışçının toplam bağış miktarını hesaplar
        /// </summary>
        Task<decimal> GetTotalBagisAmountByBagisciAsync(Guid bagisciId);
    }
} 