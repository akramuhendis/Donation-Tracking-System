using System;
using System.Collections.Generic;
using DonationTrackingSystem.Domain.Enums;
using DonationTrackingSystem.Domain.Common;
using DonationTrackingSystem.Domain.Events;

namespace DonationTrackingSystem.Domain.Entities
{
    /// <summary>
    /// Bağış işlemlerinin bilgilerini tutan sınıf
    /// </summary>
    public class Bagis : AuditableEntity // AuditableEntity'den miras alarak izleme alanları eklendi
    {
        private readonly List<IDomainEvent> _domainEvents = new();

        /// <summary>
        /// Bağışın türü (ör: nakit, eşya, hizmet)
        /// </summary>
        public BagisTuru BagisTuru { get; private set; } // Private set ile encapsulation

        /// <summary>
        /// Bağışın tutarı
        /// </summary>
        public decimal Tutar { get; private set; } // Private set ile encapsulation

        /// <summary>
        /// Bağış ile ilgili açıklama
        /// </summary>
        public string? Aciklama { get; private set; } // Private set ile encapsulation

        /// <summary>
        /// Bağışın yapıldığı tarih
        /// </summary>
        public DateTime BagisTaihi { get; private set; } // Private set ile encapsulation

        /// <summary>
        /// Bağışı yapan bağışçının kimlik numarası (foreign key)
        /// </summary>
        public Guid BagisciId { get; private set; } // Private set ile encapsulation

        /// <summary>
        /// Bağışı yapan bağışçıya ait bilgiler (navigation property)
        /// </summary>
        public Bagisci? Bagisci { get; private set; } // Private set ile encapsulation

        /// <summary>
        /// Domain olayları
        /// </summary>
        public IReadOnlyCollection<IDomainEvent> DomainEvents => _domainEvents.AsReadOnly();

        // Private constructor for EF Core
        private Bagis() { }

        /// <summary>
        /// Yeni bağış oluşturur
        /// </summary>
        public static Bagis Create(BagisTuru bagisTuru, decimal tutar, Guid bagisciId, string? aciklama = null)
        {
            if (tutar <= 0)
                throw new ArgumentException("Bağış tutarı sıfırdan büyük olmalıdır.");

            if (bagisciId == Guid.Empty)
                throw new ArgumentException("Geçerli bir bağışçı ID'si gereklidir.");

            var bagis = new Bagis
            {
                BagisTuru = bagisTuru,
                Tutar = tutar,
                BagisciId = bagisciId,
                Aciklama = aciklama,
                BagisTaihi = DateTime.UtcNow
            };

            // Domain event ekle
            bagis._domainEvents.Add(new BagisYapildiEvent(bagis, bagis.Bagisci!));

            return bagis;
        }

        /// <summary>
        /// Bağış tutarını günceller
        /// </summary>
        public void UpdateTutar(decimal yeniTutar)
        {
            if (yeniTutar <= 0)
                throw new ArgumentException("Bağış tutarı sıfırdan büyük olmalıdır.");

            Tutar = yeniTutar;
        }

        /// <summary>
        /// Bağış açıklamasını günceller
        /// </summary>
        public void UpdateAciklama(string? yeniAciklama)
        {
            Aciklama = yeniAciklama;
        }

        /// <summary>
        /// Domain olaylarını temizler
        /// </summary>
        public void ClearDomainEvents()
        {
            _domainEvents.Clear();
        }
    }
}
