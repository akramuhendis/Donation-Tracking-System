using System;
using DonationTrackingSystem.Domain.Entities;

namespace DonationTrackingSystem.Domain.Events
{
    /// <summary>
    /// Bağış yapıldığında tetiklenen domain olayı
    /// </summary>
    public class BagisYapildiEvent : IDomainEvent
    {
        public Guid EventId { get; } = Guid.NewGuid();
        public DateTime OccurredOn { get; } = DateTime.UtcNow;

        public Guid BagisId { get; }
        public Guid BagisciId { get; }
        public decimal Tutar { get; }
        public string BagisciAdi { get; }

        public BagisYapildiEvent(Bagis bagis, Bagisci bagisci)
        {
            BagisId = bagis.Id;
            BagisciId = bagisci.Id;
            Tutar = bagis.Tutar;
            BagisciAdi = bagisci.AdSoyad;
        }
    }
} 