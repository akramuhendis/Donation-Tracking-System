using System;
using System.Threading.Tasks;
using DonationTrackingSystem.Domain.Entities;
using DonationTrackingSystem.Domain.ValueObjects;

namespace DonationTrackingSystem.Domain.Services
{
    /// <summary>
    /// Bağış işlemleri için domain servis arayüzü
    /// </summary>
    public interface IBagisService
    {
        /// <summary>
        /// Yeni bağış oluşturur ve iş kurallarını uygular
        /// </summary>
        Task<Bagis> CreateBagisAsync(Bagisci bagisci, Money tutar, string? aciklama);

        /// <summary>
        /// Bağış geçerliliğini kontrol eder
        /// </summary>
        Task<bool> ValidateBagisAsync(Bagis bagis);

        /// <summary>
        /// Bağışçının bağış limitini kontrol eder
        /// </summary>
        Task<bool> CheckBagisciLimitAsync(Guid bagisciId, Money yeniTutar);

        /// <summary>
        /// Bağış istatistiklerini hesaplar
        /// </summary>
        Task<BagisIstatistikleri> GetBagisIstatistikleriAsync(DateTime baslangic, DateTime bitis);
    }

    /// <summary>
    /// Bağış istatistikleri için değer nesnesi
    /// </summary>
    public class BagisIstatistikleri
    {
        public int ToplamBagisSayisi { get; set; }
        public Money ToplamBagisTutari { get; set; }
        public decimal OrtalamaBagisTutari { get; set; }
        public int AktifBagisciSayisi { get; set; }
    }
} 