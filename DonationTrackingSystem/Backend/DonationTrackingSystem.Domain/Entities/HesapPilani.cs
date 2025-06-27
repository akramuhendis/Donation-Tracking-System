using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonationTrackingSystem.Domain.Entities
{
    /// <summary>
    /// Hesap planı bilgilerini tutan ana varlık. BaseEntity'den Id, CreatedAt, UpdatedAt, IsDeleted gibi ortak alanları miras alır.
    /// </summary>
    public class HesapPlani : BaseEntity
    {
        /// <summary>
        /// Hesap planı kodu (ör: 100, 101 vb.)
        /// </summary>
        public string Kod { get; set; } = string.Empty;

        /// <summary>
        /// Hesap planı ile ilgili açıklama
        /// </summary>
        public string Aciklama { get; set; } = string.Empty;

        /// <summary>
        /// Hesap planına bağlı muhasebe fişlerinin listesi (navigation property)
        /// </summary>
        public ICollection<MuhasebeFis>? Fisler { get; set; }
    }

}
