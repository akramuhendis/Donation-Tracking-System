using System;

namespace DonationTrackingSystem.Domain.Common
{
    /// <summary>
    /// Tüm varlıklar için ortak Id alanını içeren temel soyut sınıf.
    /// </summary>
    public abstract class BaseEntity
    {
        public Guid Id { get; set; }
    }
}
