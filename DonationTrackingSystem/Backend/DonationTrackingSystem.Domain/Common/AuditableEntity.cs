using System;

namespace DonationTrackingSystem.Domain.Common
{
    /// <summary>
    /// Oluşturulma, güncellenme ve silinme gibi izleme alanlarını içeren soyut sınıf.
    /// </summary>
    public abstract class AuditableEntity : BaseEntity
    {
        /// <summary>
        /// Varlığın oluşturulma tarihi (otomatik atanır).
        /// </summary>
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// Varlık güncellendiğinde son güncellenme tarihi.
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Varlığın silinip silinmediğini belirten işaret (soft delete için).
        /// </summary>
        public bool IsDeleted { get; set; } = false;
    }
}
