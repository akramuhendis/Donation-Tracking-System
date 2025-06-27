using System;
using System.Threading.Tasks;

namespace DonationTrackingSystem.Domain.Repositories
{
    /// <summary>
    /// Unit of Work pattern için arayüz
    /// </summary>
    public interface IUnitOfWork : IDisposable
    {
        /// <summary>
        /// Bağış repository'si
        /// </summary>
        IBagisRepository BagisRepository { get; }

        /// <summary>
        /// Kullanıcı repository'si
        /// </summary>
        IRepository<Entities.Kullanici> KullaniciRepository { get; }

        /// <summary>
        /// Bağışçı repository'si
        /// </summary>
        IRepository<Entities.Bagisci> BagisciRepository { get; }

        /// <summary>
        /// Muhasebe fiş repository'si
        /// </summary>
        IRepository<Entities.MuhasebeFis> MuhasebeFisRepository { get; }

        /// <summary>
        /// Hesap planı repository'si
        /// </summary>
        IRepository<Entities.HesapPlani> HesapPlaniRepository { get; }

        /// <summary>
        /// Kasa banka repository'si
        /// </summary>
        IRepository<Entities.KasaBanka> KasaBankaRepository { get; }

        /// <summary>
        /// Değişiklikleri kaydeder
        /// </summary>
        Task<int> SaveChangesAsync();

        /// <summary>
        /// Transaction başlatır
        /// </summary>
        Task BeginTransactionAsync();

        /// <summary>
        /// Transaction'ı commit eder
        /// </summary>
        Task CommitTransactionAsync();

        /// <summary>
        /// Transaction'ı rollback eder
        /// </summary>
        Task RollbackTransactionAsync();
    }
} 