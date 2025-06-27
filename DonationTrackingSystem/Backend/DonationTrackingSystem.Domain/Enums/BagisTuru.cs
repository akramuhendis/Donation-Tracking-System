using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonationTrackingSystem.Domain.Enums
{
    /// <summary>
    /// Bağışın türünü belirten enum
    /// </summary>
    public enum BagisTuru
    {
        /// <summary>
        /// Nakit olarak yapılan bağış
        /// </summary>
        Nakit = 1,
        
        /// <summary>
        /// Eşya olarak yapılan bağış
        /// </summary>
        Esya = 2,
        
        /// <summary>
        /// Hizmet olarak yapılan bağış
        /// </summary>
        Hizmet = 3,
        
        /// <summary>
        /// Banka havalesi ile yapılan bağış
        /// </summary>
        BankaHavalesi = 4,
        
        /// <summary>
        /// Kredi kartı ile yapılan bağış
        /// </summary>
        KrediKarti = 5,
        
        /// <summary>
        /// Çek ile yapılan bağış
        /// </summary>
        Cek = 6,
        
        /// <summary>
        /// Senet ile yapılan bağış
        /// </summary>
        Senet = 7,
        
        /// <summary>
        /// Gayrimenkul bağışı
        /// </summary>
        Gayrimenkul = 8,
        
        /// <summary>
        /// Menkul kıymet bağışı
        /// </summary>
        MenkulKymet = 9,
        
        /// <summary>
        /// Diğer türdeki bağışlar
        /// </summary>
        Diger = 10
    }
}
